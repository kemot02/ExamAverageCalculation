namespace ogrencisınavdurumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double K1, K2, K3, K4, K5, Ktotal, Ktotalround, Kgeçme, Final, Finalort, Finalortround;
            double K1round, K2round, K3round, K4round, K5round;
            double sinav1, sinav2, sinav3, sinav4, sinav5;
            double lab1, lab2, lab3, lab4, lab5;
            double pbl1, pbl2, pbl3, pbl4, pbl5;
            double srp1, srptotal;
            string durum, durum2;
            Final=Convert.ToDouble(tbxFinal.Text);
            sinav1 = Convert.ToDouble(tbxsınav1.Text);
            sinav2 = Convert.ToDouble(tbxsınav2.Text);
            sinav3 = Convert.ToDouble(tbxsınav3.Text);
            sinav4 = Convert.ToDouble(tbxsınav4.Text);
            sinav5 = Convert.ToDouble(tbxsınav5.Text);

            lab1 = Convert.ToDouble(tbxlab1.Text);
            lab2 = Convert.ToDouble(tbxlab2.Text);
            lab3 = Convert.ToDouble(tbxlab3.Text);
            lab4 = Convert.ToDouble(tbxlab4.Text);
            lab5 = Convert.ToDouble(tbxlab5.Text);

            pbl1 = Convert.ToDouble(tbxpbl1.Text);
            pbl2 = Convert.ToDouble(tbxpbl2.Text);
            pbl3 = Convert.ToDouble(tbxpbl3.Text);
            pbl4 = Convert.ToDouble(tbxpbl4.Text);
            pbl5 = Convert.ToDouble(tbxpbl5.Text);

            srp1 = Convert.ToDouble(tbxsrp.Text);

            K1 = ((95 * ((90 * (sinav1) / 100) + (10 * (lab1) / 100)) / 100) + (5 * (pbl1) / 100));
            K2 = ((95 * ((90 * (sinav2) / 100) + (10 * (lab2) / 100)) / 100) + (5 * (pbl2) / 100));
            K3 = ((95 * ((90 * (sinav3) / 100) + (10 * (lab3) / 100)) / 100) + (5 * (pbl3) / 100));
            K4 = ((95 * ((90 * (sinav4) / 100) + (10 * (lab4) / 100)) / 100) + (5 * (pbl4) / 100));
            K5 = ((95 * ((90 * (sinav5) / 100) + (10 * (lab5) / 100)) / 100) + (5 * (pbl5) / 100));
            K1round = Math.Round(K1, MidpointRounding.ToEven);
            K2round = Math.Round(K2, MidpointRounding.ToEven);
            K3round = Math.Round(K3, MidpointRounding.ToEven);
            K4round = Math.Round(K4, MidpointRounding.ToEven);
            K5round = Math.Round(K5, MidpointRounding.ToEven);
            tbxK1.Text = Convert.ToString(K1round);
            tbxK2.Text = Convert.ToString(K2round);
            tbxK3.Text = Convert.ToString(K3round);
            tbxK4.Text = Convert.ToString(K4round);
            tbxK5.Text = Convert.ToString(K5round);

            Ktotal = (K1 + K2 + K3 + K4 + K5) / 5;

            Ktotalround = Math.Round(Ktotal, MidpointRounding.ToEven);

            if (Ktotalround >= 80)
            {
                durum = "Geçti";
                tbxFinalsizgec.Text = Convert.ToString(Ktotalround) + " / " + durum;
                Kgeçme = 97 * (Ktotal) / 100;
                srptotal = 3 * (srp1) / 100;
                tbxSınıfgec.Text = Convert.ToString(srptotal) + Convert.ToString(Kgeçme);

            }
            else
            {
                durum = "Finale giriniz";
                tbxFinalsizgec.Text = Convert.ToString(Ktotalround) + " / " + durum;
                tbxSınıfgec.Text = "Finale giriniz";
                if (Final!=1)
                {
                    Finalort = (97 * ((40 * (Ktotal) / 100) + (60 * (Final) / 100))/100)+(3*(srp1)/100);
                    Finalortround = Math.Round(Finalort, MidpointRounding.ToEven);
                    
                    if (Finalortround < 60)
                    {
                        durum2 = " Sınıfta Kaldınız";
                        tbxfinalligecme.Text = Convert.ToString(Finalortround)+" / "+ durum2;
                    }
                    else
                    {
                        durum2 = " Sınıfı Geçtiniz";
                        tbxfinalligecme.Text = Convert.ToString(Finalortround) + " / " + durum2;
                    }

                    

                }
            }













        }

        private void tbntemizle_Click(object sender, EventArgs e)
        {
            tbxsınav1.Text = " ";
            tbxsınav2.Text = " ";
            tbxsınav3.Text = " ";
            tbxsınav4.Text = " ";
            tbxsınav5.Text = " ";
            tbxlab1.Text = " ";
            tbxlab2.Text = " ";
            tbxlab3.Text = " ";
            tbxlab4.Text = " ";
            tbxlab5.Text = " ";
            tbxsrp.Text = " ";
            tbxpbl1.Text = " ";
            tbxpbl2.Text = " ";
            tbxpbl3.Text = " ";
            tbxpbl4.Text = " ";
            tbxpbl5.Text = " ";
            tbxK1.Text = " ";
            tbxK2.Text = " ";
            tbxK3.Text = " ";
            tbxK4.Text = " ";
            tbxK5.Text = " ";
            tbxfinalligecme.Text = " ";
            tbxFinal.Text = " ";
            tbxFinalsizgec.Text = " ";
            tbxSınıfgec.Text = " ";
            tbxsınav1.Focus();

        }
    }
}