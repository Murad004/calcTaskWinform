using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                if (resultTxtBox.Text == String.Empty)
                {
                    resultTxtBox.Text = bt.Text.ToString();
                }
                else
                {
                    resultTxtBox.Text = resultTxtBox.Text + bt.Text.ToString();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (resultTxtBox.Text.Length > 0)
            {
                resultTxtBox.Text = resultTxtBox.Text.Remove(resultTxtBox.Text.Length - 1, 1);
                resTxtBox.Text = resTxtBox.Text.Remove(resTxtBox.Text.Length - 1, 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            resultTxtBox.Text = String.Empty;
            resTxtBox.Text = String.Empty;
        }
        string optext;
        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                optext = bt.Text.ToString();
                resultTxtBox.Text = resultTxtBox.Text + bt.Text.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (optext)
            {
                case "+":
                    {
                        var num1 = double.Parse(resultTxtBox.Text.Split('+')[0]);
                        var num2 = double.Parse(resultTxtBox.Text.Split('+')[1]);
                        var result = num1 + num2;
                        resTxtBox.Text = result.ToString();

                        break;
                    }
                case "-":
                    {
                        var num1 = double.Parse(resultTxtBox.Text.Split('-')[0]);
                        var num2 = double.Parse(resultTxtBox.Text.Split('-')[1]);
                        var result = num1 - num2;
                        resTxtBox.Text = result.ToString();

                        break;
                    }
                case "/":
                    {
                        var num1 = double.Parse(resultTxtBox.Text.Split('/')[0]);
                        var num2 = double.Parse(resultTxtBox.Text.Split('/')[1]);
                        if (num1 > 0)
                        {
                            var result = num1 / num2;
                            resTxtBox.Text = result.ToString();
                        }
                        else
                        {
                            resTxtBox.Text = String.Empty;
                        }

                        break;
                    }
                case "*":
                    {
                        var num1 = double.Parse(resultTxtBox.Text.Split('*')[0]);
                        var num2 = double.Parse(resultTxtBox.Text.Split('*')[1]);
                        var result = num1 * num2;
                        resTxtBox.Text = result.ToString();
                        break;
                    }
            }
        }
    }
}
