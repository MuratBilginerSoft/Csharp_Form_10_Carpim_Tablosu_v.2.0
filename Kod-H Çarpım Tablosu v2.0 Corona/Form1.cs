using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kod_H_Çarpım_Tablosu_v2._0_Corona
{
    public partial class Form1 : Form
    {
        string[] satır = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", };

        string[] sütun = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Label lbl = new Label();
                Label lbl2 = new Label();

                lbl.Name = "lbl" + satır[i];
                lbl.Text = satır[i];
                lbl.Font = new Font("Century Gothic", 12);
                lbl.ForeColor = Color.White;

                lbl2.Name = "lbl2" + sütun[i];
                lbl2.Text = sütun[i];
                lbl2.Font = new Font("Century Gothic", 12);
                lbl2.ForeColor = Color.White;
                tableLayoutPanel1.Controls.Add(lbl);
                tableLayoutPanel2.Controls.Add(lbl2);
            }

            for (int j = 1; j <= 10; j++)
            {
                Label lbl3 = new Label();
                lbl3.Font = new Font("Century Gothic", 12);
                lbl3.ForeColor = Color.White;

                for (int k = 1; k <= 10; k++)
                {
                    Label lbl4 = new Label();
                    lbl4.Name = "lbl3" + (j * k);
                    lbl4.ForeColor = lbl3.ForeColor;
                    lbl4.Font = lbl3.Font;
                    int sonuç = j * k;
                    lbl4.Text = sonuç.ToString();

                    tableLayoutPanel3.Controls.Add(lbl4);
                }
            }
            tableLayoutPanel3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.industryolog.com/");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}