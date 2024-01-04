namespace LearnyCraft
{
    partial class MarksAssiging
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ModuleDAtaGRid = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            Coumn2 = new DataGridViewTextBoxColumn();
            Coulmn3 = new DataGridViewTextBoxColumn();
            AverageMarks = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ModuleDAtaGRid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1233, 111);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 155, 216);
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 43);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(37, 60, 120);
            label2.Location = new Point(673, 68);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(235, 195, 219);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(37, 60, 120);
            label1.Location = new Point(1128, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(ModuleDAtaGRid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(1233, 532);
            panel2.TabIndex = 1;
            // 
            // ModuleDAtaGRid
            // 
            ModuleDAtaGRid.AllowUserToAddRows = false;
            ModuleDAtaGRid.AllowUserToDeleteRows = false;
            ModuleDAtaGRid.AllowUserToResizeColumns = false;
            ModuleDAtaGRid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ModuleDAtaGRid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ModuleDAtaGRid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ModuleDAtaGRid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ModuleDAtaGRid.BackgroundColor = Color.FromArgb(192, 155, 216);
            ModuleDAtaGRid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            ModuleDAtaGRid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ModuleDAtaGRid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModuleDAtaGRid.Columns.AddRange(new DataGridViewColumn[] { column1, Coumn2, Coulmn3, AverageMarks, Column2 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            ModuleDAtaGRid.DefaultCellStyle = dataGridViewCellStyle8;
            ModuleDAtaGRid.EnableHeadersVisualStyles = false;
            ModuleDAtaGRid.GridColor = Color.FromArgb(235, 195, 219);
            ModuleDAtaGRid.Location = new Point(26, 47);
            ModuleDAtaGRid.MultiSelect = false;
            ModuleDAtaGRid.Name = "ModuleDAtaGRid";
            ModuleDAtaGRid.ReadOnly = true;
            ModuleDAtaGRid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ModuleDAtaGRid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            ModuleDAtaGRid.RowHeadersVisible = false;
            ModuleDAtaGRid.RowHeadersWidth = 51;
            ModuleDAtaGRid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            ModuleDAtaGRid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            ModuleDAtaGRid.RowTemplate.ReadOnly = true;
            ModuleDAtaGRid.RowTemplate.Resizable = DataGridViewTriState.False;
            ModuleDAtaGRid.Size = new Size(1178, 435);
            ModuleDAtaGRid.TabIndex = 4;
            ModuleDAtaGRid.CellDoubleClick += ModuleDAtaGRid_CellDoubleClick;
            // 
            // column1
            // 
            column1.DataPropertyName = "Studentid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            column1.DefaultCellStyle = dataGridViewCellStyle3;
            column1.HeaderText = " Studentid";
            column1.MinimumWidth = 6;
            column1.Name = "column1";
            column1.ReadOnly = true;
            // 
            // Coumn2
            // 
            Coumn2.DataPropertyName = "StudentName";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Coumn2.DefaultCellStyle = dataGridViewCellStyle4;
            Coumn2.HeaderText = "StudentName";
            Coumn2.MinimumWidth = 6;
            Coumn2.Name = "Coumn2";
            Coumn2.ReadOnly = true;
            // 
            // Coulmn3
            // 
            Coulmn3.DataPropertyName = "Total";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            Coulmn3.DefaultCellStyle = dataGridViewCellStyle5;
            Coulmn3.HeaderText = "Total Marks";
            Coulmn3.MinimumWidth = 6;
            Coulmn3.Name = "Coulmn3";
            Coulmn3.ReadOnly = true;
            // 
            // AverageMarks
            // 
            AverageMarks.DataPropertyName = "Average";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            AverageMarks.DefaultCellStyle = dataGridViewCellStyle6;
            AverageMarks.HeaderText = "AverageMarks";
            AverageMarks.MinimumWidth = 6;
            AverageMarks.Name = "AverageMarks";
            AverageMarks.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            Column2.DefaultCellStyle = dataGridViewCellStyle7;
            Column2.FlatStyle = FlatStyle.Flat;
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Text = "Delete Total";
            Column2.UseColumnTextForButtonValue = true;
            // 
            // MarksAssiging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 195, 219);
            ClientSize = new Size(1233, 643);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MarksAssiging";
            Text = "MarksAssiging";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ModuleDAtaGRid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView ModuleDAtaGRid;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn Coumn2;
        private DataGridViewTextBoxColumn Coulmn3;
        private DataGridViewTextBoxColumn AverageMarks;
        private DataGridViewButtonColumn Column2;
    }
}