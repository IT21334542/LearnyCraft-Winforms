namespace LearnyCraft
{
    partial class ClassesInterface
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            gridholderpanel = new Panel();
            ClassDataGRid = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            Coumn2 = new DataGridViewTextBoxColumn();
            UpdateCol = new DataGridViewButtonColumn();
            Deletecol = new DataGridViewButtonColumn();
            btnHolder = new Panel();
            AddClassbtn = new Button();
            gridholderpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClassDataGRid).BeginInit();
            btnHolder.SuspendLayout();
            SuspendLayout();
            // 
            // gridholderpanel
            // 
            gridholderpanel.Controls.Add(ClassDataGRid);
            gridholderpanel.Dock = DockStyle.Fill;
            gridholderpanel.Location = new Point(0, 0);
            gridholderpanel.Name = "gridholderpanel";
            gridholderpanel.Size = new Size(1251, 690);
            gridholderpanel.TabIndex = 0;
            // 
            // ClassDataGRid
            // 
            ClassDataGRid.AllowUserToAddRows = false;
            ClassDataGRid.AllowUserToDeleteRows = false;
            ClassDataGRid.AllowUserToResizeColumns = false;
            ClassDataGRid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ClassDataGRid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ClassDataGRid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClassDataGRid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassDataGRid.BackgroundColor = Color.FromArgb(192, 155, 216);
            ClassDataGRid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            ClassDataGRid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ClassDataGRid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassDataGRid.Columns.AddRange(new DataGridViewColumn[] { column1, Coumn2, UpdateCol, Deletecol });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ClassDataGRid.DefaultCellStyle = dataGridViewCellStyle7;
            ClassDataGRid.EnableHeadersVisualStyles = false;
            ClassDataGRid.GridColor = Color.FromArgb(192, 155, 216);
            ClassDataGRid.Location = new Point(121, 148);
            ClassDataGRid.MultiSelect = false;
            ClassDataGRid.Name = "ClassDataGRid";
            ClassDataGRid.ReadOnly = true;
            ClassDataGRid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            ClassDataGRid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            ClassDataGRid.RowHeadersVisible = false;
            ClassDataGRid.RowHeadersWidth = 51;
            ClassDataGRid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Padding = new Padding(2);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ClassDataGRid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            ClassDataGRid.RowTemplate.Height = 31;
            ClassDataGRid.RowTemplate.ReadOnly = true;
            ClassDataGRid.RowTemplate.Resizable = DataGridViewTriState.False;
            ClassDataGRid.Size = new Size(1027, 497);
            ClassDataGRid.TabIndex = 3;
            ClassDataGRid.CellClick += ClassDataGRid_CellClick;
            ClassDataGRid.CellContentClick += ClassDataGRid_CellContentClick;
            // 
            // column1
            // 
            column1.DataPropertyName = "ClassId";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            column1.DefaultCellStyle = dataGridViewCellStyle3;
            column1.HeaderText = "ClassId";
            column1.MinimumWidth = 6;
            column1.Name = "column1";
            column1.ReadOnly = true;
            // 
            // Coumn2
            // 
            Coumn2.DataPropertyName = "ClassName";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Coumn2.DefaultCellStyle = dataGridViewCellStyle4;
            Coumn2.HeaderText = "Class";
            Coumn2.MinimumWidth = 6;
            Coumn2.Name = "Coumn2";
            Coumn2.ReadOnly = true;
            Coumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // UpdateCol
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(235, 195, 219);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(37, 60, 120);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(235, 195, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(37, 60, 120);
            UpdateCol.DefaultCellStyle = dataGridViewCellStyle5;
            UpdateCol.FlatStyle = FlatStyle.Flat;
            UpdateCol.HeaderText = "";
            UpdateCol.MinimumWidth = 6;
            UpdateCol.Name = "UpdateCol";
            UpdateCol.ReadOnly = true;
            UpdateCol.Text = "Update";
            UpdateCol.UseColumnTextForButtonValue = true;
            // 
            // Deletecol
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            Deletecol.DefaultCellStyle = dataGridViewCellStyle6;
            Deletecol.FlatStyle = FlatStyle.Flat;
            Deletecol.HeaderText = "";
            Deletecol.MinimumWidth = 6;
            Deletecol.Name = "Deletecol";
            Deletecol.ReadOnly = true;
            Deletecol.Resizable = DataGridViewTriState.True;
            Deletecol.Text = "Delete";
            Deletecol.UseColumnTextForButtonValue = true;
            // 
            // btnHolder
            // 
            btnHolder.Controls.Add(AddClassbtn);
            btnHolder.Dock = DockStyle.Top;
            btnHolder.Location = new Point(0, 0);
            btnHolder.Name = "btnHolder";
            btnHolder.Size = new Size(1251, 125);
            btnHolder.TabIndex = 1;
            // 
            // AddClassbtn
            // 
            AddClassbtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddClassbtn.AutoSize = true;
            AddClassbtn.BackColor = Color.FromArgb(159, 132, 189);
            AddClassbtn.FlatStyle = FlatStyle.Flat;
            AddClassbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddClassbtn.ForeColor = Color.FromArgb(37, 60, 120);
            AddClassbtn.Location = new Point(1053, 43);
            AddClassbtn.Name = "AddClassbtn";
            AddClassbtn.RightToLeft = RightToLeft.No;
            AddClassbtn.Size = new Size(95, 40);
            AddClassbtn.TabIndex = 1;
            AddClassbtn.Text = "button1";
            AddClassbtn.TextAlign = ContentAlignment.MiddleRight;
            AddClassbtn.UseVisualStyleBackColor = false;
            AddClassbtn.Click += AddClassbtn_Click;
            // 
            // ClassesInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 195, 219);
            ClientSize = new Size(1251, 690);
            Controls.Add(btnHolder);
            Controls.Add(gridholderpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassesInterface";
            Text = "ClassesInterface";
            gridholderpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClassDataGRid).EndInit();
            btnHolder.ResumeLayout(false);
            btnHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gridholderpanel;
        private DataGridView ClassDataGRid;
        private Panel btnHolder;
        private Button AddClassbtn;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn Coumn2;
        private DataGridViewButtonColumn UpdateCol;
        private DataGridViewButtonColumn Deletecol;
    }
}