namespace MAS___MAX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            labelEnglishTitle = new Label();
            labelRomajiTitle = new Label();
            labelNativeTitle = new Label();
            labelEpisodes = new Label();
            labelScore = new Label();
            labelYear = new Label();
            labelStudio = new Label();
            labelGenres = new Label();
            listBoxRelated = new ListBox();
            textBox2 = new TextBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            quickAccessToolStripMenuItem = new ToolStripMenuItem();
            animeToolStripMenuItem = new ToolStripMenuItem();
            top10ToolStripMenuItem = new ToolStripMenuItem();
            moviesAndSeriesToolStripMenuItem = new ToolStripMenuItem();
            top10ToolStripMenuItem1 = new ToolStripMenuItem();
            moviesToolStripMenuItem = new ToolStripMenuItem();
            seriesToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            socialMediaToolStripMenuItem = new ToolStripMenuItem();
            telegramToolStripMenuItem1 = new ToolStripMenuItem();
            mostodonToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._000;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelEnglishTitle
            // 
            resources.ApplyResources(labelEnglishTitle, "labelEnglishTitle");
            labelEnglishTitle.Name = "labelEnglishTitle";
            // 
            // labelRomajiTitle
            // 
            resources.ApplyResources(labelRomajiTitle, "labelRomajiTitle");
            labelRomajiTitle.Name = "labelRomajiTitle";
            // 
            // labelNativeTitle
            // 
            resources.ApplyResources(labelNativeTitle, "labelNativeTitle");
            labelNativeTitle.Name = "labelNativeTitle";
            // 
            // labelEpisodes
            // 
            resources.ApplyResources(labelEpisodes, "labelEpisodes");
            labelEpisodes.Name = "labelEpisodes";
            // 
            // labelScore
            // 
            resources.ApplyResources(labelScore, "labelScore");
            labelScore.Name = "labelScore";
            // 
            // labelYear
            // 
            resources.ApplyResources(labelYear, "labelYear");
            labelYear.Name = "labelYear";
            // 
            // labelStudio
            // 
            resources.ApplyResources(labelStudio, "labelStudio");
            labelStudio.Name = "labelStudio";
            // 
            // labelGenres
            // 
            resources.ApplyResources(labelGenres, "labelGenres");
            labelGenres.Name = "labelGenres";
            // 
            // listBoxRelated
            // 
            listBoxRelated.Cursor = Cursors.Hand;
            resources.ApplyResources(listBoxRelated, "listBoxRelated");
            listBoxRelated.FormattingEnabled = true;
            listBoxRelated.Name = "listBoxRelated";
            listBoxRelated.SelectedIndexChanged += listBoxRelated_SelectedIndexChanged;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, quickAccessToolStripMenuItem, helpToolStripMenuItem, socialMediaToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Image = Properties.Resources._8454141;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            resources.ApplyResources(homeToolStripMenuItem, "homeToolStripMenuItem");
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // quickAccessToolStripMenuItem
            // 
            quickAccessToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { animeToolStripMenuItem, moviesAndSeriesToolStripMenuItem });
            quickAccessToolStripMenuItem.Image = Properties.Resources._3844613_200;
            quickAccessToolStripMenuItem.Name = "quickAccessToolStripMenuItem";
            resources.ApplyResources(quickAccessToolStripMenuItem, "quickAccessToolStripMenuItem");
            // 
            // animeToolStripMenuItem
            // 
            animeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { top10ToolStripMenuItem });
            animeToolStripMenuItem.Image = Properties.Resources._65ecacb6aa2281c70a6733b37c750bc7;
            animeToolStripMenuItem.Name = "animeToolStripMenuItem";
            resources.ApplyResources(animeToolStripMenuItem, "animeToolStripMenuItem");
            // 
            // top10ToolStripMenuItem
            // 
            top10ToolStripMenuItem.Image = Properties.Resources.list_icon_list_icon_white_11553444690gtyhxuarnj;
            top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            resources.ApplyResources(top10ToolStripMenuItem, "top10ToolStripMenuItem");
            top10ToolStripMenuItem.Click += top10ToolStripMenuItem_Click;
            // 
            // moviesAndSeriesToolStripMenuItem
            // 
            moviesAndSeriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { top10ToolStripMenuItem1, searchToolStripMenuItem });
            moviesAndSeriesToolStripMenuItem.Image = Properties.Resources.clapperboard_film_logo_icon_design_template_vector_isolated_png_236642;
            moviesAndSeriesToolStripMenuItem.Name = "moviesAndSeriesToolStripMenuItem";
            resources.ApplyResources(moviesAndSeriesToolStripMenuItem, "moviesAndSeriesToolStripMenuItem");
            // 
            // top10ToolStripMenuItem1
            // 
            top10ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { moviesToolStripMenuItem, seriesToolStripMenuItem });
            top10ToolStripMenuItem1.Image = Properties.Resources.list_icon_list_icon_white_11553444690gtyhxuarnj1;
            top10ToolStripMenuItem1.Name = "top10ToolStripMenuItem1";
            resources.ApplyResources(top10ToolStripMenuItem1, "top10ToolStripMenuItem1");
            // 
            // moviesToolStripMenuItem
            // 
            moviesToolStripMenuItem.Image = Properties.Resources.pngtree_film_logo_design_template_vector_isolated_illustration_png_image_1693431;
            moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            resources.ApplyResources(moviesToolStripMenuItem, "moviesToolStripMenuItem");
            // 
            // seriesToolStripMenuItem
            // 
            seriesToolStripMenuItem.Image = Properties.Resources.clapperboard_film_logo_icon_design_template_vector_isolated_png_2366421;
            seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            resources.ApplyResources(seriesToolStripMenuItem, "seriesToolStripMenuItem");
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = Properties.Resources.png_transparent_computer_icons_search_box_web_search_engine_symbol_symbol_miscellaneous_search_engine_optimization_logo;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            resources.ApplyResources(searchToolStripMenuItem, "searchToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Image = Properties.Resources.question_icon_15;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // socialMediaToolStripMenuItem
            // 
            socialMediaToolStripMenuItem.BackColor = Color.Gold;
            socialMediaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { telegramToolStripMenuItem1, mostodonToolStripMenuItem });
            socialMediaToolStripMenuItem.Image = Properties.Resources._9648957;
            socialMediaToolStripMenuItem.Name = "socialMediaToolStripMenuItem";
            resources.ApplyResources(socialMediaToolStripMenuItem, "socialMediaToolStripMenuItem");
            // 
            // telegramToolStripMenuItem1
            // 
            telegramToolStripMenuItem1.BackColor = SystemColors.Control;
            telegramToolStripMenuItem1.Image = Properties.Resources.telegram_logo_telegram_icon_transparent_free_png;
            telegramToolStripMenuItem1.Name = "telegramToolStripMenuItem1";
            resources.ApplyResources(telegramToolStripMenuItem1, "telegramToolStripMenuItem1");
            telegramToolStripMenuItem1.Click += socialMediaToolStripMenuItem1_Click;
            // 
            // mostodonToolStripMenuItem
            // 
            mostodonToolStripMenuItem.Image = Properties.Resources.Mastodon_logotype__simple__new_hue_svg;
            mostodonToolStripMenuItem.Name = "mostodonToolStripMenuItem";
            resources.ApplyResources(mostodonToolStripMenuItem, "mostodonToolStripMenuItem");
            mostodonToolStripMenuItem.Click += mostodonToolStripMenuItem_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.IndianRed;
            label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._441498764;
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(listBoxRelated);
            Controls.Add(labelGenres);
            Controls.Add(labelStudio);
            Controls.Add(labelYear);
            Controls.Add(labelScore);
            Controls.Add(labelEpisodes);
            Controls.Add(labelNativeTitle);
            Controls.Add(labelRomajiTitle);
            Controls.Add(labelEnglishTitle);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label labelEnglishTitle;
        private Label labelRomajiTitle;
        private Label labelNativeTitle;
        private Label labelEpisodes;
        private Label labelScore;
        private Label labelYear;
        private Label labelStudio;
        private Label labelGenres;
        private ListBox listBoxRelated;
        private TextBox textBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem quickAccessToolStripMenuItem;
        private ToolStripMenuItem animeToolStripMenuItem;
        private ToolStripMenuItem top10ToolStripMenuItem;
        private ToolStripMenuItem moviesAndSeriesToolStripMenuItem;
        private ToolStripMenuItem top10ToolStripMenuItem1;
        private ToolStripMenuItem moviesToolStripMenuItem;
        private ToolStripMenuItem seriesToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem socialMediaToolStripMenuItem;
        private ToolStripMenuItem telegramToolStripMenuItem1;
        private ToolStripMenuItem mostodonToolStripMenuItem;
    }
}
