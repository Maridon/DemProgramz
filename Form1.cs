using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Conversion_Calculator
{
     
    
    public partial class Form1 : Form
    {

        double userInput = 0;
        double _finalAnswer = 0;
        double GALLON_TOTAL_PER_POUND = 8.33;
        double GRAMS_TOTAL_PER_POUND = 453.592;
        double GRAMS_TOTAL_PER_OUNCE = 28.349;
        double KG_TOTAL_PER_POUND = 0.453;
        double LITERS_TOTAL_PER_GAL = 0.264172;
        double GAL_TOTAL_PER_LITER = 3.78541;




        public Form1()
        {
            InitializeComponent();
            tbUserInput.Select();
           
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string.IsNullOrWhiteSpace(tbUserInput.Text);// Is this the problem?
            try
            {
            userInput = Convert.ToDouble(tbUserInput.Text);//Assigns userInput to whatever is typed in the textbox. Turns the value in the textbox as a double.
            }
            catch
            {
                tbUserInput.Clear();   
             }
           
       
        }
        
      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Lbs_to_gal_Click(object sender, EventArgs e)
        {
            _finalAnswer = userInput / GALLON_TOTAL_PER_POUND;
            lblTotalDisplay.Text = _finalAnswer.ToString("#.## Gallon(s)"); // ("#.##") rounds the output to 2 decimal places
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }

       

        private void btn_gal_to_Lbs_Click(object sender, EventArgs e)
        {
            _finalAnswer = userInput * GALLON_TOTAL_PER_POUND;
            lblTotalDisplay.Text = _finalAnswer.ToString("#.## Pound(s)"); 
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }

        private void btn_Lbs_to_g_Click(object sender, EventArgs e)
        {
            _finalAnswer = userInput * GRAMS_TOTAL_PER_POUND;
            lblTotalDisplay.Text = _finalAnswer.ToString("#.## Gram(s)"); 
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _finalAnswer = userInput / GRAMS_TOTAL_PER_POUND;
            lblTotalDisplay.Text = _finalAnswer.ToString("#.## Pound(s)"); 
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }

        private void btn_oz_to_g_Click(object sender, EventArgs e)
        {
            _finalAnswer = userInput * GRAMS_TOTAL_PER_OUNCE;
            lblTotalDisplay.Text = _finalAnswer.ToString("#.### Gram(s)"); 
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }

        private void btn_g_to_oz_Click(object sender, EventArgs e)
        {
            _finalAnswer = userInput / GRAMS_TOTAL_PER_OUNCE;
            lblTotalDisplay.Text = _finalAnswer.ToString("#.## Ounce(s)"); 
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }

        private void btn_Lbs_to_Kg_Click(object sender, EventArgs e)
        {
            _finalAnswer = userInput * KG_TOTAL_PER_POUND;
            lblTotalDisplay.Text = _finalAnswer.ToString("#.## Kilograms(s)"); 
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }

        private void btn_Kg_to_Lbs_Click(object sender, EventArgs e)
        {
            _finalAnswer = userInput / KG_TOTAL_PER_POUND;
            lblTotalDisplay.Text = _finalAnswer.ToString("#.## Pound(s)"); 
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbUserInput.Clear();
            lblConversionTitle.Hide();
            lblTotalDisplay.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btn L_TO_GAL
            _finalAnswer = userInput / GAL_TOTAL_PER_LITER;
            lblTotalDisplay.Text = _finalAnswer.ToString("# Gallon(s)");
            lblConversionTitle.Show();
            lblTotalDisplay.Show();
        }
    }
}
