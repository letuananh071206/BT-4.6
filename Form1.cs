
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Bai46_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        private BindingList<Student> students;
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();

            students = new BindingList<Student>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = students;

            dgvStudents.DataSource = bindingSource;

            cboGender.Items.Clear();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");

            txtStudentId.DataBindings.Add(
                "Text", bindingSource, "StudentId",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txtFullName.DataBindings.Add(
                "Text", bindingSource, "FullName",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txtAge.DataBindings.Add(
                "Text", bindingSource, "Age",
                true, DataSourceUpdateMode.OnPropertyChanged);

            cboGender.DataBindings.Add(
                "Text", bindingSource, "Gender",
                true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSource.CurrentChanged +=
                bindingSource_CurrentChanged;

            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            btnExportCsv.Click += btnExportCsv_Click;

            LoadAvatar();
        }

        private Student CurrentStudent
        {
            get
            {
                return bindingSource.Current as Student;
            }
        }

        private void bindingSource_CurrentChanged(
            object sender, EventArgs e)
        {
            LoadAvatar();
        }

        private void LoadAvatar()
        {
            Student s = CurrentStudent;

            if (picAvatar.Image != null)
            {
                Image oldImage = picAvatar.Image;
                picAvatar.Image = null;
                oldImage.Dispose();
            }

            if (s == null || string.IsNullOrEmpty(s.AvatarPath))
                return;

            if (!File.Exists(s.AvatarPath))
                return;

            try
            {
                using (Image img = Image.FromFile(s.AvatarPath))
                {
                    picAvatar.Image = new Bitmap(img);
                }
            }
            catch
            {
                MessageBox.Show("Không thể tải ảnh đại diện.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtStudentId.Text.Trim();
            string name = txtFullName.Text.Trim();
            int age;

            if (id == "" || name == "")
            {
                MessageBox.Show("Vui lòng nhập mã và họ tên.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) ||
                age <= 0 || age > 150)
            {
                MessageBox.Show("Tuổi không hợp lệ.");
                return;
            }

            foreach (Student s in students)
            {
                if (s.StudentId == id)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.");
                    return;
                }
            }

            Student newStudent = new Student();
            newStudent.StudentId = id;
            newStudent.FullName = name;
            newStudent.Age = age;
            newStudent.Gender = cboGender.Text;
            newStudent.AvatarPath = "";

            students.Add(newStudent);
            bindingSource.Position = students.Count - 1;

            MessageBox.Show("Thêm sinh viên thành công.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student s = CurrentStudent;

            if (s == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                students.Remove(s);
                LoadAvatar();
                MessageBox.Show("Đã xóa sinh viên.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student s = CurrentStudent;

            if (s == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật.");
                return;
            }

            int age;

            if (txtStudentId.Text.Trim() == "" ||
                txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên và họ tên không được để trống.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) ||
                age <= 0 || age > 150)
            {
                MessageBox.Show("Tuổi không hợp lệ.");
                return;
            }

            string id = txtStudentId.Text.Trim();

            foreach (Student item in students)
            {
                if (item != s && item.StudentId == id)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.");
                    return;
                }
            }

            bindingSource.EndEdit();

            s.StudentId = id;
            s.FullName = txtFullName.Text.Trim();
            s.Age = age;
            s.Gender = cboGender.Text;

            bindingSource.ResetCurrentItem();

            MessageBox.Show("Cập nhật sinh viên thành công.");
        }

        private void btnChooseAvatar_Click(
            object sender, EventArgs e)
        {
            Student s = CurrentStudent;

            if (s == null)
            {
                MessageBox.Show("Hãy thêm hoặc chọn sinh viên trước.");
                return;
            }

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh đại diện";
                dialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    s.AvatarPath = dialog.FileName;
                    LoadAvatar();
                    bindingSource.ResetCurrentItem();
                }
            }
        }

        private void btnExportCsv_Click(
            object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Xuất danh sách sinh viên";
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.FileName = "DanhSachSinhVien.csv";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter writer = new StreamWriter(
                        dialog.FileName, false,
                        new UTF8Encoding(true)))
                    {
                        writer.WriteLine(
                            "MaSV,HoTen,Tuoi,GioiTinh,AvatarPath");

                        foreach (Student s in students)
                        {
                            writer.WriteLine(
                                Csv(s.StudentId) + "," +
                                Csv(s.FullName) + "," +
                                s.Age + "," +
                                Csv(s.Gender) + "," +
                                Csv(s.AvatarPath));
                        }
                    }

                    MessageBox.Show("Xuất file CSV thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message);
                }
            }
        }

        private string Csv(string value)
        {
            if (value == null)
                value = "";

            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
    }
}
