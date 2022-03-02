using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERNET_CAFE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
       
            int masaNo, toplamSure, ucret;

            masaNo = Convert.ToInt32(txtMasa.Text);
            toplamSure = Convert.ToInt32(txtSure.Text);
            ucret = 5 * toplamSure;

            if(masaNo == 1)
            {

                MessageBox.Show($"{masaNo} NUMARALI MASA ÖDENECEK TUTAR {ucret} "); 
            }
            else if(masaNo == 2)
            {

                MessageBox.Show($"{masaNo} NUMARALI MASA ÖDENECEK TUTAR {ucret} ");
            }
            else if (masaNo == 3)
            {

                MessageBox.Show($"{masaNo} NUMARALI MASA ÖDENECEK TUTAR {ucret} ");
            }
            else if (masaNo == 4)
            {

                MessageBox.Show($"{masaNo} NUMARALI MASA ÖDENECEK TUTAR {ucret} ");
            }
            else if (masaNo == 5)
            {

                MessageBox.Show($"{masaNo} NUMARALI MASA ÖDENECEK TUTAR {ucret} ");
            }
            else if (masaNo == 6)
            {

                MessageBox.Show($"{masaNo} NUMARALI MASA ÖDENECEK TUTAR {ucret} ");
            }
            else
            {
                
                MessageBox.Show($"GEÇERLİ BİR MASA NUMARASI GİRİNİZ ");
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
