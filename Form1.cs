using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class MathQuiz : Form


    {
        Random randomzier = new Random();
        int added1;
        int added2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int divident;
        int divisor;

        int timeLeft;
        public MathQuiz()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            added1 = randomzier.Next(50);
            added2 = randomzier.Next(50);
            plusLeftLabel.Text = added1.ToString();
            plusRightLabel.Text = added2.ToString();

            sum.Value = 0;

            minuend = randomzier.Next(1, 101);
            subtrahend = randomzier.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();

            product.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomzier.Next(2, 11);
            multiplier = randomzier.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomzier.Next(2, 11);
            int temporaryQuotient = randomzier.Next(2, 11);
            divident = divisor * temporaryQuotient;
            dividedLeftLabel.Text = divident.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();



        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();



            startButton.Enabled = false;
        }
        private bool CheckTheAnswer()
        {
            if ((added1 + added2 == sum.Value) && (minuend - subtrahend == difference.Value) && (multiplicand * multiplier == product.Value)
        && (divident / divisor == quotient.Value)) { return true; }
            else
                return false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You did it");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0) {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time is up";
                MessageBox.Show("Next time");
                sum.Value = added1 + added2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = divident / divisor;
                startButton.Enabled = true;


            }
        }
    }


}
