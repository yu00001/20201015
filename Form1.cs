using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                string input_str = TBimput.Text;
                int input_int = int.Parse(input_str);
                int randomNum = new Random().Next(3);

                if (randomNum==input_int)
                MessageBox.Show($"尼好棒", ":D", MessageBoxButtons.OK);
                else 
                MessageBox.Show($":)", "RandomNum", MessageBoxButtons.OK);

            }
            catch (Exception)
            {
                //錯誤提示
                MessageBox.Show($"不要亂輸入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }


        }

        private void TBimput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
