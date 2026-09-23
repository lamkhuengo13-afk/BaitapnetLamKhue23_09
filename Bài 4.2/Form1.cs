using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>
            {
                new Course { CourseId = "ATTT01", CourseName = "An toàn thông tin cơ bản" },
                new Course { CourseId = "MMT_VLAN", CourseName = "Quản trị Mạng và cấu hình VLAN" },
                new Course { CourseId = "VOV_01", CourseName = "Thực hành Vovinam tự vệ" }
            };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "CourseName"; 
            cboCourse.ValueMember = "CourseId";     
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!chkAgree.Checked)
            {
                MessageBox.Show("Bạn phải đồng ý với nội quy để tiếp tục!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = txtName.Text;
            string phone = mtxrPhone.Text;
            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy");

            string gender = "Chưa xác định";
            if (radMale.Checked) gender = "Nam";
            else if (radFemale.Checked) gender = "Nữ";

            string selectedCourseName = cboCourse.Text;
            string selectedCourseId = cboCourse.SelectedValue?.ToString();

            string result = "THÔNG TIN ĐĂNG KÝ HỌC VIÊN:\n" +
                            "-----------------------------------\n" +
                            $"- Họ và tên: {fullName}\n" +
                            $"- Giới tính: {gender}\n" +
                            $"- Ngày sinh: {birthDate}\n" +
                            $"- Số điện thoại: {phone}\n" +
                            $"- Khóa học đăng ký: {selectedCourseName}\n" +
                            $"- Mã khóa học: {selectedCourseId}";

            MessageBox.Show(result, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
    }
}