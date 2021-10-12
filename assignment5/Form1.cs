using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace assignment5
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {

            double firstNumber = int.Parse(Number1InputTxt.Text);
            double secondNumber = int.Parse(Number2InputTxt.Text);

            double result = firstNumber + secondNumber;
            ResultLbl.Text = ($"{result}");
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            double firstNumber = int.Parse(Number1InputTxt.Text);
            double secondNumber = int.Parse(Number2InputTxt.Text);

            double result = firstNumber - secondNumber;
            ResultLbl.Text = ($"{result}");
        }

        private void KeerBtn_Click(object sender, EventArgs e)
        {
            double firstNumber = int.Parse(Number1InputTxt.Text);
            double secondNumber = int.Parse(Number2InputTxt.Text);

            double result = firstNumber * secondNumber;
            ResultLbl.Text = ($"{result}");
        }

        private void DelenBtn_Click(object sender, EventArgs e)
        {
            double firstNumber = int.Parse(Number1InputTxt.Text);
            double secondNumber = int.Parse(Number2InputTxt.Text);

            double result = firstNumber / secondNumber;
            ResultLbl.Text = ($"{result}");
        }
    }
}
