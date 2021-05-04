using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ManageHotel
{
    public partial class FormBill : Form
    {
        private ManageHotelEntities entities = fRoomCategories.entities;
        private BindingSource source = new BindingSource();
        public FormBill()
        {
            InitializeComponent();
            RefreshData();
            AddBinding();
        }

        private void RefreshData()
        {
            //lấy ra danh sách những phòng đang được thuê
            List<string> rentingRoomName = entities.RoomCategories.Where(p => p.rentedDay != null).Select(p => p.name).ToList();

            foreach (string currentRoomName in rentingRoomName)
            {
                //tính số ngày thuê, nếu thuê chưa được một ngày thì cũng tính một ngày
                RoomCategory room = entities.RoomCategories.Where(p => p.name == currentRoomName).SingleOrDefault();
                int amountDays = int.Parse((DateTime.Now - (DateTime)room.rentedDay).Days.ToString());
                room.countRented = (amountDays != 0) ? amountDays : 1;
                room.total = 0;
                //duyệt qua hết những người thuê cùng một phòng, tính tổng hệ số của mỗi người
                List<Customer> presentCustomer = entities.Customers.Where(p => p.roomName == room.name).ToList();
                foreach (var item in presentCustomer)
                    room.total += fRoomCategories.kindAndCoefficient[item.kind];
                room.total *= room.price;   //nhân với đơn giá của phòng để được chi phí của phòng
                if (presentCustomer.Count() >= fRoomCategories.surchargeBeginning) //bắt đầu phụ thu khi số khách bằng surchargeBeginning
                    room.total *= fRoomCategories.surchargeRatio;
            }

            //thực hiện việc đánh số cho mẫu dữ liệu được tải ra (ở đây sử dụng ordinalNumber như một biến tạm)
            List<string> name = entities.RoomCategories.Select(p => p.name).ToList();
            for (int i = 0; i < name.Count; i++)
            {
                RoomCategory room = entities.RoomCategories.Find(name[i]);
                room.ordinalNumber = i + 1;
            }
            entities.SaveChanges();

            //lấy dữ liệu ra, đổ vào DataGridView
            var discreteData = from p in entities.RoomCategories.AsEnumerable()
                         where p.roomStatus == "Đã được thuê"
                         orderby p.ordinalNumber ascending
                         select new { p.ordinalNumber, p.name, p.countRented, p.price, p.total };
            source.DataSource = discreteData.ToList();
            dgvRentRoom.DataSource = source;
            //nếu bảng có dữ liệu thì lấy dòng đầu tiên, truy vấn thông tin khách hàng, đổ vào txtCustomer và txtAddress
            if (discreteData.ToList().Count != 0)
            {
                string tempName = discreteData.ToList().First().name;
                Customer customer = entities.Customers.Where(p => p.roomName == tempName).FirstOrDefault();
                txtCustomer.Text = customer.name;
                txtAddress.Text = customer.address;
            }
            else    //nếu không thì gán hai textbox này bằng chuỗi rỗng
            {
                txtCustomer.Text = "";
                txtAddress.Text = "";
            }

            //đặt tên cho tiêu đề của các cột trong bảng
            dgvRentRoom.Columns[0].HeaderText = "Số thứ tự";
            dgvRentRoom.Columns[1].HeaderText = "Phòng";
            dgvRentRoom.Columns[2].HeaderText = "Số ngày thuê";
            dgvRentRoom.Columns[3].HeaderText = "Đơn giá";
            dgvRentRoom.Columns[4].HeaderText = "Thành tiền";
        }

        private void AddBinding()   //tạo DataBinding
        {
            txtPriceValue.DataBindings.Add(new Binding("Text", dgvRentRoom.DataSource, "total", true, DataSourceUpdateMode.Never));
        }

        #region Functions for event
        private void PrintFile(string Path, string Content) //hàm in dữ liệu thanh toán ra file
        {
            FileStream fstream = new FileStream(Path, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(fstream);
            writer.Write(Content);
            writer.Close();
            fstream.Close();
        }

        private void Pay()  //hàm thanh toán phòng hiện tại
        {
            if (dgvRentRoom.Rows.Count != 0)    //kiểm tra bảng có dữ liệu hay không
            {
                string roomName = dgvRentRoom.SelectedCells[0].OwningRow.Cells["name"].Value.ToString();
                List<Customer> customer = entities.Customers.Where(p => p.roomName == roomName).ToList();
                string printString = "";

                printString += "KHÁCH SẠN ST-T" +
                    "\nSĐT: 0704739698" +
                    "\nĐịa chỉ: Nguyễn Tri Phương, Phường 9, Quận 5, TP.HCM" +
                    "\n\nPhòng: " + customer[0].roomName + "\n";
                for (int i = 0; i < customer.Count; i++)
                {
                    printString += "Tên khách hàng: " + customer[i].name +
                    ".\nCăn cước: " + customer[i].identityNumber +
                    ".\nĐịa chỉ: " + customer[i].address +
                    ".\nNgày thuê: " + customer[i].rentedDay.ToString() + ".\n";
                }
                printString += "\nKHÁCH HÀNG PHẢI THANH TOÁN " + txtPriceValue.Text + "vnđ" +
                    ".\nNhân viên: " + fRoomCategories.CurrentUser.name +
                    ".\nThời điểm: " + DateTime.Now.ToString() + ".";   //chuỗi printString để ghi ra file

                string payString = printString + "\n\nBạn thực sự muốn thanh toán?";    //tạo chuỗi thông báo tổng kết dữ liệu cho khách hàng (xuất ra MessageBox)

                DialogResult dialogResult = MessageBox.Show(printString, "Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)    //nếu thật sự muốn thoát
                {
                    string FileName = DateTime.Now.ToString();
                    FileName = FileName.Replace("/", string.Empty);
                    FileName = FileName.Replace(":", string.Empty);
                    FileName = FileName.Replace(" ", "_");  //khối lệnh này để tạo tên file từ thởi gian hiện tại, xóa / và : ra khỏi tên vì những ký tự này không hợp lệ

                    PrintFile(@Path.GetDirectoryName(Application.ExecutablePath).ToString() + @"\" + FileName + ".txt", printString);   //gọi hàm ghi file
                    MessageBox.Show("Thanh toán thành công. Hóa đơn được lưu ở\n" + Path.GetDirectoryName(Application.ExecutablePath).ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    List<Customer> listCustomerName = entities.Customers.Where(p => p.roomName == roomName).Select(p => p).ToList();

                    RoomHistory history = new RoomHistory() //thêm vào lịch sử thuê phòng để dành truy vấn báo cáo
                    {
                        name = customer[0].RoomCategory.name,
                        kind = customer[0].RoomCategory.kind,
                        countRented = customer[0].RoomCategory.countRented,
                        rentedDay = customer[0].RoomCategory.rentedDay,
                        total = customer[0].RoomCategory.total
                    };
                    entities.RoomHistories.Add(history);

                    foreach (var item in listCustomerName)  //xóa khách hàng, gán các giá trị Trống cho phòng
                    {
                        item.RoomCategory.roomStatus = "Trống";
                        item.RoomCategory.countRented = 0;
                        item.RoomCategory.rentedDay = null;
                        item.RoomCategory.total = 0;
                        entities.Customers.Remove(item);
                    }
                    entities.SaveChanges();
                    RefreshData();
                }
            }
            else
                MessageBox.Show("Không có khách hàng để tiến hành thanh toán", "Hết dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);    //không có dữ liệu
        }
        #endregion

        #region Events
        private void dgvRentRoom_CellClick(object sender, DataGridViewCellEventArgs e)  //hàm bind dữ liệu khách hàng từ DataGridView đến textBox
        {
            if (e.RowIndex != -1)   //-1 là chỉ số hàng của hàng tiêu đề, nếu không có lệnh if này sẽ phát sinh ngoại lệ
            {
                dgvRentRoom.CurrentCell = dgvRentRoom.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string name = dgvRentRoom.SelectedCells[0].OwningRow.Cells["name"].Value.ToString();
                Customer customer = entities.Customers.Where(p => p.roomName == name).FirstOrDefault();

                txtCustomer.Text = customer.name;
                txtAddress.Text = customer.address;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)    //sự kiện khi nhấn nút Thanh toán
        {
            Pay();
            RefreshData();
        }
        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fRoomCategories form = new fRoomCategories(fRoomCategories.CurrentUser);
            Hide();
            form.ShowDialog();
            Show();

        }
    }
}
