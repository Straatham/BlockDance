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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public void btn_BackToMenu_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            Hide();
        }

        public void btn_lvl1_Click(object sender, EventArgs e)
        {
            Level_1 Check = new Level_1();
            Check.Show();
            Hide();
        }

        public void btn_lvl2_Click(object sender, EventArgs e)
        {
            Level_2 Check = new Level_2();
            Check.Show();
            Hide();
        }

        private void btn_lvl3_Click(object sender, EventArgs e)
        {
            Level_3 Check = new Level_3();
            Check.Show();
            Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
