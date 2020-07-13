using System;
using System.Windows.Forms;
using Calculator.OneArgClasses;
using Calculator.TwoArgsClasses;

namespace Calculator
{
    
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber, result;
        string Operation, op1;

        public Form1()
        {
            InitializeComponent();
        }

        // support input from keyboard
        /// <summary>
        /// mention of the main operations in the text cause them by this function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            if (textBox1.Text.Length >= 1)
            {
                string a = Convert.ToString(textBox1.Text[textBox1.Text.Length - 1]);
                switch (a)
                {
                    case ("*"):
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                        operChoose(mult, e);
                        break;
                    case ("/"):
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                        operChoose(div, e);
                        break;
                    case ("+"):
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                        operChoose(plus, e);
                        break;                  
                }
                if (a == "*" || a == "/" || a == "+" || a == "-")
                { }
                else { 
                    if (!Char.IsDigit(Convert.ToChar(textBox1.Text[textBox1.Text.Length - 1])))
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                        textBox1.SelectionStart = textBox1.Text.Length;
                    }
                }
            }
        }
        
            /// <summary>
            /// Processing clicks on buttons
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void buttonsALL(object sender, EventArgs e) {
            switch (((Button)sender).Name)
            {
                case "button10":
                    _ = ((textBox1.Text == "0")&&(textBox1.Text != null)) ? (textBox1.Text = "0") : (textBox1.Text = textBox1.Text + "0");
                    break;
                case "button1":
                   _= ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "1") : (textBox1.Text = textBox1.Text + "1");          
                    break;
                case "button2":
                    _ = ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "2") : (textBox1.Text = textBox1.Text + "2");
                    break;
                case "button3":
                    _ = ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "3") : (textBox1.Text = textBox1.Text + "3");
                    break;
                case "button4":
                    _ = ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "4") : (textBox1.Text = textBox1.Text + "4");
                    break;
                case "button5":
                    _ = ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "5") : (textBox1.Text = textBox1.Text + "5");
                    break;
                case "button6":
                    _ = ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "6") : (textBox1.Text = textBox1.Text + "6");
                    break;
                case "button7":
                    _ = ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "7") : (textBox1.Text = textBox1.Text + "7");
                    break;
                case "button8":
                    _ = ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "8") : (textBox1.Text = textBox1.Text + "8");
                    break;
                case "button9":
                    _ = ((textBox1.Text == "0") && (textBox1.Text != null)) ? (textBox1.Text = "9") : (textBox1.Text = textBox1.Text + "9");
                    break;         
            }
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        // clear textbox1 after input


        /// <summary>
        /// Fill textBox after input firstNumber and save First Number
        /// </summary>
        void oper1()
        {
            if (textBox1.Text.Length > 0)
            {
                textBox2.Text = textBox1.Text;
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox3.Text = null;
            }
            textBox1.Text = null;
            textBox1.Focus();
            
            switch (Operation)
            {
                case ("mult"):
                    op1 = "*";
                    break;
                case ("div"):
                    op1 = "/";
                    break;
                case ("plus"):
                    op1 = "+";
                    break;
                case ("minus"):
                    op1 = "-";
                    break;
                case ("sqrt"):
                    op1 = "sqrt";
                    break;
                case ("exp"):
                    op1 = "exp";
                    break;
                case ("pow"):
                    op1 = "^";
                    break;
            }
            textBox4.Text = op1;
        }
        /// <summary>
        /// frequently used operations were separated in function
        /// </summary>
        void def1()
        {
            textBox1.Text = Convert.ToString(result);
            firstNumber = result;
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;

        }
        void def2()
        {
            IOneArgCalculator calculator = OneArgFactory.CreateCalculator(Operation);
            result = calculator.Calculate(firstNumber);
            textBox2.Text = textBox1.Text;
            textBox1.Text = Convert.ToString(result);
            textBox4.Text = Operation;
        }
        /// <summary>
        /// processing choose operation and function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operChoose(object sender, EventArgs e) // two args
        {
            Operation = ((Button)sender).Name; 
            oper1();
        }
        private void funcChoose(object sender, EventArgs e) // one args
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            Operation = ((Button)sender).Name;
            def2();           
        }

   
        // Write result in textBox1 and make the result the first number to continue calculations
        

        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void textClear(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = null;
                textBox1.Focus();
            }
            else
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        /// <summary>
        ///  processing a click on "equal" button where is the main choice of further operations and functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) // textBox is not empty
            {
                secondNumber = Convert.ToDouble(textBox1.Text);
                textBox3.Text = textBox1.Text;
                ITwoArgCalculator calculator = TwoArgFactory.CreateCalculator(Operation);
                result = calculator.Calculate(firstNumber, secondNumber);
                def1();
            }
            
            textBox1.Focus();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
