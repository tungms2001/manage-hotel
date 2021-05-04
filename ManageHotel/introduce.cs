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
    public partial class introduce : Form
    {
        public introduce()
        {
            InitializeComponent();
        }

        private void introduce_Load(object sender, EventArgs e)
        {
            ptbIntroduce.Image = ManageHotel.Properties.Resources.Untitled11;
        }
    }
}
