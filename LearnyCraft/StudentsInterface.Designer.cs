namespace LearnyCraft
{
    partial class StudentsInterface
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            buttonContainer = new Panel();
            AddStudentButton = new Button();
            DataviewPanel = new Panel();
            StudentDataGrid = new DataGridView();
            StudentNameColumn = new DataGridViewTextBoxColumn();
            StudentIdColumn = new DataGridViewTextBoxColumn();
            StudentAgeCol = new DataGridViewTextBoxColumn();
            StudentContactcol = new DataGridViewTextBoxColumn();
            StudentClasscol = new DataGridViewTextBoxColumn();
            UpdateColStudent = new DataGridViewButtonColumn();
            DeleteColStud = new DataGridViewButtonColumn();
            buttonContainer.SuspendLayout();
            DataviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDataGrid).BeginInit();
            SuspendLayout();
            // 
            // buttonContainer
            // 
            buttonContainer.Controls.Add(AddStudentButton);
            buttonContainer.Dock = DockStyle.Top;
            buttonContainer.Location = new Point(0, 0);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Size = new Size(1251, 101);
            buttonContainer.TabIndex = 0;
            buttonContainer.Paint += buttonContainer_Paint;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddStudentButton.AutoSize = true;
            AddStudentButton.BackColor = Color.FromArgb(159, 132, 189);
            AddStudentButton.FlatStyle = FlatStyle.Flat;
            AddStudentButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddStudentButton.ForeColor = Color.FromArgb(37, 60, 120);
            AddStudentButton.Location = new Point(1006, 37);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.RightToLeft = RightToLeft.No;
            AddStudentButton.Size = new Size(95, 40);
            AddStudentButton.TabIndex = 0;
            AddStudentButton.Text = "button1";
            AddStudentButton.TextAlign = ContentAlignment.MiddleRight;
            AddStudentButton.UseVisualStyleBackColor = false;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // DataviewPanel
            // 
            DataviewPanel.Controls.Add(StudentDataGrid);
            DataviewPanel.Dock = DockStyle.Fill;
            DataviewPanel.Location = new Point(0, 101);
            DataviewPanel.Name = "DataviewPanel";
            DataviewPanel.Size = new Size(1251, 589);
            DataviewPanel.TabIndex = 1;
            // 
            // StudentDataGrid
            // 
            StudentDataGrid.AllowUserToAddRows = false;
            StudentDataGrid.AllowUserToDeleteRows = false;
            StudentDataGrid.AllowUserToResizeColumns = false;
            StudentDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            StudentDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            StudentDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentDataGrid.BackgroundColor = Color.FromArgb(192, 155, 216);
            StudentDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            StudentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StudentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataGrid.Columns.AddRange(new DataGridViewColumn[] { StudentNameColumn, StudentIdColumn, StudentAgeCol, StudentContactcol, StudentClasscol, UpdateColStudent, DeleteColStud });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            StudentDataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            StudentDataGrid.EnableHeadersVisualStyles = false;
            StudentDataGrid.GridColor = Color.FromArgb(235, 195, 219);
            StudentDataGrid.Location = new Point(69, 38);
            StudentDataGrid.MultiSelect = false;
            StudentDataGrid.Name = "StudentDataGrid";
            StudentDataGrid.ReadOnly = true;
            StudentDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            StudentDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            StudentDataGrid.RowHeadersVisible = false;
            StudentDataGrid.RowHeadersWidth = 51;
            StudentDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            StudentDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            StudentDataGrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StudentDataGrid.RowTemplate.ReadOnly = true;
            StudentDataGrid.Size = new Size(1111, 476);
            StudentDataGrid.TabIndex = 0;
            StudentDataGrid.CellClick += StudentDataGrid_CellClick;
            // 
            // StudentNameColumn
            // 
            StudentNameColumn.DataPropertyName = "StudentName";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            StudentNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            StudentNameColumn.HeaderText = "StudentName";
            StudentNameColumn.MinimumWidth = 6;
            StudentNameColumn.Name = "StudentNameColumn";
            StudentNameColumn.ReadOnly = true;
            StudentNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // StudentIdColumn
            // 
            StudentIdColumn.DataPropertyName = "StudentId";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            StudentIdColumn.DefaultCellStyle = dataGridViewCellStyle4;
            StudentIdColumn.HeaderText = "StudentId";
            StudentIdColumn.MinimumWidth = 6;
            StudentIdColumn.Name = "StudentIdColumn";
            StudentIdColumn.ReadOnly = true;
            StudentIdColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // StudentAgeCol
            // 
            StudentAgeCol.DataPropertyName = "StudentAge";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            StudentAgeCol.DefaultCellStyle = dataGridViewCellStyle5;
            StudentAgeCol.HeaderText = "StudentAge";
            StudentAgeCol.MinimumWidth = 6;
            StudentAgeCol.Name = "StudentAgeCol";
            StudentAgeCol.ReadOnly = true;
            StudentAgeCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // StudentContactcol
            // 
            StudentContactcol.DataPropertyName = "ContactNumber";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            StudentContactcol.DefaultCellStyle = dataGridViewCellStyle6;
            StudentContactcol.HeaderText = "ContactNumber";
            StudentContactcol.MinimumWidth = 6;
            StudentContactcol.Name = "StudentContactcol";
            StudentContactcol.ReadOnly = true;
            StudentContactcol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // StudentClasscol
            // 
            StudentClasscol.DataPropertyName = "StudentClass";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            StudentClasscol.DefaultCellStyle = dataGridViewCellStyle7;
            StudentClasscol.HeaderText = "Class(s)";
            StudentClasscol.MinimumWidth = 6;
            StudentClasscol.Name = "StudentClasscol";
            StudentClasscol.ReadOnly = true;
            StudentClasscol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // UpdateColStudent
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(235, 195, 219);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(37, 60, 120);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(235, 195, 219);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(37, 60, 120);
            UpdateColStudent.DefaultCellStyle = dataGridViewCellStyle8;
            UpdateColStudent.FlatStyle = FlatStyle.Flat;
            UpdateColStudent.HeaderText = "";
            UpdateColStudent.MinimumWidth = 6;
            UpdateColStudent.Name = "UpdateColStudent";
            UpdateColStudent.ReadOnly = true;
            UpdateColStudent.Text = "Update";
            UpdateColStudent.UseColumnTextForButtonValue = true;
            // 
            // DeleteColStud
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            DeleteColStud.DefaultCellStyle = dataGridViewCellStyle9;
            DeleteColStud.FlatStyle = FlatStyle.Flat;
            DeleteColStud.HeaderText = "";
            DeleteColStud.MinimumWidth = 6;
            DeleteColStud.Name = "DeleteColStud";
            DeleteColStud.ReadOnly = true;
            DeleteColStud.Text = "Delete";
            DeleteColStud.UseColumnTextForButtonValue = true;
            // 
            // StudentsInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 195, 219);
            ClientSize = new Size(1251, 690);
            Controls.Add(DataviewPanel);
            Controls.Add(buttonContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsInterface";
            Text = "StudentsInterface";
            buttonContainer.ResumeLayout(false);
            buttonContainer.PerformLayout();
            DataviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonContainer;
        private Button AddStudentButton;
        private Panel DataviewPanel;
        private DataGridView StudentDataGrid;
        private DataGridViewTextBoxColumn StudentNameColumn;
        private DataGridViewTextBoxColumn StudentIdColumn;
        private DataGridViewTextBoxColumn StudentAgeCol;
        private DataGridViewTextBoxColumn StudentContactcol;
        private DataGridViewTextBoxColumn StudentClasscol;
        private DataGridViewButtonColumn UpdateColStudent;
        private DataGridViewButtonColumn DeleteColStud;
    }
}