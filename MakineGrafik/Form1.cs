using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakineGrafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Makine> makineler = new List<Makine>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Hedef Miktar");
            chart1.Series.Add("Üretilen Miktar");

            if (!string.IsNullOrEmpty(cbxMakine.Text))
            {
                foreach (Makine makine in makineler)
                {

                    if (cbxMakine.SelectedItem.ToString().Equals(makine.MakineAdı))
                    {
                        foreach (var kontrol in makine.veri)
                        {
                            if (dtpOlusturBaslangic.Value.Date <= kontrol.Key && kontrol.Key <= dtpOlusturBitis.Value.Date)
                            {
                                int[] dizi = kontrol.Value;
                                int hedef = dizi[0];
                                int uretilen = dizi[1];

                                chart1.Series["Hedef Miktar"].Points.AddXY(kontrol.Key.ToShortDateString(), hedef);
                                chart1.Series["Üretilen Miktar"].Points.AddY(uretilen);

                            }
                        }
                        if (makine.veri.Count > 0)
                        {
                            MessageBox.Show("Grafik Olusturuldu");
                        }
                        else
                        {
                            MessageBox.Show("Makine Verisi Mevcut Degil");
                        }
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("Makine Seçimi Yapılmadı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxMakineAd.Text))
            {
                Makine makine = new Makine()
                {
                    MakineAdı = tbxMakineAd.Text
                };

                makineler.Add(makine);
                cbxMakine.Items.Add(makine.MakineAdı);
                cbxEkleMakineAd.Items.Add(makine.MakineAdı);

                MessageBox.Show("Makine Eklendi");
            }
            else
            {
                MessageBox.Show("Makine Adı Boş Bırakılamaz");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxEkleHedefMiktar.Text) && !string.IsNullOrEmpty(cbxEkleMakineAd.Text) && !string.IsNullOrEmpty(tbxEkleUretilenMiktar.Text))
            {
                foreach(Makine makine in makineler)
                {
                    if (makine.MakineAdı.Equals(cbxEkleMakineAd.Text))
                    {
                        bool kontrol = true;
                        foreach(var item in makine.veri)
                        {
                            if (item.Key == dtpEkle.Value.Date)
                            {
                                kontrol = false;
                            }
                        }
                        if (kontrol)
                        {
                            makine.HedefMiktar = Convert.ToInt32(tbxEkleHedefMiktar.Text);
                            makine.UretilenMiktar = Convert.ToInt32(tbxEkleUretilenMiktar.Text);
                            makine.Tarih = Convert.ToDateTime(dtpEkle.Text);
                            makine.veriEkle(makine.Tarih, new int[] { makine.HedefMiktar, makine.UretilenMiktar });

                            dgwMakine.DataSource = makine.MakineGetir();

                            MessageBox.Show("Veriler Eklendi");
                        }
                        else
                        {
                            MessageBox.Show("Bu Tarihte Veri Mevcut");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bilgiler eksik");
            }
        }

        private void cbxMakine_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Makine makine in makineler)
            {
                if (makine.MakineAdı.Equals(cbxMakine.Text))
                {
                    dgwMakine.DataSource = makine.MakineGetir();
                }
            }
        }
    }
}
