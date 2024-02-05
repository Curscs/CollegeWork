namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int num1 = 0, num2 = 0;
        string sign = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void plus_Click(object sender, EventArgs e)
        {
            BtnClicked("+");
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("-");
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("/");
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("*");
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("1");
        }
        private void twoBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("2");
        }
        private void treeBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("3");
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("4");
        }
        private void fiveBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("5");
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("6");
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("7");
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("8");
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("9");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("Clear");
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            BtnClicked("Result");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

        }
        private void zeroBtn_Click(object sender, EventArgs e)
        {

        }
        private void BtnClicked(string input)
        {
            int answer = 0;

            if (int.TryParse(input, out int numInput))
            {
                if (sign == "")
                {
                    num1 += numInput;
                    if (num1 <= 1)
                    {
                        num1 = num1 * 10 + numInput;
                    }
                }
                else
                {
                    num2 += numInput;
                    if (num2 <= 1)
                    {
                        num2 = num2 * 10 + numInput;
                    }
                }
            }

            else
            {
                switch (input)
                {
                    case "+":
                        if (num1 != 0)
                        {
                            if (sign == "")
                            {
                                sign = input;
                            }
                        }
                        break;
                    case "-":
                        if (num1 != 0)
                        {
                            if (sign == "")
                            {
                                sign = input;
                            }
                        }
                        break;
                    case "/":
                        if (num1 != 0)
                        {
                            if (sign == "")
                            {
                                sign = input;
                            }
                        }
                        break;
                    case "*":
                        if (num1 != 0)
                        {
                            if (sign == "")
                            {
                                sign = input;
                            }
                        }
                        break;
                    case "Clear":
                        answer = 0; num1 = 0; num2 = 0; sign = ""; AnswerBox.Text = "";
                        break;
                    case "Result":
                        if (sign != "" || num1 != 0 || num2 != 0)
                        {
                            switch (sign)
                            {
                                case "+":
                                    answer = num1 + num2;
                                    AnswerBox.Text = answer.ToString();
                                    break;
                                case "-":
                                    answer = num1 - num2;
                                    AnswerBox.Text = answer.ToString();
                                    break;
                                case "*":
                                    answer = num1 * num2;
                                    AnswerBox.Text = answer.ToString();
                                    break;
                                case "/":
                                    answer = num1 - num2;
                                    AnswerBox.Text = answer.ToString();
                                    break;
                            }
                        }
                        break;
                }
            }
            if (num1 != 0 && num2 != 0)
            {
                AnswerBox.Text = $"{num1}{sign}{num2}";
            }
            else if (num2 == 0)
            {
                AnswerBox.Text = $"{num1}{sign}";
            }
        }
    }
}
