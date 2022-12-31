using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            //Soruların ve Cevapların sırayla gelmesi.
        string[] Sorular = {"Favori futbolcun", " En sevdiğin araba markası", "Ziyaret etmek istediğin ülkeyi seç", "Favori takımın", "Yaşamak istediğin yüzyıl", "Sorular BİTTİ uygulamayı TERKET !!!" };
        static int s = 0;

        string[] CevapA = { "Messi", "Mercedes Maybach", "İngiltere", "zonguldak kömürleri", "100-200'ler", "TERKET" };
        static int a = 0;

        string[] CevapB = { "PEnaldo", "BMW M3 2016 Sport", "İzlanda", "Beşiktaş", "1500'ler", "TERKET" };
        static int b = 0;

        string[] CevapC = { "Sergen Yalçın", " Range Rover", "İspanya", "giresun spor", "1800'ler", "TERKET" };
        static int c = 0;


        string[] CevapD = { "Cenk tosun", " McLaren P1 ", "İtalya", "erdek SK", "2000'ler", "TERKET" };
        static int d = 0;
        //Soruların ve Cevapların sırayla gelmesi.

        private void button6_Click(object sender, EventArgs e)
        {
            
            
            
                if (radioButtonA.Checked || radioButtonB.Checked || radioButtonC.Checked || radioButtonD.Checked)
                {

                    soru.Text = Sorular[s];
                    s = (s + 1);

                    radioButtonA.Text = CevapA[a];
                        a = (a + 1);

                    radioButtonB.Text = CevapB[b];
                        b = (b + 1);

                    radioButtonC.Text = CevapC[c];
                        c = (c + 1);

                    radioButtonD.Text = CevapD[d];
                        d = (d + 1);
            }
            else
            {
                MessageBox.Show("Cevap seçiniz.");  //Soru kontrol fonksiyonu.
            }

            

                //Skorun arttırılması.
            var curr = 0;
            if (int.TryParse(sayac.Text, out curr))
                curr++;
            sayac.Text = curr.ToString();
            //Skorun arttırılması.

        }
    }
}