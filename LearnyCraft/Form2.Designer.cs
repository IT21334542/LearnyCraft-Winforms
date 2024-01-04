namespace LearnyCraft
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
            panel1 = new Panel();
            Title = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            Instruction = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Title);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 167);
            panel1.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(37, 60, 120);
            Title.Location = new Point(199, 93);
            Title.Name = "Title";
            Title.Size = new Size(151, 62);
            Title.TabIndex = 2;
            Title.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = FontResources.logo_refined;
            pictureBox2.Location = new Point(39, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(159, 132, 189);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = FontResources.closee;
            pictureBox1.Location = new Point(651, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 155, 216);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(37, 60, 120);
            textBox1.Location = new Point(56, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(575, 40);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Instruction
            // 
            Instruction.AutoSize = true;
            Instruction.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Instruction.ForeColor = Color.FromArgb(37, 60, 120);
            Instruction.Location = new Point(462, 209);
            Instruction.Name = "Instruction";
            Instruction.Size = new Size(76, 31);
            Instruction.TabIndex = 2;
            Instruction.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(159, 132, 189);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(416, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(215, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 195, 219);
            ClientSize = new Size(701, 450);
            Controls.Add(btnSave);
            Controls.Add(Instruction);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label Title;
        private TextBox textBox1;
        private Label Instruction;
        private Button btnSave;
    }
}