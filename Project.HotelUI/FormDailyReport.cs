using Project.HotelUI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HotelUI
{
    public partial class FormDailyReport : Form
    {
        private List<Reservation> rezarvasyonlar;

        public FormDailyReport()
        {
            InitializeComponent();
        }

        public FormDailyReport(List<Reservation> rezarvasyonlar):this() 
        {
            this.rezarvasyonlar = rezarvasyonlar;
        }

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           ToLoad();
        }
        public void ToLoad()
        {
            byte sayac = 0;
            foreach (Reservation item in rezarvasyonlar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = (sayac++).ToString();
                li.SubItems.Add(item.Customer.TC);
                li.SubItems.Add(item.Customer.FullName);
                string b = Convert.ToString(Math.Ceiling((item.Customer.QuitTime - item.Customer.EntranceTime).TotalDays));
                li.SubItems.Add(b);
                if (item.Room.Price == 50)
                {
                    li.SubItems.Add("1; Tek Kişilik Yatak");
                }
                else if (item.Room.Price == 100)
                {
                    li.SubItems.Add("2; Çift Kişilik Yatak");
                }
                else if (item.Room.Price == 300)
                {
                    li.SubItems.Add("3; 1 Çift, 1 Tek Kişilik Yatak");
                }
                else
                {
                    li.SubItems.Add("4; Kral Dairesi");
                }
                li.Tag = item;
                lstReport.Items.Add(li);
            }
        }
    }
}
