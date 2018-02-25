using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mevsime_göre_ayları_listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ilkbahar");
            comboBox1.Items.Add("yaz");
            comboBox1.Items.Add("sonbahar");
            comboBox1.Items.Add("kış");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             listBox1.Items.Clear(); //Her seçimden önce listbox temizleniyor.

            if (comboBox1.SelectedIndex == 0) // İlkbahar seçiliyse
            {
                listBox1.Items.Add("MART");
                listBox1.Items.Add("NİSAN");
                listBox1.Items.Add("MAYIS");
            }
            else if (comboBox1.SelectedIndex == 1) //Yaz seçiliyse
            {
                listBox1.Items.Add("HAZİRAN");
                listBox1.Items.Add("TEMMUZ");
                listBox1.Items.Add("AĞUSTOS");
            }
            else if (comboBox1.SelectedIndex == 2) //Sonbahar seçiliyse
            {
                listBox1.Items.Add("EYLÜL");
                listBox1.Items.Add("EKİM");
                listBox1.Items.Add("KASIM");
            }
            else if (comboBox1.SelectedIndex == 3) //Kış seçiliyse
            {
                listBox1.Items.Add("ARALIK");
                listBox1.Items.Add("OCAK");
                listBox1.Items.Add("ŞUBAT");
            }
        }
    }
}
