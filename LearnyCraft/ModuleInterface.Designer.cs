namespace LearnyCraft
{
    partial class ModuleInterface
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            button1 = new Button();
            Pinned = new Label();
            PinedMiddlePAnel = new Panel();
            Instruction = new Label();
            panel2 = new Panel();
            modname3 = new Label();
            pictureBox2 = new PictureBox();
            modcod3 = new Label();
            AllModules = new Label();
            panel1 = new Panel();
            modName2 = new Label();
            pictureBox1 = new PictureBox();
            ModCod2 = new Label();
            PinnedPanelone = new Panel();
            ModuleName = new Label();
            ModuleCode = new Label();
            PinedMod1 = new PictureBox();
            BottomGRidViewPAnel = new Panel();
            ModuleDAtaGRid = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            Coumn2 = new DataGridViewTextBoxColumn();
            Coulmn3 = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            PinedMiddlePAnel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PinnedPanelone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PinedMod1).BeginInit();
            BottomGRidViewPAnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ModuleDAtaGRid).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(button1);
            TopPanel.Controls.Add(Pinned);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1251, 73);
            TopPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 132, 189);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(940, 24);
            button1.Name = "button1";
            button1.Size = new Size(48, 43);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pinned
            // 
            Pinned.AutoSize = true;
            Pinned.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pinned.ForeColor = Color.FromArgb(37, 60, 120);
            Pinned.Location = new Point(230, 40);
            Pinned.Name = "Pinned";
            Pinned.Size = new Size(62, 33);
            Pinned.TabIndex = 0;
            Pinned.Text = "label1";
            Pinned.UseCompatibleTextRendering = true;
            // 
            // PinedMiddlePAnel
            // 
            PinedMiddlePAnel.Controls.Add(Instruction);
            PinedMiddlePAnel.Controls.Add(panel2);
            PinedMiddlePAnel.Controls.Add(AllModules);
            PinedMiddlePAnel.Controls.Add(panel1);
            PinedMiddlePAnel.Controls.Add(PinnedPanelone);
            PinedMiddlePAnel.Dock = DockStyle.Fill;
            PinedMiddlePAnel.Location = new Point(0, 73);
            PinedMiddlePAnel.Name = "PinedMiddlePAnel";
            PinedMiddlePAnel.Size = new Size(1251, 617);
            PinedMiddlePAnel.TabIndex = 1;
            PinedMiddlePAnel.Paint += PinedMiddlePAnel_Paint;
            // 
            // Instruction
            // 
            Instruction.AutoSize = true;
            Instruction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Instruction.ForeColor = Color.FromArgb(159, 132, 189);
            Instruction.Location = new Point(647, 286);
            Instruction.Name = "Instruction";
            Instruction.Size = new Size(62, 33);
            Instruction.TabIndex = 2;
            Instruction.Text = "label1";
            Instruction.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 155, 216);
            panel2.Controls.Add(modname3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(modcod3);
            panel2.Location = new Point(786, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 238);
            panel2.TabIndex = 2;
            // 
            // modname3
            // 
            modname3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            modname3.AutoSize = true;
            modname3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modname3.ForeColor = Color.White;
            modname3.Location = new Point(44, 195);
            modname3.Name = "modname3";
            modname3.Size = new Size(62, 33);
            modname3.TabIndex = 8;
            modname3.Text = "label1";
            modname3.UseCompatibleTextRendering = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = FontResources.Books;
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(202, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // modcod3
            // 
            modcod3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            modcod3.AutoSize = true;
            modcod3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modcod3.ForeColor = Color.FromArgb(37, 60, 120);
            modcod3.Location = new Point(44, 162);
            modcod3.Name = "modcod3";
            modcod3.Size = new Size(62, 33);
            modcod3.TabIndex = 7;
            modcod3.Text = "label1";
            modcod3.UseCompatibleTextRendering = true;
            // 
            // AllModules
            // 
            AllModules.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AllModules.AutoSize = true;
            AllModules.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllModules.ForeColor = Color.FromArgb(37, 60, 120);
            AllModules.Location = new Point(1003, 265);
            AllModules.Name = "AllModules";
            AllModules.Size = new Size(62, 33);
            AllModules.TabIndex = 1;
            AllModules.Text = "label1";
            AllModules.UseCompatibleTextRendering = true;
            AllModules.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 155, 216);
            panel1.Controls.Add(modName2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ModCod2);
            panel1.Location = new Point(507, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 238);
            panel1.TabIndex = 1;
            // 
            // modName2
            // 
            modName2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            modName2.AutoSize = true;
            modName2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modName2.ForeColor = Color.White;
            modName2.Location = new Point(44, 195);
            modName2.Name = "modName2";
            modName2.Size = new Size(62, 33);
            modName2.TabIndex = 5;
            modName2.Text = "label1";
            modName2.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FontResources.Books;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ModCod2
            // 
            ModCod2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ModCod2.AutoSize = true;
            ModCod2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModCod2.ForeColor = Color.FromArgb(37, 60, 120);
            ModCod2.Location = new Point(44, 162);
            ModCod2.Name = "ModCod2";
            ModCod2.Size = new Size(62, 33);
            ModCod2.TabIndex = 4;
            ModCod2.Text = "label1";
            ModCod2.UseCompatibleTextRendering = true;
            // 
            // PinnedPanelone
            // 
            PinnedPanelone.BackColor = Color.FromArgb(192, 155, 216);
            PinnedPanelone.Controls.Add(ModuleName);
            PinnedPanelone.Controls.Add(ModuleCode);
            PinnedPanelone.Controls.Add(PinedMod1);
            PinnedPanelone.Location = new Point(230, 16);
            PinnedPanelone.Name = "PinnedPanelone";
            PinnedPanelone.Size = new Size(202, 238);
            PinnedPanelone.TabIndex = 0;
            // 
            // ModuleName
            // 
            ModuleName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ModuleName.AutoSize = true;
            ModuleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModuleName.ForeColor = Color.White;
            ModuleName.Location = new Point(44, 195);
            ModuleName.Name = "ModuleName";
            ModuleName.Size = new Size(62, 33);
            ModuleName.TabIndex = 2;
            ModuleName.Text = "label1";
            ModuleName.UseCompatibleTextRendering = true;
            // 
            // ModuleCode
            // 
            ModuleCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ModuleCode.AutoSize = true;
            ModuleCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModuleCode.ForeColor = Color.FromArgb(37, 60, 120);
            ModuleCode.Location = new Point(44, 162);
            ModuleCode.Name = "ModuleCode";
            ModuleCode.Size = new Size(62, 33);
            ModuleCode.TabIndex = 1;
            ModuleCode.Text = "label1";
            ModuleCode.UseCompatibleTextRendering = true;
            // 
            // PinedMod1
            // 
            PinedMod1.Image = FontResources.Books;
            PinedMod1.Location = new Point(0, 3);
            PinedMod1.Name = "PinedMod1";
            PinedMod1.Size = new Size(202, 145);
            PinedMod1.SizeMode = PictureBoxSizeMode.Zoom;
            PinedMod1.TabIndex = 0;
            PinedMod1.TabStop = false;
            PinedMod1.Click += PinedMod1_Click;
            // 
            // BottomGRidViewPAnel
            // 
            BottomGRidViewPAnel.Controls.Add(ModuleDAtaGRid);
            BottomGRidViewPAnel.Dock = DockStyle.Bottom;
            BottomGRidViewPAnel.Location = new Point(0, 395);
            BottomGRidViewPAnel.Name = "BottomGRidViewPAnel";
            BottomGRidViewPAnel.Size = new Size(1251, 295);
            BottomGRidViewPAnel.TabIndex = 2;
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
            ModuleDAtaGRid.Columns.AddRange(new DataGridViewColumn[] { column1, Coumn2, Coulmn3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            ModuleDAtaGRid.DefaultCellStyle = dataGridViewCellStyle6;
            ModuleDAtaGRid.EnableHeadersVisualStyles = false;
            ModuleDAtaGRid.GridColor = Color.FromArgb(235, 195, 219);
            ModuleDAtaGRid.Location = new Point(230, 15);
            ModuleDAtaGRid.MultiSelect = false;
            ModuleDAtaGRid.Name = "ModuleDAtaGRid";
            ModuleDAtaGRid.ReadOnly = true;
            ModuleDAtaGRid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ModuleDAtaGRid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ModuleDAtaGRid.RowHeadersVisible = false;
            ModuleDAtaGRid.RowHeadersWidth = 51;
            ModuleDAtaGRid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            ModuleDAtaGRid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            ModuleDAtaGRid.RowTemplate.ReadOnly = true;
            ModuleDAtaGRid.RowTemplate.Resizable = DataGridViewTriState.False;
            ModuleDAtaGRid.Size = new Size(758, 268);
            ModuleDAtaGRid.TabIndex = 3;
            ModuleDAtaGRid.CellDoubleClick += ModuleDAtaGRid_CellDoubleClick;
            // 
            // column1
            // 
            column1.DataPropertyName = "ModuleName";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            column1.DefaultCellStyle = dataGridViewCellStyle3;
            column1.HeaderText = " Module Name";
            column1.MinimumWidth = 6;
            column1.Name = "column1";
            column1.ReadOnly = true;
            // 
            // Coumn2
            // 
            Coumn2.DataPropertyName = "ModuleCode";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Coumn2.DefaultCellStyle = dataGridViewCellStyle4;
            Coumn2.HeaderText = "Module Code";
            Coumn2.MinimumWidth = 6;
            Coumn2.Name = "Coumn2";
            Coumn2.ReadOnly = true;
            // 
            // Coulmn3
            // 
            Coulmn3.DataPropertyName = "GardeRelated";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(159, 132, 189);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            Coulmn3.DefaultCellStyle = dataGridViewCellStyle5;
            Coulmn3.HeaderText = "Grade Related";
            Coulmn3.MinimumWidth = 6;
            Coulmn3.Name = "Coulmn3";
            Coulmn3.ReadOnly = true;
            // 
            // ModuleInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 195, 219);
            ClientSize = new Size(1251, 690);
            Controls.Add(BottomGRidViewPAnel);
            Controls.Add(PinedMiddlePAnel);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModuleInterface";
            Text = "ModuleInterface";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            PinedMiddlePAnel.ResumeLayout(false);
            PinedMiddlePAnel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PinnedPanelone.ResumeLayout(false);
            PinnedPanelone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PinedMod1).EndInit();
            BottomGRidViewPAnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ModuleDAtaGRid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel PinedMiddlePAnel;
        private Panel BottomGRidViewPAnel;
        private Label Pinned;
        private Panel panel2;
        private Panel panel1;
        private Panel PinnedPanelone;
        private Label Instruction;
        private Label AllModules;
        private DataGridView ModuleDAtaGRid;
        private Label ModuleCode;
        private PictureBox PinedMod1;
        private Label ModuleName;
        private Label modName2;
        private PictureBox pictureBox1;
        private Label ModCod2;
        private Label modname3;
        private PictureBox pictureBox2;
        private Label modcod3;
        private Button button1;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn Coumn2;
        private DataGridViewTextBoxColumn Coulmn3;
    }
}