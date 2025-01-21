namespace MAS___MAX
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            quickAccessToolStripMenuItem = new ToolStripMenuItem();
            animeToolStripMenuItem = new ToolStripMenuItem();
            AnimesearchToolStripMenuItem = new ToolStripMenuItem();
            moviesAndSeriesToolStripMenuItem = new ToolStripMenuItem();
            top10ToolStripMenuItem1 = new ToolStripMenuItem();
            moviesToolStripMenuItem = new ToolStripMenuItem();
            seriesToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            socialMediaToolStripMenuItem = new ToolStripMenuItem();
            telegramToolStripMenuItem1 = new ToolStripMenuItem();
            mostodonToolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            refreshButton = new Button();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, quickAccessToolStripMenuItem, helpToolStripMenuItem, socialMediaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(811, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menu";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Image = Properties.Resources._8454141;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + H";
            homeToolStripMenuItem.Size = new Size(68, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // quickAccessToolStripMenuItem
            // 
            quickAccessToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { animeToolStripMenuItem, moviesAndSeriesToolStripMenuItem });
            quickAccessToolStripMenuItem.Image = Properties.Resources._3844613_200;
            quickAccessToolStripMenuItem.Name = "quickAccessToolStripMenuItem";
            quickAccessToolStripMenuItem.Size = new Size(103, 20);
            quickAccessToolStripMenuItem.Text = "Quick access";
            // 
            // animeToolStripMenuItem
            // 
            animeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AnimesearchToolStripMenuItem });
            animeToolStripMenuItem.Image = Properties.Resources._65ecacb6aa2281c70a6733b37c750bc7;
            animeToolStripMenuItem.Name = "animeToolStripMenuItem";
            animeToolStripMenuItem.ShortcutKeyDisplayString = "";
            animeToolStripMenuItem.Size = new Size(167, 22);
            animeToolStripMenuItem.Text = "Anime";
            // 
            // AnimesearchToolStripMenuItem
            // 
            AnimesearchToolStripMenuItem.Image = Properties.Resources.png_transparent_computer_icons_search_box_web_search_engine_symbol_symbol_miscellaneous_search_engine_optimization_logo;
            AnimesearchToolStripMenuItem.Name = "AnimesearchToolStripMenuItem";
            AnimesearchToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + AS";
            AnimesearchToolStripMenuItem.Size = new Size(200, 22);
            AnimesearchToolStripMenuItem.Text = "Anime search";
            AnimesearchToolStripMenuItem.Click += AnimesearchToolStripMenuItem_Click;
            // 
            // moviesAndSeriesToolStripMenuItem
            // 
            moviesAndSeriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { top10ToolStripMenuItem1, searchToolStripMenuItem });
            moviesAndSeriesToolStripMenuItem.Image = Properties.Resources.clapperboard_film_logo_icon_design_template_vector_isolated_png_236642;
            moviesAndSeriesToolStripMenuItem.Name = "moviesAndSeriesToolStripMenuItem";
            moviesAndSeriesToolStripMenuItem.Size = new Size(167, 22);
            moviesAndSeriesToolStripMenuItem.Text = "Movies and series";
            // 
            // top10ToolStripMenuItem1
            // 
            top10ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { moviesToolStripMenuItem, seriesToolStripMenuItem });
            top10ToolStripMenuItem1.Image = Properties.Resources.list_icon_list_icon_white_11553444690gtyhxuarnj1;
            top10ToolStripMenuItem1.Name = "top10ToolStripMenuItem1";
            top10ToolStripMenuItem1.Size = new Size(166, 22);
            top10ToolStripMenuItem1.Text = "Top 10";
            // 
            // moviesToolStripMenuItem
            // 
            moviesToolStripMenuItem.Image = Properties.Resources.pngtree_film_logo_design_template_vector_isolated_illustration_png_image_1693431;
            moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            moviesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + MT";
            moviesToolStripMenuItem.Size = new Size(169, 22);
            moviesToolStripMenuItem.Text = "Movies";
            // 
            // seriesToolStripMenuItem
            // 
            seriesToolStripMenuItem.Image = Properties.Resources.clapperboard_film_logo_icon_design_template_vector_isolated_png_2366421;
            seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            seriesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + ST";
            seriesToolStripMenuItem.Size = new Size(169, 22);
            seriesToolStripMenuItem.Text = "Series";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = Properties.Resources.png_transparent_computer_icons_search_box_web_search_engine_symbol_symbol_miscellaneous_search_engine_optimization_logo;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + MS";
            searchToolStripMenuItem.Size = new Size(166, 22);
            searchToolStripMenuItem.Text = "Search";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Image = Properties.Resources.question_icon_15;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + I";
            helpToolStripMenuItem.Size = new Size(60, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // socialMediaToolStripMenuItem
            // 
            socialMediaToolStripMenuItem.BackColor = Color.Gold;
            socialMediaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { telegramToolStripMenuItem1, mostodonToolStripMenuItem });
            socialMediaToolStripMenuItem.Image = Properties.Resources._9648957;
            socialMediaToolStripMenuItem.Name = "socialMediaToolStripMenuItem";
            socialMediaToolStripMenuItem.Size = new Size(102, 20);
            socialMediaToolStripMenuItem.Text = "Social media";
            // 
            // telegramToolStripMenuItem1
            // 
            telegramToolStripMenuItem1.BackColor = SystemColors.Control;
            telegramToolStripMenuItem1.Image = Properties.Resources.telegram_logo_telegram_icon_transparent_free_png;
            telegramToolStripMenuItem1.Name = "telegramToolStripMenuItem1";
            telegramToolStripMenuItem1.Size = new Size(180, 22);
            telegramToolStripMenuItem1.Text = "Telegram";
            telegramToolStripMenuItem1.Click += telegramToolStripMenuItem1_Click;
            // 
            // mostodonToolStripMenuItem
            // 
            mostodonToolStripMenuItem.Image = Properties.Resources.Mastodon_logotype__simple__new_hue_svg;
            mostodonToolStripMenuItem.Name = "mostodonToolStripMenuItem";
            mostodonToolStripMenuItem.Size = new Size(180, 22);
            mostodonToolStripMenuItem.Text = "Mastodon";
            mostodonToolStripMenuItem.Click += mostodonToolStripMenuItem_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.ActiveCaptionText;
            dataGridView.Location = new Point(12, 196);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Size = new Size(787, 242);
            dataGridView.StandardTab = true;
            dataGridView.TabIndex = 100;
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            refreshButton.Location = new Point(12, 133);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(787, 36);
            refreshButton.TabIndex = 17;
            refreshButton.Text = "Refresh ";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.IndianRed;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(194, 85);
            label1.Name = "label1";
            label1.Size = new Size(412, 19);
            label1.TabIndex = 101;
            label1.Text = "Note: If you are from Iran, be sure to use vpn to use this section.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(25, 57);
            label2.Name = "label2";
            label2.Size = new Size(764, 30);
            label2.TabIndex = 101;
            label2.Text = "If the information is not displayed automatically, click the refresh button once.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._441498764;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(refreshButton);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Top 10 | Anime";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem quickAccessToolStripMenuItem;
        private ToolStripMenuItem animeToolStripMenuItem;
        private ToolStripMenuItem AnimesearchToolStripMenuItem;
        private ToolStripMenuItem moviesAndSeriesToolStripMenuItem;
        private ToolStripMenuItem top10ToolStripMenuItem1;
        private ToolStripMenuItem moviesToolStripMenuItem;
        private ToolStripMenuItem seriesToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private DataGridView dataGridView;
        private Button refreshButton;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem socialMediaToolStripMenuItem;
        private ToolStripMenuItem telegramToolStripMenuItem1;
        private ToolStripMenuItem mostodonToolStripMenuItem;
    }
}