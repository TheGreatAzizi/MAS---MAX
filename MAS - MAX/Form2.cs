using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MAS___MAX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            homeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            AnimesearchToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A | Keys.S;
            moviesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M | Keys.T;
            seriesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S | Keys.T;
            searchToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M | Keys.S;
            helpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;

            refreshButton.Click += RefreshButton_Click;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadAnimeData();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadAnimeData();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadAnimeData()
        {
            var animes = await GetTopAnimes();
            dataGridView.Rows.Clear();
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("Rank", "Rank");
                dataGridView.Columns.Add("RomajiTitle", "Title (Romaji)");
                dataGridView.Columns.Add("Score", "Score");
            }

            foreach (var anime in animes)
            {
                dataGridView.Rows.Add(anime.Rank, anime.Title.Romaji, anime.AverageScore);
            }
        }

        private async Task<List<Anime>> GetTopAnimes()
        {
            var apiUrl = "https://graphql.anilist.co";
            var client = new HttpClient();
            var query = @"
            query ($page: Int, $perPage: Int) {
                Page(page: $page, perPage: $perPage) {
                    media(sort: SCORE_DESC, type: ANIME) {
                        id
                        title {
                            romaji
                        }
                        averageScore
                        popularity
                    }
                }
            }";
            var variables = new { page = 1, perPage = 10 };
            var payload = new
            {
                query,
                variables
            };

            var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(apiUrl),
                Content = content
            };

            HttpResponseMessage response = await client.SendAsync(request);
            var responseBody = await response.Content.ReadAsStringAsync();

            var result = JObject.Parse(responseBody);
            var mediaList = result["data"]["Page"]["media"].ToObject<List<Anime>>();

            for (int i = 0; i < mediaList.Count; i++)
            {
                mediaList[i].Rank = i + 1; // تنظیم رتبه هر انیمه
            }

            return mediaList;
        }

        private class Anime
        {
            public int Rank { get; set; } // اضافه کردن رتبه برای هر انیمه
            public Title Title { get; set; }
            public double AverageScore { get; set; }
        }

        private class Title
        {
            public string Romaji { get; set; }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homebeta homee = new homebeta();
            homee.Show();
            this.Close();
        }

        private void AnimesearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ggg = new Form1();
            ggg.Show();
            this.Close();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpi dd = new helpi();
            dd.ShowDialog();
        }

        private void telegramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("https://t.me/luluch_code", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mostodonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("https://mas.to/@luluch_code", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
