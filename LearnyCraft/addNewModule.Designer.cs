namespace LearnyCraft
{
    partial class addNewModule
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
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            titleNew = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 195, 219);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 540);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 132, 189);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(235, 195, 219);
            button1.Location = new Point(150, 434);
            button1.Name = "button1";
            button1.Size = new Size(245, 49);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(37, 60, 120);
            label2.Location = new Point(523, 303);
            label2.Name = "label2";
            label2.Size = new Size(62, 33);
            label2.TabIndex = 0;
            label2.Text = "label2";
            label2.UseCompatibleTextRendering = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(192, 155, 216);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(343, 344);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 36);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(37, 60, 120);
            label1.Location = new Point(31, 303);
            label1.Name = "label1";
            label1.Size = new Size(62, 33);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 155, 216);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(31, 344);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 36);
            textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(titleNew);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 268);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 155, 216);
            pictureBox2.Image = FontResources.closee;
            pictureBox2.Location = new Point(543, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // titleNew
            // 
            titleNew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleNew.AutoSize = true;
            titleNew.BackColor = Color.Transparent;
            titleNew.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleNew.ForeColor = Color.FromArgb(37, 60, 120);
            titleNew.Location = new Point(113, 172);
            titleNew.Name = "titleNew";
            titleNew.Size = new Size(184, 91);
            titleNew.TabIndex = 1;
            titleNew.Text = "label1";
            titleNew.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = FontResources.logo_refined;
            pictureBox1.Location = new Point(150, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // addNewModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 155, 216);
            ClientSize = new Size(615, 564);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addNewModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addNewModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label titleNew;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}