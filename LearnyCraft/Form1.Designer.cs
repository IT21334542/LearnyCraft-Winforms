namespace LearnyCraft
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
            components = new System.ComponentModel.Container();
            AppNameSplash = new Label();
            LogoPicture = new PictureBox();
            SubText = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            CircularPb = new CircularProgressBar_NET5.CircularProgressBar();
            Splashtimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            SuspendLayout();
            // 
            // AppNameSplash
            // 
            AppNameSplash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AppNameSplash.AutoSize = true;
            AppNameSplash.Font = new Font("Pavelt", 79.7999954F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppNameSplash.ForeColor = Color.FromArgb(37, 60, 120);
            AppNameSplash.Location = new Point(316, 300);
            AppNameSplash.Name = "AppNameSplash";
            AppNameSplash.Size = new Size(679, 192);
            AppNameSplash.TabIndex = 0;
            AppNameSplash.Text = "label1";
            AppNameSplash.TextAlign = ContentAlignment.MiddleCenter;
            AppNameSplash.UseCompatibleTextRendering = true;
            AppNameSplash.Click += AppNameSplash_Click;
            // 
            // LogoPicture
            // 
            LogoPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogoPicture.Image = FontResources.logo_refined;
            LogoPicture.Location = new Point(472, 63);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(452, 298);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 2;
            LogoPicture.TabStop = false;
            // 
            // SubText
            // 
            SubText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubText.AutoSize = true;
            SubText.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubText.ForeColor = Color.FromArgb(37, 60, 120);
            SubText.Location = new Point(221, 520);
            SubText.Name = "SubText";
            SubText.Size = new Size(151, 62);
            SubText.TabIndex = 3;
            SubText.Text = "label1";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // CircularPb
            // 
            CircularPb.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            CircularPb.AnimationSpeed = 500;
            CircularPb.BackColor = Color.Transparent;
            CircularPb.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CircularPb.ForeColor = Color.FromArgb(37, 60, 120);
            CircularPb.InnerColor = Color.Transparent;
            CircularPb.InnerMargin = 2;
            CircularPb.InnerWidth = -1;
            CircularPb.Location = new Point(586, 584);
            CircularPb.MarqueeAnimationSpeed = 2000;
            CircularPb.Name = "CircularPb";
            CircularPb.OuterColor = Color.FromArgb(192, 155, 216);
            CircularPb.OuterMargin = -25;
            CircularPb.OuterWidth = 26;
            CircularPb.ProgressColor = Color.FromArgb(159, 132, 189);
            CircularPb.ProgressWidth = 18;
            CircularPb.SecondaryFont = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CircularPb.Size = new Size(138, 137);
            CircularPb.StartAngle = 270;
            CircularPb.Style = ProgressBarStyle.Continuous;
            CircularPb.SubscriptColor = Color.FromArgb(166, 166, 166);
            CircularPb.SubscriptMargin = new Padding(10, -35, 0, 0);
            CircularPb.SubscriptText = "";
            CircularPb.SuperscriptColor = Color.FromArgb(166, 166, 166);
            CircularPb.SuperscriptMargin = new Padding(10, 35, 0, 0);
            CircularPb.SuperscriptText = "";
            CircularPb.TabIndex = 4;
            CircularPb.TextMargin = new Padding(8, 8, 10, 10);
            CircularPb.Value = 68;
            // 
            // Splashtimer
            // 
            Splashtimer.Enabled = true;
            Splashtimer.Tick += Splashtimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 195, 219);
            ClientSize = new Size(1340, 753);
            Controls.Add(CircularPb);
            Controls.Add(SubText);
            Controls.Add(LogoPicture);
            Controls.Add(AppNameSplash);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AppNameSplash;
        private PictureBox LogoPicture;
        private Label SubText;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        public CircularProgressBar_NET5.CircularProgressBar CircularPb;
        private System.Windows.Forms.Timer Splashtimer;
    }
}
