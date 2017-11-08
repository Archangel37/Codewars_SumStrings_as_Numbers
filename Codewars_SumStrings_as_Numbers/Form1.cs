using System;
using System.Numerics;
using System.Windows.Forms;


//Description:

//Given the string representations of two integers, return the string representation of the sum of those integers.

//For example:

//sumStrings('1','2') // => '3'
//A string representation of an integer will contain no characters besides the ten numerals "0" to "9".

//best solution:
//using System;
//using System.Numerics;

//public static class Kata
//{
//    public static string sumStrings(string a, string b)
//    {
//        BigInteger aInt;
//        BigInteger bInt;

//        BigInteger.TryParse(a, out aInt);
//        BigInteger.TryParse(b, out bInt);

//        return (aInt + bInt).ToString();
//    }
//}

namespace Codewars_SumStrings_as_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string sumStrings(string a, string b)
        {
            BigInteger A, B;
            try
            {
                A = BigInteger.Parse(a);
                B = BigInteger.Parse(b);
            }
            catch (Exception)
            {
                if (a == string.Empty)
                    return b;
                if (b == string.Empty)
                    return a;
            }

            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = sumStrings(textBox_A.Text, textBox_B.Text);
        }
    }
}