namespace MAS___MAX
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            MASMax = new NotifyIcon(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(277, 60);
            button1.TabIndex = 0;
            button1.Text = "Anime";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(12, 78);
            button3.Name = "button3";
            button3.Size = new Size(277, 60);
            button3.TabIndex = 2;
            button3.Text = "Movie (Soon!)";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(12, 144);
            button4.Name = "button4";
            button4.Size = new Size(277, 60);
            button4.TabIndex = 3;
            button4.Text = "Help!";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MASMax
            // 
            MASMax.BalloonTipIcon = ToolTipIcon.Info;
            MASMax.Icon = (Icon)resources.GetObject("MASMax.Icon");
            MASMax.Text = "MAS Max";
            MASMax.Visible = true;
            MASMax.DoubleClick += MASMax_DoubleClick;
            MASMax.MouseDown += MASMax_MouseDown;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 216);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        public NotifyIcon MASMax;
    }
}