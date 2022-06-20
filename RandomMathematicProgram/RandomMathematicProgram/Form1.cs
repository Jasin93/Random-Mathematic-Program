using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMathematicProgram
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int num1, num2, result, counter;
        string answer;
        char symbol;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counter = 0;
            CreateCalculation();
            DisplayCalculation();
            DisplayPoints();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckTheAnswer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int GenerateRandomNumber()
        {
            int randomNumber = rand.Next(1, 11);
            return randomNumber;
        }

        char GenerateRandomSymbol()
        {
            char[] operators = { '+', '-', '*', '/' };
            char op = operators[rand.Next(operators.Length)];
            return op;
        }

        void CreateCalculation()
        {
            num1 = GenerateRandomNumber();
            num2 = GenerateRandomNumber();
            symbol = GenerateRandomSymbol();

            if (symbol == '+')
            {
                result = num1 + num2;
            }
            else if(symbol == '-')
            {
                result = num1 - num2;
            }
            else if(symbol == '*')
            {
                result = num1 * num2;
            }
            else if(symbol == '/')
            {
                result = num1 / num2;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void DisplayCalculation()
        {
            //label1.Text = num1 + " " + op.ToString() + " " + num2 + " = ";
            label1.Text = num1 + " " + symbol + " "+ num2 + " ="; 
        }

        void CheckTheAnswer()
        {
            answer = textBox1.Text;
            if (answer == result.ToString())
            {
                CreateCalculation();
                AddPoints();
                DisplayCalculation();
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                DisplayPoints();
            }
            else
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        void AddPoints()
        {
            counter++;
        }

        void DisplayPoints()
        {
            label2.Text = "Your score is: " + counter;
        }



    }
}
