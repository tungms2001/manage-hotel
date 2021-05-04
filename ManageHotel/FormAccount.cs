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
    public partial class fAccount : Form
    {
        ManageHotelEntities entities = fRoomCategories.entities;
        public fAccount()
        {
            InitializeComponent();
            RefreshData();
        }

        #region Functions for event
        private void RefreshData()
        {
            txtAccount.Text = fRoomCategories.CurrentUser.account;  //đổ thông tin tài khoản hiện tại vào textbox tài khoản
            txtName.Text = fRoomCategories.CurrentUser.name;    //đổ thông tin tên người dùng hiện tại vào textbox tên
        }
        #endregion

        #region Events
        private void btnChangePassword_Click(object sender, EventArgs e)    //sự kiện đổi nhấn nút đổi mật khẩu
        {
            //truy vấn tài khoản hiện tại
            Manager user = entities.Managers.Where(p => p.account == txtAccount.Text && p.password == txtOldPassword.Text).SingleOrDefault();
            if (user != null)   //nếu tìm thấy tài khoản thỏa mãn
            {
                if (txtNewPassword.Text != txtReNewPassword.Text)   //nếu mật khẩu cũ và mới không trung khớp thì báo lỗi
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else    //đổi mật khẩu thành công
                {
                    user.password = txtNewPassword.Text;
                    MessageBox.Show("Cập nhật mật khẩu mới thành công", "Đã đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    entities.SaveChanges();
                    Close();
                }
            }
            else    //không tìm thấy tài khoản thỏa mãn thì báo lỗi
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
