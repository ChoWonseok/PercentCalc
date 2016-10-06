using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercentCalc
{
    public partial class 퍼센트계산기 : Form
    {
        public 퍼센트계산기()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void onlyDigitKeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-' ))
            {
                e.Handled = true;
            }
        }

        private void totalWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void c1_calc(object sender, MouseEventArgs e)
        {

            int iTotalWidth = digitValidation(totalWidth.Text);
            int iTotalHeight = digitValidation(totalHeight.Text);
            int iWidth = digitValidation(width.Text);

            int iResultData = 0;

            if(iTotalWidth > 0 && iTotalHeight > 0)
            {
                iTo
            }
            
        }

        private int digitValidation(string str)
        {
            int iTemp = 0;
            if(str != "")
            {
                iTemp = int.Parse(str);
            }
            return iTemp;
        }
    }
}
