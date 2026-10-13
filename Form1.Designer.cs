namespace Bai46_QuanLySinhVien
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
            grpStudent = new GroupBox();
            lblStudentId = new Label();
            lblFullName = new Label();
            lblAge = new Label();
            lblGender = new Label();
            txtStudentId = new TextBox();
            txtFullName = new TextBox();
            txtAge = new TextBox();
            cboGender = new ComboBox();
            grpAvatar = new GroupBox();
            picAvatar = new PictureBox();
            btnChooseAvatar = new Button();
            grpFunctions = new GroupBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExportCsv = new Button();
            dgvStudents = new DataGridView();
            grpStudent.SuspendLayout();
            grpAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            grpFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            this.SuspendLayout();
            // 
            // grpStudent
            // 
            grpStudent.Controls.Add(cboGender);
            grpStudent.Controls.Add(txtAge);
            grpStudent.Controls.Add(txtFullName);
            grpStudent.Controls.Add(txtStudentId);
            grpStudent.Controls.Add(lblGender);
            grpStudent.Controls.Add(lblAge);
            grpStudent.Controls.Add(lblFullName);
            grpStudent.Controls.Add(lblStudentId);
            grpStudent.Location = new Point(24, 13);
            grpStudent.Name = "grpStudent";
            grpStudent.Size = new Size(463, 223);
            grpStudent.TabIndex = 0;
            grpStudent.TabStop = false;
            grpStudent.Text = "Thông tin sinh viên";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(11, 36);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(91, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã sinh viên";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(11, 82);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(54, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ tên";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(11, 130);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(38, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "Tuổi";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(11, 176);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(65, 20);
            lblGender.TabIndex = 3;
            lblGender.Text = "Giới tính";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(123, 29);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(125, 27);
            txtStudentId.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(123, 75);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(123, 123);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 6;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(123, 168);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 7;
            // 
            // grpAvatar
            // 
            grpAvatar.Controls.Add(btnChooseAvatar);
            grpAvatar.Controls.Add(picAvatar);
            grpAvatar.Location = new Point(505, 13);
            grpAvatar.Name = "grpAvatar";
            grpAvatar.Size = new Size(315, 223);
            grpAvatar.TabIndex = 1;
            grpAvatar.TabStop = false;
            grpAvatar.Text = "Ảnh đại diện";
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(15, 41);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(125, 125);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Location = new Point(173, 66);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(94, 29);
            btnChooseAvatar.TabIndex = 1;
            btnChooseAvatar.Text = "Chọn ảnh";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            // 
            // grpFunctions
            // 
            grpFunctions.Controls.Add(btnExportCsv);
            grpFunctions.Controls.Add(btnUpdate);
            grpFunctions.Controls.Add(btnDelete);
            grpFunctions.Controls.Add(btnAdd);
            grpFunctions.Location = new Point(853, 13);
            grpFunctions.Name = "grpFunctions";
            grpFunctions.Size = new Size(286, 223);
            grpFunctions.TabIndex = 2;
            grpFunctions.TabStop = false;
            grpFunctions.Text = "Chức năng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(163, 42);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(24, 121);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(163, 122);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(117, 29);
            btnExportCsv.TabIndex = 3;
            btnExportCsv.Text = "Xuất file CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(24, 287);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1115, 188);
            dgvStudents.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(dgvStudents);
            Controls.Add(grpFunctions);
            Controls.Add(grpAvatar);
            Controls.Add(grpStudent);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            grpStudent.ResumeLayout(false);
            grpStudent.PerformLayout();
            grpAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            grpFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpStudent;
        private Label lblGender;
        private Label lblAge;
        private Label lblFullName;
        private Label lblStudentId;
        private TextBox txtFullName;
        private TextBox txtStudentId;
        private ComboBox cboGender;
        private TextBox txtAge;
        private GroupBox grpAvatar;
        private PictureBox picAvatar;
        private Button btnChooseAvatar;
        private GroupBox grpFunctions;
        private Button btnExportCsv;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvStudents;
    }
}
