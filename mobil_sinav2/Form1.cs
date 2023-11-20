using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobil_sinav2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Doldur(comboBox1);
            Doldur(comboBox2);
            Doldur(comboBox3);


        }
        private void Doldur(ComboBox comboBox)
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBox.Items.Add(i);
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            CheckBox[] checkBoxlar = new CheckBox[12]; // CheckBox sayısına göre uygun boyutta bir dizi oluşturuluyor
            double[] yemekFiyatlari = { 10.0, 15.0, 20.0, 25.0 , 21.0, 16.0, 22.0, 41.0 , 16.0, 14.0, 7.0, 2.0 , 8.0, 31.0, 9.0, 23.0 }; // Her bir yemeğin fiyatını tutan dizi

            // CheckBox'ları diziye ekleme
            checkBoxlar[0] = checkBox1;
            checkBoxlar[1] = checkBox2;
            checkBoxlar[2] = checkBox3;
            checkBoxlar[3] = checkBox4;
            checkBoxlar[4] = checkBox5;
            checkBoxlar[5] = checkBox6;
            checkBoxlar[6] = checkBox7;
            checkBoxlar[7] = checkBox8;
            checkBoxlar[8] = checkBox9;
            checkBoxlar[9] = checkBox10;
            checkBoxlar[10] = checkBox11;
            checkBoxlar[11] = checkBox12;

            double toplamFiyat = 0;

            // ComboBox'tan seçilen adet değerini al
            int secilenAdet = Convert.ToInt32(comboBox1.SelectedItem);

            // CheckBox'ların durumlarını kontrol ederek fiyatları toplama işlemi ve ListBox'a yazma işlemi
            for (int i = 0; i < checkBoxlar.Length; i++)
            {
                if (checkBoxlar[i].Checked)
                {
                    double urunFiyati = yemekFiyatlari[i]; // Yemeğin fiyatı
                    double toplamUrunFiyati = urunFiyati * secilenAdet; // Yemeğin toplam fiyatı (fiyat * adet)

                    toplamFiyat += toplamUrunFiyati; // Toplam fiyata ekle

                    // ListBox'a yemeğin adeti ve fiyatını ekle
                    listBox1.Items.Clear();

                    listBox1.Items.Add($"Yemek {i + 1}: Adet: {secilenAdet}, Fiyat: {toplamUrunFiyati}");
                }
            }
            int secilenAdet2 = Convert.ToInt32(comboBox2.SelectedItem);

            // CheckBox'ların durumlarını kontrol ederek fiyatları toplama işlemi ve ListBox'a yazma işlemi
            for (int i = 0; i < checkBoxlar.Length; i++)
            {
                if (checkBoxlar[i].Checked)
                {
                    double urunFiyati = yemekFiyatlari[i]; // Yemeğin fiyatı
                    double toplamUrunFiyati2 = urunFiyati * secilenAdet2; // Yemeğin toplam fiyatı (fiyat * adet)

                    toplamFiyat += toplamUrunFiyati2; // Toplam fiyata ekle

                    // ListBox'a yemeğin adeti ve fiyatını ekle

                    listBox1.Items.Add($"Yemek {i + 1}: Adet: {secilenAdet2}, Fiyat: {toplamUrunFiyati2}");
                }
            }
            int secilenAdet3 = Convert.ToInt32(comboBox1.SelectedItem);

            // CheckBox'ların durumlarını kontrol ederek fiyatları toplama işlemi ve ListBox'a yazma işlemi
            for (int i = 0; i < checkBoxlar.Length; i++)
            {
                if (checkBoxlar[i].Checked)
                {
                    double urunFiyati = yemekFiyatlari[i]; // Yemeğin fiyatı
                    double toplamUrunFiyati3 = urunFiyati * secilenAdet3; // Yemeğin toplam fiyatı (fiyat * adet)

                    toplamFiyat += toplamUrunFiyati3; // Toplam fiyata ekle

                    // ListBox'a yemeğin adeti ve fiyatını ekle
                    listBox1.Items.Add($"Yemek {i + 1}: Adet: {secilenAdet3}, Fiyat: {toplamUrunFiyati3}");
                }
            }

            // Toplam fiyatı sonuç label'ına yaz
            
            label1.Text = "Toplam Fiyat: " + toplamFiyat.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
