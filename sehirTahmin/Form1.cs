using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sehirTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            foreach(Control item in groupBox1.Controls)
            {
                if(item is Label)
                {
                    Label label = item as Label;
                    if(label.Text.ToUpper()==textBox1.Text.ToUpper())
                    {
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;

                    }

                }

            }
           
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        string[] sehirler = { "istanbul", "ankara", "adana", "mersin", "samsun", "hatay", "van", "antalya", "bursa", "antalya" };

        public void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int no = rnd.Next(0, sehirler.Length);
            label1.Text = sehirler[no].ToString();
            groupBox1.Controls.Clear();

            for (int i = 0; i < sehirler[no].Length; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(40 * (i + 1), 30);
                lbl.Size = new Size(30, 30);
                lbl.BackColor = Color.Red;
                lbl.Text = "lbl" + i.ToString();
                lbl.Name = "lbl" + i.ToString();
                //lbl.ForeColor = Color.Red;
                char[] kelimeHarfleri = sehirler[no].ToCharArray();
                lbl.Text = kelimeHarfleri[i].ToString();
                groupBox1.Controls.Add(lbl);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
