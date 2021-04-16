using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsSideScrollerGame
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Do you really want to quit?";
            string message = "Quit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(title, message, buttons, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

            
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            Form3 Check = new Form3();
            Check.Show();
            Hide();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Form4 Check = new Form4();
            Check.Show();
            Hide();
        }

        private void btn_PlayerEdit_Click(object sender, EventArgs e)
        {
            Form5 Check = new Form5();
            Check.Show();
            Hide();
        }

        private void btn_LvlScreen_Click(object sender, EventArgs e)
        {
            Form7 Check = new Form7();
            Check.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
