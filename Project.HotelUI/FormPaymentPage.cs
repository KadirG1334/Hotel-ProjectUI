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
    public partial class FormPaymentPage : Form
    {
        
        private List<Reservation> rezarvasyonlar;

        public FormPaymentPage()
        {
            InitializeComponent();
        }

       

        public FormPaymentPage(List<Reservation> rezarvasyonlar):this()
        {
            this.rezarvasyonlar = rezarvasyonlar;
        }

        double calc = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Reservation item in rezarvasyonlar)
            {
                if (item.Customer.FullName.ToLower() == (txtSearch.Text.ToLower()))
                {

                    MessageBox.Show("Arama kriterlerine göre kişi bulunuldu");
                  lblDailyPrice.Text = Convert.ToString(item.Room.Price);
                  lblTotalDay.Text = Convert.ToString(Math.Ceiling((item.Customer.QuitTime-item.Customer.EntranceTime).TotalDays));
                    calc = Convert.ToDouble(Math.Ceiling((item.Customer.QuitTime - item.Customer.EntranceTime).TotalDays)) * item.Room.Price;
                }
                else
                {
                    MessageBox.Show("Arama kriterlerine göre kimse bulunamadı");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTotprice_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(calc);
        }

        private void btncustquit_Click(object sender, EventArgs e)
        {
            foreach (Reservation item in rezarvasyonlar)
            {
                if (item.Customer.FullName.ToLower() == (txtSearch.Text.ToLower()))
                {
                    item.Room.RoomCondition = RoomCondition.Cleaning;
                    MessageBox.Show("Odadan çıkış Yapılmıştır.Oda şu an temizlenmektedir");
                }
                    

            }
        }

        private void btnZreport_Click(object sender, EventArgs e)
        {
            FormDailyReport form3 = new FormDailyReport(rezarvasyonlar);
            form3.Show();
        }
    }
}
