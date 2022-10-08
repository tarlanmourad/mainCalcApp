using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainCalcApp
{
    public partial class frmCalc : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed)) textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBox_Result.Text.Contains(",")) textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length > 0) textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1, 1);

            if (textBox_Result.Text == "") textBox_Result.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operationPerformed)
                {
                    case "+":
                        textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    case "-":
                        textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    case "*":
                        textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    case "/":
                        if (Double.Parse(textBox_Result.Text) == 0)
                        {
                            MessageBox.Show("Divison by zero!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            textBox_Result.Text = "0";
                            labelCurrentOperation.Text = "";
                            break;
                        }
                        textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    default:
                        break;
                }
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = "";
            }

            catch
            {
                MessageBox.Show("Exception case has occured!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        #region useless part
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
