using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiveYourNumbersDaddyCalc
{
    public partial class DaddyCalc : Form
    {
        String output;
        int operand1;
        int operand2;
        Random rnd = new Random();
        String opp;
        int month;
        public DaddyCalc()
        {
            InitializeComponent();
        }

        private void DaddyCalc_Load(object sender, EventArgs e)
        {
            output = "0";
            numberarea.Text = "0";
            number0.Text = "0";
            Number1.Text = "1";
            number2.Text = "2";
            number3.Text = "3";
            number4.Text = "4";
            number5.Text = "5";
            number6.Text = "6";
            number7.Text = "7";
            numbrt8.Text = "8";
            number9.Text = "9";

            operand1 = 1;
            operand2 = 2;
            opp = "+";
            Console.WriteLine(1 + 2);
            Console.WriteLine(operand1 + operand2);
        }

        private void Number1_Click(object sender, EventArgs e)
        {
           if(output == "0")
            {
                output = "7";
            } 
           else
            {
                output = output + "7";
            }
            
            numberarea.Text = output;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            

            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

            
        }

        private void number3_Click(object sender, EventArgs e)
        {

            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

        }

        private void number4_Click(object sender, EventArgs e)
        {


            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

        }

        private void number5_Click(object sender, EventArgs e)
        {

            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

        }

        private void number6_Click(object sender, EventArgs e)
        {

            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

        }

        private void number7_Click(object sender, EventArgs e)
        {


            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

        }

        private void numbrt8_Click(object sender, EventArgs e)
        {

            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

        }

        private void number9_Click(object sender, EventArgs e)
        {

            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

        }

        private void number0_Click(object sender, EventArgs e)
        {


            if (output == "0")
            {
                month = rnd.Next(1, 101);
                output = month.ToString();
            }
            else
            {
                month = rnd.Next(1, 101);
                output = output + month.ToString();
            }

            numberarea.Text = output;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            output = "0";
            numberarea.Text = output;
            opp = "";
            operand1 = 0;
            operand2 = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            operand1 = int.Parse(output);
            opp = "+";
            output = "0";
            numberarea.Text = output;
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            
            operand1 = int.Parse(output);
            opp = "-";
            output = "0";
            numberarea.Text = output;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            
            operand1 = int.Parse(output);
            opp = "/";
            output = "0";
            numberarea.Text = output;
        }

        private void muti_Click(object sender, EventArgs e)
        {
            
            operand1 = int.Parse(output);
            opp = "x";
            output = "0";
            numberarea.Text = output;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            int x = 0;
            operand2 = int.Parse(output);

           if (opp == "+")
            {
                

                x = operand1 + operand2;
                

            }
           else if(opp == "-")
            {
                x = operand1 - operand2;
                
            }
           else if(opp == "x")
            {
                x = operand1 * operand2;
                
            }
           else if(opp == "/")
            {
                x = operand1 / operand2;
                
            }
            else
            {
                output = "0";
            }
            output = x.ToString();
            numberarea.Text = output;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "Sexy 😏";
            }
            else
            {
                output = output + "Sexy 😏";
            }

            numberarea.Text = output;
        }

       
    }
}
