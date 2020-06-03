using Calculations;
using FiveNumberSummary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Input = UserInput.Text;
            ConvertInput.Input(Input);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
namespace FiveNumberSummary
{
    class ConvertInput
    {
        public static void Input(string userInput)
        {
            string[] strList = userInput.Split(',');
            var nums = new double[strList.Length];
            int totalNums = nums.Length;
            for (int i = 0; i < totalNums; i++)
            {
                nums[i] = Convert.ToDouble(strList[i]);
            }
            Array.Sort(nums);
            ;

            double min = Operations.Min(nums);
            double q1 = Operations.Percentile(nums, 25);
            double medi = Operations.Percentile(nums, 50);
            double q3 = Operations.Percentile(nums, 75);
            double max = Operations.Max(nums, totalNums);

            MessageBox.Show("MIN:" + Convert.ToString(min) + "  "+
                            "Q1:" + Convert.ToString(q1) + "  " +
                            "MEDIAN:" + Convert.ToString(medi) + "  " +
                            "Q3:" + Convert.ToString(q3) + "  " +
                            "MAX:" + Convert.ToString(max) + "  ");
        }
    }
}

namespace Calculations
{
    class Operations
    {
        public static double Percentile(double[] nums, int totalNums)
        {
            if (totalNums >= 100) return nums[nums.Length - 1];

            double position = (nums.Length + 1) * totalNums / 100;
            double leftNumber = 0.0d, rightNumber = 0.0d;

            double n = totalNums / 100.0d * (nums.Length - 1) + 1.0d;

            if (position >= 1)
            {
                leftNumber = nums[(int)Math.Floor(n) - 1];
                rightNumber = nums[(int)Math.Floor(n)];
            }
            else
            {
                leftNumber = nums[0]; // first data
                rightNumber = nums[1]; // first data
            }

            //if (leftNumber == rightNumber)
            if (Equals(leftNumber, rightNumber))
                return leftNumber;
            double part = n - Math.Floor(n);
            return leftNumber + part * (rightNumber - leftNumber);
        }

        public static double Min(double[] nums)
        {
            double min = nums[0];
            return min;
        }

        public static double Max(double[] nums, int totalNums)
        {
            double max = nums[totalNums - 1];
            return max;
        }
    }
}
