namespace Project.HotelUI
{
    partial class FormPaymentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnZreport = new System.Windows.Forms.Button();
            this.btncustquit = new System.Windows.Forms.Button();
            this.lblTotalDay = new System.Windows.Forms.Label();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTotprice = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZreport
            // 
            this.btnZreport.Location = new System.Drawing.Point(490, 311);
            this.btnZreport.Name = "btnZreport";
            this.btnZreport.Size = new System.Drawing.Size(144, 52);
            this.btnZreport.TabIndex = 27;
            this.btnZreport.Text = "Gün Sonu Sayfası";
            this.btnZreport.UseVisualStyleBackColor = true;
            this.btnZreport.Click += new System.EventHandler(this.btnZreport_Click);
            // 
            // btncustquit
            // 
            this.btncustquit.Location = new System.Drawing.Point(490, 232);
            this.btncustquit.Name = "btncustquit";
            this.btncustquit.Size = new System.Drawing.Size(141, 52);
            this.btncustquit.TabIndex = 26;
            this.btncustquit.Text = "Müşterinin Çıkışını Yap";
            this.btncustquit.UseVisualStyleBackColor = true;
            this.btncustquit.Click += new System.EventHandler(this.btncustquit_Click);
            // 
            // lblTotalDay
            // 
            this.lblTotalDay.AutoSize = true;
            this.lblTotalDay.Location = new System.Drawing.Point(199, 172);
            this.lblTotalDay.Name = "lblTotalDay";
            this.lblTotalDay.Size = new System.Drawing.Size(35, 13);
            this.lblTotalDay.TabIndex = 25;
            this.lblTotalDay.Text = "label7";
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.AutoSize = true;
            this.lblDailyPrice.Location = new System.Drawing.Point(199, 135);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(35, 13);
            this.lblDailyPrice.TabIndex = 24;
            this.lblDailyPrice.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kalınan Gün Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Günlük Ücret";
            // 
            // btnTotprice
            // 
            this.btnTotprice.Location = new System.Drawing.Point(53, 246);
            this.btnTotprice.Name = "btnTotprice";
            this.btnTotprice.Size = new System.Drawing.Size(132, 52);
            this.btnTotprice.TabIndex = 21;
            this.btnTotprice.Text = "Toplam Ücret Hesapla";
            this.btnTotprice.UseVisualStyleBackColor = true;
            this.btnTotprice.Click += new System.EventHandler(this.btnTotprice_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(313, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 43);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(384, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Müşteri Ad Soyad";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(221, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZreport);
            this.Controls.Add(this.btncustquit);
            this.Controls.Add(this.lblTotalDay);
            this.Controls.Add(this.lblDailyPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTotprice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZreport;
        private System.Windows.Forms.Button btncustquit;
        private System.Windows.Forms.Label lblTotalDay;
        private System.Windows.Forms.Label lblDailyPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTotprice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}