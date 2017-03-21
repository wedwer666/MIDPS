using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Calc M;

        int tmp1; 

        public Form1()
        {
            ComponentNou();

            M = new Calc();

            tmp.Text = "0";
        }

       
        private void Butonuldecuratare(object sender, EventArgs e)
        {
            tmp.Text = "0";

            M.CalculatorMasaClear();
            FreeButtons();

            tmp1 = 0;
        }
        private void Butonuldeplusminus(object sender, EventArgs e)
        {
            if (tmp.Text[0] == '-')
                tmp.Text = tmp.Text.Remove(0, 1);
            else
                tmp.Text = "-" + tmp.Text;
        }

    
          //butonul 0 de apasare
        private void Butonul0(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "0";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "0";

         
        }
          // butonul 1 de apasare !!!
        private void Butonul1(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "1";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "1";

      
        }
          // butonul 2 de apasare
          private void Butonul2(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "2";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "2";

       
        }
          // butonul 3 de apasare
          private void Butonul3(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "3";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "3";

          
        }

        private void Butonul4(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "4";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "4";

         
        }

        private void Butonul5(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "5";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "5";

       
        }

        private void Butonul6(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "6";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "6";

     
        }

        private void Butonul7(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "7";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "7";

          
        }

        private void Butonul8(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "8";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "8";

         
        }

        private void Butonul9(object sender, EventArgs e)
        {
               if (tmp.Text == "0")
                    tmp.Text = "9";
               else if (tmp.Text.Length < 22)
                    tmp.Text += "9";

        }

          
        private void ButonulDeApasare(object sender, EventArgs e)
        {
            if (!ButonulDeMultiplic.Enabled)
                tmp.Text = M.Multiplicare(Convert.ToDouble(tmp.Text)).ToString();

            if (!ButonulDeImpar.Enabled)
                tmp.Text = M.Impartire(Convert.ToDouble(tmp.Text)).ToString();

            if (!buttonPlus.Enabled)
                tmp.Text = M.Adunare(Convert.ToDouble(tmp.Text)).ToString();

            if (!buttonMinus.Enabled)
                tmp.Text = M.Scadere(Convert.ToDouble(tmp.Text)).ToString();
            
           // if (!buttonDegreeY.Enabled)
               // tmp.Text = M.DegreeY(Convert.ToDouble(tmp.Text)).ToString();

            M.CalculatorMasaClear();
            FreeButtons();

            tmp1 = 0;
        }
         //butonul de inmultire :)
        private void ButonulDeMultiplicare(object sender, EventArgs e)
        {
               FreeButtons();
               if (ApasamButon())
            {
                    if (tmp.Text != "0")
                         M.CalculatorMasa(Convert.ToDouble(tmp.Text));

                ButonulDeMultiplic.Enabled = false;

                tmp.Text = "0";
            }
        }

        // butonul de div :)
        private void ButonulDeImpartire(object sender, EventArgs e)
        {
               FreeButtons();
               if (ApasamButon())
            {
                    if (tmp.Text != "0")
                         M.CalculatorMasa(Convert.ToDouble(tmp.Text));

                ButonulDeImpar.Enabled = false;

                tmp.Text = "0";
            }
        }

         // butonul care trasforma semnul din fata numarului in plus
        private void ButonulPlusInFata(object sender, EventArgs e)
        {
               FreeButtons();
               if (ApasamButon())
            {
                    if (tmp.Text != "0")
                         M.CalculatorMasa(Convert.ToDouble(tmp.Text));

                buttonPlus.Enabled = false;

                tmp.Text = "0";
            }
        }

        // schimbarea semnului in fata numarului in minus
        private void ButonulMinusInFata(object sender, EventArgs e)
        {
               FreeButtons();
               if (ApasamButon())
            {
                    if (tmp.Text != "0")
                         M.CalculatorMasa(Convert.ToDouble(tmp.Text));

                buttonMinus.Enabled = false;

                tmp.Text = "0";
            }
        }
        private void ButonulRadical(object sender, EventArgs e)
        {
            if (ApasamButon())
            {
                M.CalculatorMasa(Convert.ToDouble(tmp.Text));

                tmp.Text = M.Radicalx().ToString();

                M.CalculatorMasaClear();
                FreeButtons();
            }
        }

        //Butonul ce afiseza radacina unui numar apasat
        private void ButonulRicareLaPutere(object sender, EventArgs e)
        {
            if (ApasamButon())
            {
                M.CalculatorMasa(Convert.ToDouble(tmp.Text));

                tmp.Text = M.Ridicarepatrat().ToString();

                M.CalculatorMasaClear();
                FreeButtons();
            }
        }
   
          // functie care verifica daca au fost apasate mai mult de 2 butoane in acelasi moment

          private bool ApasamButon()
          {
               if (!ButonulDeMultiplic.Enabled)
                    return false;

               if (!ButonulDeImpar.Enabled)
                    return false;

               if (!buttonPlus.Enabled)
                    return false;

               if (!buttonMinus.Enabled)
                    return false;
               
               return true;
          }
          // functie care scoate din functiune operatiile exexutate
          private void FreeButtons()
          {
               ButonulDeMultiplic.Enabled = true;
               ButonulDeImpar.Enabled = true;
               buttonPlus.Enabled = true;
               buttonMinus.Enabled = true;
          }

      /*    private void InitializeComponent()
          {
               this.SuspendLayout();
               // 
               // Form1
               // 
               this.BackgroundImage = global::calculator.Properties.Resources.yellow;
               this.ClientSize = new System.Drawing.Size(511, 398);
               this.ForeColor = System.Drawing.Color.Coral;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
               this.Name = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.ResumeLayout(false);

          }
          */
          
     }
}
