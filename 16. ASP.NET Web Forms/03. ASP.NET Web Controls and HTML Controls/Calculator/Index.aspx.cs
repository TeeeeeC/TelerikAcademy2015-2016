using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Index : System.Web.UI.Page
    {
        private static long firstNumber = 0;
        private static long secondNumber = 0;
        private static string sign;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Btn_Command(object sender, CommandEventArgs e)
        {
            long num = 0;
            if(long.TryParse(e.CommandName, out num))
            {
                this.result.Text += num;
            }
            else if(e.CommandName == "+" || e.CommandName == "-"
                || e.CommandName == "/" || e.CommandName == "*")
            {
                long.TryParse(this.result.Text, out firstNumber);
                this.firstNum.Text = this.result.Text;
                this.result.Text = string.Empty;
                sign = e.CommandName;
                this.@operator.Text = sign;
            }
            else if(e.CommandName == "Clear")
            {
                sign = string.Empty;
                this.result.Text = string.Empty;
                this.@operator.Text = string.Empty;
                this.firstNum.Text = string.Empty;
                this.secondNum.Text = string.Empty;
            }
            else if (e.CommandName == "Sqrt")
            {
                sign = string.Empty;
                long.TryParse(this.result.Text, out firstNumber);
                this.result.Text = (Math.Sqrt(firstNumber)).ToString();
                this.firstNum.Text = firstNumber.ToString();
            }
            else if(e.CommandName == "=")
            {
                if(this.result.Text == string.Empty)
                {
                    return;
                }

                this.secondNum.Text = this.result.Text;
                long.TryParse(this.result.Text, out secondNumber);
                switch (sign)
                {
                    case "+":
                        this.result.Text = (firstNumber + secondNumber).ToString();
                        break;
                    case "-":
                        this.result.Text = (firstNumber - secondNumber).ToString();
                        break;
                    case "*":
                        this.result.Text = (firstNumber * secondNumber).ToString();
                        break;
                    case "/":
                        this.result.Text = (firstNumber / secondNumber).ToString();
                        break;
                }
                long.TryParse(this.result.Text, out firstNumber);
            }
        }
    }
}