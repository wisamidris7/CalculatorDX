using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorDX
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sb_buttonadd(object sender, EventArgs e)
        {
            try
            {
                textEdit1.Text += ((SimpleButton)sender).Text;

            }
            catch (Exception)
            {

            }
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                textEdit1.Text = Eval(textEdit1.Text).ToString();
            }
            catch (Exception)
            {

                textEdit1.Text = "";
            }
        }
        public Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        private void sb_removeone(object sender, EventArgs e)
        {
            try
            {
                textEdit1.Text = textEdit1.Text.Substring(0, textEdit1.Text.Length - 1);
            }
            catch (Exception)
            {

            }
        }
    }
}
