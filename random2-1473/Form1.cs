using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random2_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnÜret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbNotlar.Items.Clear();
            for (int i = 0; i <= 14; i++)
            {
                int puan = rnd.Next(0, 100);
                lbNotlar.Items.Add(puan);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kaldi = 0, duz = 0, tesekkur = 0, tesekur = 0, taktir = 0;

            for (int i = 0; i < lbNotlar.Items.Count; i++)
            {
                int puan = Convert.ToInt32(lbNotlar.Items[i]);// i. sıradaki notu alır.

                if (puan < 50)
                {
                    kaldi++;
                }
                else if (puan >= 50 && puan < 80)
                {
                    duz++;
                }
                else if (puan >= 80 && puan < 90)
                {
                    tesekkur++;
                }
                else
                {
                    taktir++;
                }
            }
            //doldur
            lblKalan.Text = "kalan öğrençi sayısı:" + Convert.ToString(kaldi);
            lblGecen.Text = "düz geçen öğrençi " + Convert.ToString(duz);
            lblTaktir.Text = "taktir alan öğrençi" + Convert.ToString(taktir);
            lblTesekkur .Text = "tesekkur alan öğrençi:" + Convert.ToString(tesekkur);
        }
}   }