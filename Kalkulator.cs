using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kalkulator : Form
    {
        double vrijednost = 0;
        string operacija = "";
        bool operacija_stisnita = false;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ( (rezultat.Text == "0") || (operacija_stisnita) )
            {
                rezultat.Clear();
            }

            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if(!rezultat.Text.Contains(","))
                    rezultat.Text = rezultat.Text + b.Text;

            }
            else
            {
                rezultat.Text = rezultat.Text + b.Text;
            }
           
        }

        private void bClearE_Click(object sender, EventArgs e)
        {
            rezultat.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacija = b.Text;
            vrijednost = double.Parse(rezultat.Text);
            operacija_stisnita = true;
        }

        private void bJednako_Click(object sender, EventArgs e)
        {
            switch (operacija)
            {
                case "+":
                    rezultat.Text = (vrijednost + double.Parse(rezultat.Text)).ToString();
                    break;
                case "-":
                    rezultat.Text = (vrijednost - double.Parse(rezultat.Text)).ToString();
                    break;
                case "/":
                    rezultat.Text = (vrijednost / double.Parse(rezultat.Text)).ToString();
                    break;
                case "*":
                    rezultat.Text = (vrijednost * double.Parse(rezultat.Text)).ToString();
                    break;
       
                default:
                    break;

            }
            operacija_stisnita = false;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            rezultat.Clear();
            vrijednost = 0;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double num = double.Parse(rezultat.Text);
            num = Math.Cos(num);
            rezultat.Text = System.Convert.ToString(num);

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double num = double.Parse(rezultat.Text);
            num = Math.Sin(num);
            rezultat.Text = System.Convert.ToString(num);
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            double broj = double.Parse(rezultat.Text);
            rezultat.Text = (Math.Exp(broj)).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(rezultat.Text);
            ilog = Math.Log10(ilog);
            rezultat.Text = System.Convert.ToString(ilog);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double num= double.Parse(rezultat.Text);
            num = Math.Sqrt(num);
            rezultat.Text = System.Convert.ToString(num);
        }

        private void rezultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}