using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9___1_ile_50_arasindaki_asal_sayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = null;
            int j;
            for (int i = 2; i < 50; i++)
            {
                for (j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }

                }

                if (i == j)
                {
                        message += i.ToString() + " ";
                }
            }

            MessageBox.Show(message);
        }
    }
}
