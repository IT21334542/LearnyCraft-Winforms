namespace LearnyCraft
{
    partial class AddnewClass
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
            btnCls = new PictureBox();
            titleer = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCls).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCls);
            panel1.Controls.Add(titleer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 70);
            panel1.TabIndex = 0;
            // 
            // btnCls
            // 
            btnCls.BackColor = Color.FromArgb(159, 132, 189);
            btnCls.BackgroundImageLayout = ImageLayout.Center;
            btnCls.Image = FontResources.closee;
            btnCls.Location = new Point(384, 15);
            btnCls.Name = "btnCls";
            btnCls.Size = new Size(30, 32);
            btnCls.SizeMode = PictureBoxSizeMode.Zoom;
            btnCls.TabIndex = 1;
            btnCls.TabStop = false;
            btnCls.Click += btnCls_Click;
            // 
            // titleer
            // 
            titleer.AutoSize = true;
            titleer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleer.ForeColor = Color.FromArgb(37, 60, 120);
            titleer.Location = new Point(12, 15);
            titleer.Name = "titleer";
            titleer.Size = new Size(92, 47);
            titleer.TabIndex = 0;
            titleer.Text = "label1";
            titleer.TextAlign = ContentAlignment.TopCenter;
            titleer.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 380);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 155, 216);
            label2.Location = new Point(119, 335);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = FontResources.logo_refined;
            pictureBox1.Location = new Point(54, 328);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(159, 132, 189);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(119, 196);
            button1.Name = "button1";
            button1.Size = new Size(178, 42);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(159, 132, 189);
            label1.Location = new Point(318, 56);
            label1.Name = "label1";
            label1.Size = new Size(71, 37);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 155, 216);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(54, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 40);
            textBox1.TabIndex = 0;
            // 
            // AddnewClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 195, 219);
            ClientSize = new Size(426, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddnewClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddnewClass";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCls).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titleer;
        private PictureBox btnCls;
        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}