namespace LearnyCraft
{
    partial class AppStartInterface
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
            SidePanel = new Panel();
            MarksMenutxt = new Label();
            MarksDisplay = new PictureBox();
            ClassroomMenuTxt = new Label();
            ClassRoomPicturebox = new PictureBox();
            ModulesMenuTxt = new Label();
            StudentMenutxt = new Label();
            BooksPicturebox = new PictureBox();
            StudntsIconBox = new PictureBox();
            pictureBox1 = new PictureBox();
            TitlePanel = new Panel();
            pictureBox2 = new PictureBox();
            AppTitle = new Label();
            ChangingPanel = new Panel();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MarksDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassRoomPicturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BooksPicturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudntsIconBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(159, 132, 189);
            SidePanel.Controls.Add(MarksMenutxt);
            SidePanel.Controls.Add(MarksDisplay);
            SidePanel.Controls.Add(ClassroomMenuTxt);
            SidePanel.Controls.Add(ClassRoomPicturebox);
            SidePanel.Controls.Add(ModulesMenuTxt);
            SidePanel.Controls.Add(StudentMenutxt);
            SidePanel.Controls.Add(BooksPicturebox);
            SidePanel.Controls.Add(StudntsIconBox);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(89, 753);
            SidePanel.TabIndex = 0;
            // 
            // MarksMenutxt
            // 
            MarksMenutxt.AutoSize = true;
            MarksMenutxt.BackColor = Color.Transparent;
            MarksMenutxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MarksMenutxt.ForeColor = Color.White;
            MarksMenutxt.Location = new Point(6, 650);
            MarksMenutxt.Name = "MarksMenutxt";
            MarksMenutxt.Size = new Size(90, 33);
            MarksMenutxt.TabIndex = 10;
            MarksMenutxt.Text = "Students";
            MarksMenutxt.UseCompatibleTextRendering = true;
            // 
            // MarksDisplay
            // 
            MarksDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MarksDisplay.Image = FontResources.Ranks;
            MarksDisplay.Location = new Point(8, 574);
            MarksDisplay.Name = "MarksDisplay";
            MarksDisplay.Size = new Size(71, 62);
            MarksDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            MarksDisplay.TabIndex = 9;
            MarksDisplay.TabStop = false;
            MarksDisplay.Click += MarksDisplay_Click;
            // 
            // ClassroomMenuTxt
            // 
            ClassroomMenuTxt.AutoSize = true;
            ClassroomMenuTxt.BackColor = Color.Transparent;
            ClassroomMenuTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassroomMenuTxt.ForeColor = Color.White;
            ClassroomMenuTxt.Location = new Point(6, 515);
            ClassroomMenuTxt.Name = "ClassroomMenuTxt";
            ClassroomMenuTxt.Size = new Size(90, 33);
            ClassroomMenuTxt.TabIndex = 8;
            ClassroomMenuTxt.Text = "Students";
            ClassroomMenuTxt.UseCompatibleTextRendering = true;
            // 
            // ClassRoomPicturebox
            // 
            ClassRoomPicturebox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ClassRoomPicturebox.Image = FontResources.classroom;
            ClassRoomPicturebox.Location = new Point(8, 439);
            ClassRoomPicturebox.Name = "ClassRoomPicturebox";
            ClassRoomPicturebox.Size = new Size(71, 62);
            ClassRoomPicturebox.SizeMode = PictureBoxSizeMode.Zoom;
            ClassRoomPicturebox.TabIndex = 7;
            ClassRoomPicturebox.TabStop = false;
            ClassRoomPicturebox.Click += ClassRoomPicturebox_Click;
            // 
            // ModulesMenuTxt
            // 
            ModulesMenuTxt.AutoSize = true;
            ModulesMenuTxt.BackColor = Color.Transparent;
            ModulesMenuTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModulesMenuTxt.ForeColor = Color.White;
            ModulesMenuTxt.Location = new Point(6, 373);
            ModulesMenuTxt.Name = "ModulesMenuTxt";
            ModulesMenuTxt.Size = new Size(90, 33);
            ModulesMenuTxt.TabIndex = 6;
            ModulesMenuTxt.Text = "Students";
            ModulesMenuTxt.UseCompatibleTextRendering = true;
            // 
            // StudentMenutxt
            // 
            StudentMenutxt.AutoSize = true;
            StudentMenutxt.BackColor = Color.Transparent;
            StudentMenutxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentMenutxt.ForeColor = Color.White;
            StudentMenutxt.Location = new Point(5, 238);
            StudentMenutxt.Name = "StudentMenutxt";
            StudentMenutxt.Size = new Size(90, 33);
            StudentMenutxt.TabIndex = 5;
            StudentMenutxt.Text = "Students";
            StudentMenutxt.UseCompatibleTextRendering = true;
            StudentMenutxt.Click += label1_Click;
            // 
            // BooksPicturebox
            // 
            BooksPicturebox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BooksPicturebox.Image = FontResources.Books;
            BooksPicturebox.Location = new Point(9, 296);
            BooksPicturebox.Name = "BooksPicturebox";
            BooksPicturebox.Size = new Size(71, 62);
            BooksPicturebox.SizeMode = PictureBoxSizeMode.Zoom;
            BooksPicturebox.TabIndex = 4;
            BooksPicturebox.TabStop = false;
            BooksPicturebox.Click += BooksPicturebox_Click;
            // 
            // StudntsIconBox
            // 
            StudntsIconBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudntsIconBox.Image = FontResources.Student2;
            StudntsIconBox.Location = new Point(8, 163);
            StudntsIconBox.Name = "StudntsIconBox";
            StudntsIconBox.Size = new Size(71, 62);
            StudntsIconBox.SizeMode = PictureBoxSizeMode.Zoom;
            StudntsIconBox.TabIndex = 3;
            StudntsIconBox.TabStop = false;
            StudntsIconBox.Click += StudntsIconBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FontResources.Menu;
            pictureBox1.Location = new Point(8, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(pictureBox2);
            TitlePanel.Controls.Add(AppTitle);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(89, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1251, 63);
            TitlePanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(159, 132, 189);
            pictureBox2.Image = FontResources.closee;
            pictureBox2.Location = new Point(1199, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AppTitle
            // 
            AppTitle.AutoSize = true;
            AppTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppTitle.Location = new Point(6, 0);
            AppTitle.Name = "AppTitle";
            AppTitle.Size = new Size(204, 57);
            AppTitle.TabIndex = 3;
            AppTitle.Text = "LearnyCraft";
            AppTitle.UseCompatibleTextRendering = true;
            AppTitle.Click += AppTitle_Click;
            // 
            // ChangingPanel
            // 
            ChangingPanel.Dock = DockStyle.Fill;
            ChangingPanel.Location = new Point(89, 63);
            ChangingPanel.Name = "ChangingPanel";
            ChangingPanel.Size = new Size(1251, 690);
            ChangingPanel.TabIndex = 2;
            ChangingPanel.Paint += ChangingPanel_Paint;
            // 
            // AppStartInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 195, 219);
            ClientSize = new Size(1340, 753);
            Controls.Add(ChangingPanel);
            Controls.Add(TitlePanel);
            Controls.Add(SidePanel);
            ForeColor = Color.FromArgb(37, 60, 120);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppStartInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "m";
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MarksDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClassRoomPicturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BooksPicturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudntsIconBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel;
        private Panel TitlePanel;
        private Label AppTitle;
        private PictureBox pictureBox1;
        private PictureBox StudntsIconBox;
        private PictureBox pictureBox2;
        private Label StudentMenutxt;
        private PictureBox BooksPicturebox;
        private Label ModulesMenuTxt;
        private Label label1;
        private PictureBox ClassRoomPicturebox;
        private Label ClassroomMenuTxt;
        private Label MarksMenutxt;
        private PictureBox MarksDisplay;
        private Panel ChangingPanel;
    }
}