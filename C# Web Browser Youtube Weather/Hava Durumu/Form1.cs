using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hava_Durumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kod;

            kod = String.Format("<img src=\"http://www.mgm.gov.tr/sunum/sondurum-show-2.aspx?m={0}&rC=111&rZ=fff\" style=\"width:140px; height:100px;\" alt=\"{1}\" />", listBox1.SelectedItem.ToString(), listBox1.SelectedItem.ToString());
            
            webBrowser1.DocumentText = kod;

            textBox1.Text = kod;
        }
    }
}
