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
    public partial class PercentCalc : Form
    {
        public PercentCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onlyDigitKeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-' ))
            {
                e.Handled = true;
            }
        }

        private float[] calcPercent(float numerator, float denominator)
        {
            float[] result = { 0, 0 };

            if (numerator > 0 && denominator > 0)
            {
                result[0] = numerator / denominator;
                result[1] = (numerator / denominator) * 100;
            }
            
            return result;            
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

        private String makeTag()
        {
            String strWidthPercent = widthPercent.Text;
            String strHeightPercent = heightPercent.Text;
            String strTopPercent = topPercent.Text;
            String strLeftPercent = leftPercent.Text;

            String strTag = "width:" + strWidthPercent + "%; height:" + strHeightPercent + "%; top: " + strTopPercent + "%; left:" + strLeftPercent + "%";

            return strTag;
        }

        private void c1_calc(object sender, MouseEventArgs e)
        {
            int iTotalWidth = digitValidation(totalWidth.Text);
            int iWidth = digitValidation(width.Text);

            float[] iResultData = { 0, 0 };

            iResultData = calcPercent(iWidth, iTotalWidth);

            if (iResultData[0] > 0 && iResultData[1] > 0)
            {
                widthCal.Text = iResultData[0].ToString();
                widthPercent.Text = iResultData[1].ToString();
            }
        }

        private void c2_calc(object sender, EventArgs e)
        {
            int iTotalHeight = digitValidation(totalHeight.Text);
            int iHeight = digitValidation(height.Text);

            float[] iResultData = { 0, 0 };

            iResultData = calcPercent(iHeight, iTotalHeight);

            if (iResultData[0] > 0 && iResultData[1] > 0)
            {
                heightCal.Text = iResultData[0].ToString();
                heightPercent.Text = iResultData[1].ToString();
            }
        }

        private void c3_calc(object sender, EventArgs e)
        {
            int iTotalHeight = digitValidation(totalHeight.Text);
            int iTop = digitValidation(top.Text);

            float[] iResultData = { 0, 0 };

            iResultData = calcPercent(iTop, iTotalHeight);

            if (iResultData[0] > 0 && iResultData[1] > 0)
            {
                topCal.Text = iResultData[0].ToString();
                topPercent.Text = iResultData[1].ToString();
            }
        }

        private void c4_calc(object sender, EventArgs e)
        {
            int iTotalWidth = digitValidation(totalWidth.Text);
            int iLeft = digitValidation(left.Text);

            float[] iResultData = { 0, 0 };

            iResultData = calcPercent(iLeft, iTotalWidth);

            if (iResultData[0] > 0 && iResultData[1] > 0)
            {
                leftCal.Text = iResultData[0].ToString();
                leftPercent.Text = iResultData[1].ToString();
            }
        }

        private void makeTagBtn_click(object sender, EventArgs e)
        {

            tagSource.Text = makeTag();
        }

        private void tagCopyBtn_click(object sender, EventArgs e)
        {
            String strTag = makeTag();
            if(strTag != "") Clipboard.SetText(makeTag());

        }

        private void totalWidth_keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                totalHeight.Focus();
            }
        }

        private void totalHeight_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                width.Focus();
            }
        }

        private void width_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                height.Focus();
                c1_calc.PerformClick();
            }
        }
    }
}
