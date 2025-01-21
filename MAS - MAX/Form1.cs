using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Web;

namespace MAS___MAX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            listBoxRelated.Click += ListBoxRelated_Click;
            homeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            top10ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A | Keys.K;
            moviesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M | Keys.T;
            seriesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S | Keys.T;
            searchToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M | Keys.S;
            helpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;

        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string animeName = textBox1.Text;
                if (!string.IsNullOrEmpty(animeName))
                {
                    await DisplayAnimeInfo(animeName);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ListBoxRelated_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxRelated.SelectedItem != null)
                {
                    string relatedAnimeName = listBoxRelated.SelectedItem.ToString();
                    await DisplayAnimeInfo(relatedAnimeName);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DisplayAnimeInfo(string animeName)
        {
            try
            {
                var animeInfo = await GetAnimeInfo(animeName);
                if (animeInfo != null)
                {
                    // پر کردن Label ها با اطلاعات انیمه
                    labelEnglishTitle.Text = $"English Title: {animeInfo.EnglishTitle}";
                    labelRomajiTitle.Text = $"Romaji Title: {animeInfo.RomajiTitle}";
                    labelNativeTitle.Text = $"Native Title: {animeInfo.NativeTitle}";
                    textBox2.Text = $"Description: {CleanHtml(animeInfo.Description)}";
                    labelEpisodes.Text = $"Episodes: {animeInfo.Episodes}";
                    labelScore.Text = $"Score: {animeInfo.Score}";
                    labelYear.Text = $"Year: {animeInfo.Year}";
                    labelStudio.Text = $"Studio: {animeInfo.Studio}";
                    labelGenres.Text = $"Genres: {string.Join(", ", animeInfo.Genres)}";
                    listBoxRelated.Items.Clear();
                    foreach (var related in animeInfo.RelatedAnime)
                    {
                        listBoxRelated.Items.Add(related);
                    }
                    // نمایش پوستر انیمه
                    pictureBox1.ImageLocation = animeInfo.PosterImage;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task<Anime> GetAnimeInfo(string animeName)
        {
            string query = @"
            query ($search: String) {
                Media (search: $search, type: ANIME) {
                    title {
                        romaji
                        english
                        native
                    }
                    description
                    coverImage {
                        large
                    }
                    episodes
                    averageScore
                    startDate {
                        year
                    }
                    studios {
                        edges {
                            node {
                                name
                            }
                        }
                    }
                    genres
                    relations {
                        edges {
                            node {
                                title {
                                    romaji
                                }
                            }
                        }
                    }
                }
            }";

            var variables = new { search = animeName };

            using (var client = new HttpClient())
            {
                var content = new StringContent(
                    JsonConvert.SerializeObject(new { query, variables }),
                    Encoding.UTF8,
                    "application/json");

                var response = await client.PostAsync("https://graphql.anilist.co", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);

                var relatedAnime = new List<string>();
                foreach (var relation in jsonResponse.data.Media.relations.edges)
                {
                    relatedAnime.Add((string)relation.node.title.romaji);
                }

                return new Anime
                {
                    EnglishTitle = jsonResponse.data.Media.title.english,
                    RomajiTitle = jsonResponse.data.Media.title.romaji,
                    NativeTitle = jsonResponse.data.Media.title.native,
                    Description = jsonResponse.data.Media.description,
                    PosterImage = jsonResponse.data.Media.coverImage.large,
                    Episodes = jsonResponse.data.Media.episodes.ToString(),
                    Score = jsonResponse.data.Media.averageScore.ToString(),
                    Year = jsonResponse.data.Media.startDate.year.ToString(),
                    Studio = jsonResponse.data.Media.studios.edges[0].node.name.ToString(),
                    Genres = jsonResponse.data.Media.genres.ToObject<List<string>>(),
                    RelatedAnime = relatedAnime
                };
            }
        }
        private string CleanHtml(string html)
        {
            string cleanText = Regex.Replace(html, "<br>", Environment.NewLine, RegexOptions.IgnoreCase);
            cleanText = Regex.Replace(cleanText, "<.*?>", string.Empty);
            return cleanText;
        }

        public class Anime
        {
            public string EnglishTitle { get; set; }
            public string RomajiTitle { get; set; }
            public string NativeTitle { get; set; }
            public string Description { get; set; }
            public string PosterImage { get; set; }
            public string Episodes { get; set; }
            public string Score { get; set; }
            public string Year { get; set; }
            public string Studio { get; set; }
            public List<string> Genres { get; set; }
            public List<string> RelatedAnime { get; set; }
        }

        private void listBoxRelated_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homebeta homee = new homebeta();
            homee.Show();
            this.Close();
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 kkk = new Form2();
            kkk.Show();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpi dd = new helpi();
            dd.ShowDialog();
        }

        private void socialMediaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("https://t.me/luluch_code", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void mostodonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("https://mas.to/@luluch_code", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
