using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedQuizApp
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int leftplus, rightplus, 
            leftminus, rightminus, 
            lefttimes, righttimes,
            leftdivision, rightdivision;
        int time = 30; //30s
        int temp;

        private void StartQuiz()
        {
            
            leftplus = random.Next(20);
            rightplus = random.Next(20);
            leftminus = random.Next(1,20);
            rightminus = random.Next(1,leftminus);
            lefttimes = random.Next(20);
            righttimes = random.Next(20);
            rightdivision = random.Next(1,9);
            temp = random.Next(1, 9);
            leftdivision = rightdivision*temp;


            plusLeftLabel.Text = leftplus.ToString();
            plusRightLabel.Text = rightplus.ToString();

            minusLeftLabel.Text = leftminus.ToString();
            minusRightLabel.Text = rightminus.ToString();
            
            timesLeftLabel.Text = lefttimes.ToString();
            timesRightLabel.Text = righttimes.ToString();
            
            divisionLeftLabel.Text = leftdivision.ToString();
            divisionRightLabel.Text = rightdivision.ToString();

            timerquiz.Start();
            startbtn.Enabled = false;
        }
        private void FinishQuiz()
        {
            plusLeftLabel.Text ="?";
            plusRightLabel.Text = "?";
            minusLeftLabel.Text = "?";
            minusRightLabel.Text = "?";
            timesLeftLabel.Text = "?";
            timesRightLabel.Text = "?";
            divisionLeftLabel.Text = "?";
            divisionRightLabel.Text = "?";
            sum.Value = 0;
            difference.Value = 0;
            product.Value = 0;
            quotient.Value = 0;
            Timelabel.Text = "";
            Timelabel.BackColor = Color.LightBlue;
            timerquiz.Stop();
            time = 30;
            startbtn.Enabled = true;
        }
        private bool checkAnswer()
        {
            if ((leftplus + rightplus == sum.Value)&& 
                (leftminus - rightminus == difference.Value) &&
                (lefttimes * righttimes == product.Value) &&
                (leftdivision / rightdivision == quotient.Value)
                )return true;
            return false;
        }
        private void timerquiz_Tick(object sender, EventArgs e)
        {
            if (checkAnswer())
            {
                FinishQuiz();
                MessageBox.Show("Congratulations :) ");
            }
            else
            {
                if (time == 0)
                {
                    FinishQuiz();
                    MessageBox.Show("Finish , Try again :( ");
                }
                else
                {
                    time--;
                    Timelabel.Text = "00:" + time;
                    if (time <= 5)
                    {
                        Timelabel.BackColor = Color.Red;
                        Timelabel.ForeColor = Color.Yellow;
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }
    }
}
