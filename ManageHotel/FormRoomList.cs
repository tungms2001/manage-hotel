using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ManageHotel
{
    public partial class fRoomList : Form
    {
        #region Initilization
        public static ManageHotelEntities entities = fRoomCategories.entities; //lấy biến entities bên form danh mục xài
        private BindingSource source = new BindingSource();
        #endregion

        public fRoomList()
        {
            InitializeComponent();
            RefreshData();
            cbRoomKind.DataSource = fRoomCategories.kindAndPrice.Keys.ToList(); //lấy loại phòng đổ vào comboBox
            AddBinding();
        }

        private void RefreshData()  //làm mới dữ liệu
        {
            //thực hiện việc đánh số cho mẫu dữ liệu được tải ra (ở đây sử dụng ordinalNumber như một biến tạm)
            List<string> name = entities.RoomCategories.Select(p => p.name).ToList();
            for (int i = 0; i < name.Count; i++)
            {
                RoomCategory room = entities.RoomCategories.Find(name[i]);
                room.ordinalNumber = i + 1;
            }
            entities.SaveChanges();

            //truy vấn các trường cần thiết và đổ vào DataGridView
            var ambiguosData = (from p in entities.RoomCategories
                                orderby p.id ascending
                                select new { p.ordinalNumber, p.name, p.kind, p.price, p.roomStatus }).ToList();

            source.DataSource = ambiguosData;
            dgvRoomList.DataSource = source;

            //đặt tên cho tiêu đề mỗi cột
            dgvRoomList.Columns[0].HeaderText = "Số thứ tự";
            dgvRoomList.Columns[1].HeaderText = "Tên phòng";
            dgvRoomList.Columns[2].HeaderText = "Loại phòng";
            dgvRoomList.Columns[3].HeaderText = "Giá";
            dgvRoomList.Columns[4].HeaderText = "Tình trạng";
        }
        private void AddBinding()
        {
            txtRoomName.DataBindings.Add(new Binding("Text", dgvRoomList.DataSource, "name", true, DataSourceUpdateMode.Never));
            cbRoomKind.DataBindings.Add(new Binding("Text", dgvRoomList.DataSource, "kind", true, DataSourceUpdateMode.Never));
            txtRoomPrice.DataBindings.Add(new Binding("Text", dgvRoomList.DataSource, "price", true, DataSourceUpdateMode.Never));
        }

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)   //sự kiện qua form cho thuê/khách hàng
        {
            fCustomer form = new fCustomer();
            Hide();
            form.ShowDialog();
            Show();
            RefreshData();
        }

        private void cbRoomKind_SelectedValueChanged(object sender, EventArgs e)    //sự kiện comboBox thay đổi
        {
            txtRoomPrice.Text = fRoomCategories.kindAndPrice[cbRoomKind.SelectedItem.ToString()].ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)   //sự kiện qua form thanh toán
        {
            FormBill form = new FormBill();
            Hide();
            form.ShowDialog();
            Show();
            RefreshData();
        }
        #endregion
    }
}
