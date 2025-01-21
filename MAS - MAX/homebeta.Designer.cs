namespace MAS___MAX
{
    partial class homebeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homebeta));
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(12, 148);
            button4.Name = "button4";
            button4.Size = new Size(277, 60);
            button4.TabIndex = 6;
            button4.Text = "Help!";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(12, 82);
            button3.Name = "button3";
            button3.Size = new Size(277, 60);
            button3.TabIndex = 5;
            button3.Text = "Movie (Soon!)";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(12, 16);
            button1.Name = "button1";
            button1.Size = new Size(277, 60);
            button1.TabIndex = 4;
            button1.Text = "Anime";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // homebeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 220);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "homebeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button1;
    }
}