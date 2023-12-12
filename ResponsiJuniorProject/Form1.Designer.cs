namespace ResponsiJuniorProject
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
            label1 = new Label();
            label2 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            cbDep = new ComboBox();
            dgvData = new DataGridView();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 67);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 91);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(22, 132);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(103, 29);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(148, 132);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(272, 132);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(403, 132);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(103, 29);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Refresh Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(365, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 97);
            panel1.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 80);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 5;
            label8.Text = "FIN : Finance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 65);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 4;
            label7.Text = "PM : Product Manager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 50);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 3;
            label6.Text = "DEV : Developer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 33);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 2;
            label5.Text = "ENG : Engineer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 1;
            label4.Text = "HR : HR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 0;
            label3.Text = "ID Departemen:";
            // 
            // tbName
            // 
            tbName.Location = new Point(130, 64);
            tbName.Name = "tbName";
            tbName.Size = new Size(134, 23);
            tbName.TabIndex = 7;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(130, 94);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(134, 23);
            cbDep.TabIndex = 8;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(22, 167);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(484, 203);
            dgvData.TabIndex = 9;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 28);
            label9.Name = "label9";
            label9.Size = new Size(183, 15);
            label9.TabIndex = 11;
            label9.Text = "Karyawan Database Management";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 382);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(dgvData);
            Controls.Add(cbDep);
            Controls.Add(tbName);
            Controls.Add(panel1);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoad;
        private Panel panel1;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbName;
        private ComboBox cbDep;
        private DataGridView dgvData;
        private PictureBox pictureBox1;
        private Label label9;
    }
}