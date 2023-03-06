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
    public partial class FormRezarvationPage : Form
    {
        public FormRezarvationPage()
        {
            InitializeComponent();
        }
        Button clickedButton = null;
        List<Reservation> rezarvasyonlar = new List<Reservation>();



        private void Btn_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
           // Reservation reservation = clickedButton.Tag as Reservation;
           // MessageBox.Show(clickedButton.Text + "" + reservation.Room.RoomCondition);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //KING Button Assigment
            Button btnKing = new Button();
            btnKing.Text = "King Room";
            btnKing.BackColor = Color.Green;
         // btnKing.Tag = null;

            btnKing.Width = 440;
            btnKing.Height = 100;
            

           
            
            



            int count = 99;

            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = (++count).ToString();
                btn.BackColor = Color.Green;
                btn.Tag = new Reservation()
                {
                    Room = new Room()
                    {
                        Price = 50,
                        RoomNo = int.Parse(btn.Text),
                        RoomCondition = RoomCondition.Empty
                    },
                    Customer = new Customer()
                    {

                    }
                };
                if (i == 9)
                {
                    btnKing.Tag = new Reservation()
                    {
                        Room = new Room()
                        {
                            Price = 500,
                            RoomNo = int.Parse(btn.Text),
                            RoomCondition = RoomCondition.Empty
                        },
                        Customer = new Customer()
                        {

                        }
                    };
                }
                btn.Click += Btn_Click;
                flOne.Controls.Add(btn);
                btnKing.Click += Btn_Click;
                flFour.Controls.Add(btnKing);
            }
            int count2 = 109;

            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = (++count2).ToString();
                btn.BackColor = Color.Green;
                btn.Tag = new Reservation()
                {
                    Room = new Room()
                    {
                        Price = 100,
                        RoomNo = int.Parse(btn.Text),
                        RoomCondition = RoomCondition.Empty
                    },
                    Customer = new Customer()
                    {

                    }
                };
                btn.Click += Btn_Click;
                flTwo.Controls.Add(btn);
            }

            int count3 = 119;

            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = (++count3).ToString();
                btn.BackColor = Color.Green;
                btn.Tag = new Reservation()
                {
                    Room = new Room()
                    {
                        Price = 200,
                        RoomNo = int.Parse(btn.Text),
                        RoomCondition = RoomCondition.Empty

                    },
                    Customer = new Customer()
                    {

                    }
                };
                btn.Click += Btn_Click;
                flThree.Controls.Add(btn);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reservation reservation = clickedButton.Tag as Reservation;
            if (reservation.Room.RoomCondition == RoomCondition.Empty)
            {
                reservation.Customer = new Customer();
                
                reservation.Customer.FullName = txtName.Text;
                reservation.Customer.ID = txtID.Text;
                reservation.Customer.NumberOfPerson = Convert.ToInt32(nudPlp.Value);
                reservation.Customer.Phone = txtPhone.Text;
                reservation.Customer.EntranceTime = dateTimePicker1.Value;
                reservation.Customer.QuitTime = dateTimePicker2.Value;
                rezarvasyonlar.Add(reservation);

                //reservation.Customer = new Customer()
                //{
                //    FullName = txtName.Text,
                //    TC = txtID.Text,
                //    Phone = txtPhone.Text,
                

                //};


                reservation.Room.RoomCondition = RoomCondition.Full;
                clickedButton.BackColor = Color.Red;
               
            }
            else
            {
                MessageBox.Show("Room is full");
            }
           
        }

        private void btnOdemeSayfasi_Click(object sender, EventArgs e)
        {
            FormPaymentPage paymentPage = new FormPaymentPage(rezarvasyonlar);
            paymentPage.Show();
            
        }
    }
}
