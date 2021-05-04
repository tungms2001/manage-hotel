using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageHotel
{
    public partial class fLogin : Form
    {
        ManageHotelEntities entities = fRoomCategories.entities;
        public fLogin()
        {
            InitializeComponent();
        }

        #region Functions for event
        private void ResetData()    //Hàm xóa thông tin đăng nhập mỗi khi khởi tạo form
        {
            txtAccount.Clear();     //reset dữ liệu textbox tài khoản
            txtPassword.Clear();    //reset dữ liệu textbox mật khẩu
        }

        private void Login()
        {
            if (string.IsNullOrEmpty(txtAccount.Text) || string.IsNullOrEmpty(txtAccount.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Tài khoản/mật khẩu không được rỗng hoặc chứa ký tự trắng", "Không thể đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            //Lấy dữ liệu tài khoản đổ vào list
            List<Manager> AllUsers = entities.Managers.Select(p => p).ToList();
            Manager CurrentUser = new Manager();    //tài khoản hiện tại
            bool Match = false; //cờ báo hiệu tìm thấy

            foreach (Manager User in AllUsers)  //duyệt hết danh sách tài khoản
                if (User.account == txtAccount.Text && User.password == txtPassword.Text)   //nếu tìm thấy
                {
                    CurrentUser = User; //gán tài khoản hiện tại bằng tài khoản tìm thấy
                    Match = true;   //tìm thấy
                    break;  //lập tức thoát vòng lặp
                }
            
            if (Match)    //nếu truy vấn ra được thì đăng nhập thành công
            {
                fRoomCategories form = new fRoomCategories(CurrentUser);    //truyền người dùng hiện tại vào constructor của form danh mục
                Hide();
                form.ShowDialog();
                Show();
                ResetData();
            }   //nếu truy vấn không ra thì báo lỗi
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Không thể đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Event
        private void btnLogin_Click(object sender, EventArgs e) //sự kiện nhấn nút đăng nhập
        {
            Login();
        }
        #endregion

        private void btnIntroduce_Click(object sender, EventArgs e)
        {
            introduce form = new introduce();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
