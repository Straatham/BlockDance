using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FormsSideScrollerGame
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPressHomeTitle(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode.Equals(Keys.Enter))
            {
                Form2 Check = new Form2();
                Check.Show();
                Hide();
            }

            if (kea.KeyCode.Equals(Keys.Escape))
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
