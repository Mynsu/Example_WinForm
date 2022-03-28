using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Example_WinForm.Model;

namespace Example_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetMenu();
        }

        private void SetMenu()
        {
            listMenu = new List<Model.Menu>()
            {
                new Model.Menu{ Id=1, Name="김밥", Price=1000 },
                new Model.Menu{ Id=2, Name="라면", Price=3000 },
                new Model.Menu{ Id=3, Name="떡볶이", Price=2000 },
                new Model.Menu{ Id=4, Name="순대", Price=2500 },
                new Model.Menu{ Id=5, Name="공깃밥", Price=500 },
            };
        }

        /*private*/
        List<Model.Menu> listMenu;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listMenu.Find(m => m.Id == Convert.ToInt32(((Button)sender).Tag)).Name);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach(var item in listBox1.Items)
            {
                total += listMenu.Find(m => m.Name == item.ToString()).Price;
            }
            lblPaymentInfo.Text = string.Format("총 결제 금액: {0}", total);
        }
    }
}
