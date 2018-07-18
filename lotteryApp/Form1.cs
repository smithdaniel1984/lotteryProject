using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotteryApp
{
    public partial class Lottery_Form : Form
    {

        Random random;
        int click_count = 1;
        int count = 0;
        int Row2_count = 0;
        int Row3_count = 0;
        int countOnes_1 = 0;
        int countOnes_2 = 0;
        int countOnes_3 = 0;
        int countTwos_1 = 0;
        int countTwos_2 = 0;
        int countTwos_3 = 0;
        int countThrees_1 = 0;
        int countThrees_2 = 0;
        int countThrees_3 = 0;
        int countFours_1 = 0;
        int countFours_2 = 0;
        int countFours_3 = 0;
        int countFives_1 = 0;
        int countFives_2 = 0;
        int countFives_3 = 0;
        int countSixs_1 = 0;
        int countSixs_2 = 0;
        int countSixs_3 = 0;
        int countSevens_1 = 0;
        int countSevens_2 = 0;
        int countSevens_3 = 0;
        int countEights_1 = 0;
        int countEights_2 = 0;
        int countEights_3 = 0;
        int countNines_1 = 0;
        int countNines_2 = 0;
        int countNines_3 = 0;


        public Lottery_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void lblPick3_outPut_Click(object sender, EventArgs e)
        {
            random = new Random();
            random.Next(0, 9);

        }

        private void btnDisplayPick3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
           
            //varibles for random numbers
            int number1 = random.Next(0, 10);
            int number2 = random.Next(0, 10);
            int number3 = random.Next(0, 10);
            int number4 = random.Next(0, 10);
            int number5 = random.Next(0, 10);
            int number6 = random.Next(0, 10);
            int number7 = random.Next(0, 10);
            int number8 = random.Next(0, 10);
            int number9 = random.Next(0, 10);

            //convert the output of the text to string
            lblPick3_outPut.Text = Convert.ToString(number1);
            lblRunDown2.Text = Convert.ToString(number2);
            lblRundown3.Text = Convert.ToString(number3);
            lblRundown4 .Text = Convert.ToString(number4);
            lblRundown5.Text = Convert.ToString(number5);
            lblRundown6.Text = Convert.ToString(number6);
            lblRundown7.Text = Convert.ToString(number7);
            lblRundown8.Text = Convert.ToString(number8);
            lblRundown9.Text = Convert.ToString(number9);

            //convert the numbers from the lables to ints
            int lable1 = Convert.ToInt32(lblPick3_outPut.Text);
            int lable2 = Convert.ToInt32(lblRunDown2.Text);
            int lable3 = Convert.ToInt32(lblRundown3.Text);
            int lable4 = Convert.ToInt32(lblRundown4.Text);
            int lable5 = Convert.ToInt32(lblRundown5.Text);
            int lable6 = Convert.ToInt32(lblRundown6.Text);
            int lable7 = Convert.ToInt32(lblRundown7.Text);
            int lable8 = Convert.ToInt32(lblRundown8.Text);
            int lable9 = Convert.ToInt32(lblRundown9.Text);

            //method call for 0's count
            zeros_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 1's count
            ones_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 2's count
            twos_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 3's count
            three_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 4's count
            four_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 5's count
            five_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 6's count
            six_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 7's count
            seven_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 8's count
            eight_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for 9's count
            nine_count(lable1, lable2, lable3, lable4, lable5, lable6, lable7, lable8, lable9);

            //method call for click counter
            click_counter(click_count);

            click_count++;
        }

        public void click_counter(int click_count)
        {
            if(click_count == 10)
            {
                MessageBox.Show("Number of clicks is at: " + click_count);
                btnDisplayPick3.Visible = false;
                btnReset.Visible = true;
            }
          
        }

        public void zeros_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of zeros in the first row
            if (lable1 == 0 || lable2 == 0 || lable3 == 0)
            {
                count = count + 1;
                lblZeroCount.Visible = true;
                lblZeroCount.Text = "Row 1 -- 0 count is: " + count;
            }

            //if statement to count the number of zeros in the Second Row
            if (lable4 == 0 || lable5 == 0 || lable6 == 0)
            {
                Row2_count = Row2_count + 1;
                lblRow2ZeroCount.Visible = true;
                lblRow2ZeroCount.Text = "Row 2 -- 0 count is: " + Row2_count;
            }

            //if statement to count the number of zeros in the Second Row
            if (lable7 == 0 || lable8 == 0 || lable9 == 0)
            {
                Row3_count = Row3_count + 1;
                lblRow3ZeroCount.Visible = true;
                lblRow3ZeroCount.Text = "Row 3 -- 0 count is: " + Row3_count;
            }
        }

        public void ones_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 1 || lable2 == 1 || lable3 == 1)
            {
                countOnes_1 = countOnes_1 + 1;
                lblOnes_count.Visible = true;
                lblOnes_count.Text = "Row 1 -- 1 count is: " + countOnes_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 1 || lable5 == 1 || lable6 == 1)
            {
                countOnes_2 = countOnes_2 + 1;
                lblOnes_count2.Visible = true;
                lblOnes_count2.Text = "Row 2 -- 1 count is: " + countOnes_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 1 || lable8 == 1 || lable9 == 1)
            {
                countOnes_3 = countOnes_3 + 1;
                lblOnes_count3.Visible = true;
                lblOnes_count3.Text = "Row 3 -- 1 count is: " + countOnes_3;
            }
        }

        public void twos_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 2 || lable2 == 2 || lable3 == 2)
            {
                countTwos_1 = countTwos_1 + 1;
                lblTwos_count.Visible = true;
                lblTwos_count.Text = "Row 1 -- 2 count is: " + countTwos_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 2 || lable5 == 2 || lable6 == 2)
            {
                countTwos_2 = countTwos_2 + 1;
                lblTwos_count2.Visible = true;
                lblTwos_count2.Text = "Row 2 -- 2 count is: " + countTwos_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 2 || lable8 == 2 || lable9 == 2)
            {
                countTwos_3 = countTwos_3 + 1;
                lblTwos_count3.Visible = true;
                lblTwos_count3.Text = "Row 3 -- 2 count is: " + countTwos_3;
            }
        }

        public void three_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 3 || lable2 == 3 || lable3 == 3)
            {
                countThrees_1 = countThrees_1 + 1;
                lblThrees_count.Visible = true;
                lblThrees_count.Text = "Row 1 -- 3 count is: " + countThrees_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 3 || lable5 == 3 || lable6 == 3)
            {
                countThrees_2 = countThrees_2 + 1;
                lblThrees_count2.Visible = true;
                lblThrees_count2.Text = "Row 2 -- 3 count is: " + countThrees_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 3 || lable8 == 3 || lable9 == 3)
            {
                countThrees_3 = countThrees_3 + 1;
                lblThrees_count3.Visible = true;
                lblThrees_count3.Text = "Row 3 -- 3 count is: " + countThrees_3;
            }
        }

        public void four_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 4 || lable2 == 4 || lable3 == 4)
            {
                countFours_1 = countFours_1 + 1;
                lblFours_count.Visible = true;
                lblFours_count.Text = "Row 1 -- 4 count is: " + countFours_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 4 || lable5 == 4 || lable6 == 4)
            {
                countFours_2 = countFours_2 + 1;
                lblFours_count2.Visible = true;
                lblFours_count2.Text = "Row 2 -- 4 count is: " + countFours_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 4 || lable8 == 4 || lable9 == 4)
            {
                countFours_3 = countFours_3 + 1;
                lblFours_count3.Visible = true;
                lblFours_count3.Text = "Row 3 -- 4 count is: " + countFours_3;
            }
        }

        public void five_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 5 || lable2 == 5 || lable3 == 5)
            {
                countFives_1 = countFives_1 + 1;
                lblFives_count.Visible = true;
                lblFives_count.Text = "Row 1 -- 5 count is: " + countFives_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 5 || lable5 == 5 || lable6 == 5)
            {
                countFives_2 = countFives_2 + 1;
                lblFives_count2.Visible = true;
                lblFives_count2.Text = "Row 2 -- 5 count is: " + countFives_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 5 || lable8 == 5 || lable9 == 5)
            {
                countFives_3 = countFives_3 + 1;
                lblFives_count3.Visible = true;
                lblFives_count3.Text = "Row 3 -- 5 count is: " + countFives_3;
            }
        }

        public void six_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 6 || lable2 == 6 || lable3 == 6)
            {
                countSixs_1 = countSixs_1 + 1;
                lblSixs_count.Visible = true;
                lblSixs_count.Text = "Row 1 -- 6 count is: " + countSixs_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 6 || lable5 == 6 || lable6 == 6)
            {
                countSixs_2 = countSixs_2 + 1;
                lblSixs_count2.Visible = true;
                lblSixs_count2.Text = "Row 2 -- 6 count is: " + countSixs_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 6 || lable8 == 6 || lable9 == 6)
            {
                countSixs_3 = countSixs_3 + 1;
                lblSixs_count3.Visible = true;
                lblSixs_count3.Text = "Row 3 -- 6 count is: " + countSixs_3;
            }
        }

        public void seven_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 7 || lable2 == 7 || lable3 == 7)
            {
                countSevens_1 = countSevens_1 + 1;
                lblSevens_count.Visible = true;
                lblSevens_count.Text = "Row 1 -- 7 count is: " + countSevens_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 7 || lable5 == 7 || lable6 == 7)
            {
                countSevens_2 = countSevens_2 + 1;
                lblSevens_count2.Visible = true;
                lblSevens_count2.Text = "Row 2 -- 7 count is: " + countSevens_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 7 || lable8 == 7 || lable9 == 7)
            {
                countSevens_3 = countSevens_3 + 1;
                lblSevens_count3.Visible = true;
                lblSevens_count3.Text = "Row 3 -- 7 count is: " + countSevens_3;
            }
        }

        public void eight_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 8 || lable2 == 8 || lable3 == 8)
            {
                countEights_1 = countEights_1 + 1;
                lblEights_count.Visible = true;
                lblEights_count.Text = "Row 1 -- 8 count is: " + countEights_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 8 || lable5 == 8 || lable6 == 8)
            {
                countEights_2 = countEights_2 + 1;
                lblEights_count2.Visible = true;
                lblEights_count2.Text = "Row 2 -- 8 count is: " + countEights_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 8 || lable8 == 8 || lable9 == 8)
            {
                countEights_3 = countEights_3 + 1;
                lblEights_count3.Visible = true;
                lblEights_count3.Text = "Row 3 -- 8 count is: " + countEights_3;
            }
        }

        public void nine_count(int lable1, int lable2, int lable3, int lable4, int lable5, int lable6, int lable7, int lable8, int lable9)
        {
            //if statement to count the number of ones in the first row
            if (lable1 == 9 || lable2 == 9 || lable3 == 9)
            {
                countNines_1 = countNines_1 + 1;
                lblNines_count.Visible = true;
                lblNines_count.Text = "Row 1 -- 9 count is: " + countNines_1;
            }

            //if statement to count the number of ones in the second row
            if (lable4 == 9 || lable5 == 9 || lable6 == 9)
            {
                countNines_2 = countNines_2 + 1;
                lblNines_count2.Visible = true;
                lblNines_count2.Text = "Row 2 -- 9 count is: " + countNines_2;
            }

            //if statement to count the number of ones in the third row
            if (lable7 == 9 || lable8 == 9 || lable9 == 9)
            {
                countNines_3 = countNines_3 + 1;
                lblNines_count3.Visible = true;
                lblNines_count3.Text = "Row 3 -- 9 count is: " + countNines_3;
            }
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            btnDisplayPick3.Visible = true;
        }
    }
}