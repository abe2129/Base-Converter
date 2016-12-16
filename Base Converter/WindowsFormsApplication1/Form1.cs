using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int prec0 = 100;
        string dec0 = "";
        string decs1 = "";
        string decs2 = "";
        string sign = "";
        string bin0 = "";
        string bin1 = "";
        string bin2 = "";
        string oct0 = "";
        string hex0 = "";
        string ieeesp0 = "";
        string ieeesp10 = "";
        string ieeesph0 = "";
        string ieeedp0 = "";
        string ieeedp10 = "";
        string ieeedph0 = "";
        string f32 = "";
        string f64 = "";
        string exp32 = "";
        string exp64 = "";
        Boolean fdec = false;
        Boolean fbin = false;
        Boolean foct = false;
        Boolean fhex = false;
        Boolean fieeesp = false;
        Boolean fieeesp1 = false;
        Boolean fieeesph = false;
        Boolean fieeedp = false;
        Boolean fieeedp1 = false;
        Boolean fieeedph = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dec.Focused)
            {
                fdec = true;
                fbin = false;
                foct = false;
                fhex = false;
                fieeesp = false;
                fieeesp1 = false;
                fieeesph = false;
                fieeedp = false;
                fieeedp1 = false;
                fieeedph = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (bin.Focused)
            {
                bin0 = (string)sender;
         
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (oct.Focused)
            {
                oct0 = (string)sender;
             
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (hex.Focused)
            {
                hex0 = (string)sender;
               
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (ieeesp.Focused)
            {
                ieeesp0 = (string)sender;
             
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (ieeesp1.Focused)
            {
                ieeesp10 = (string)sender;
         
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (ieeesph.Focused)
            {
                ieeesph0 = (string)sender;
             
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (ieeedp.Focused)
            {
                ieeedp0 = (string)sender;
          
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (ieeedp1.Focused)
            {
                ieeedp10 = (string)sender;
            
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (ieeedph.Focused)
            {
                ieeedph0 = (string)sender;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void convertToDec()
        {

        }
        private void convertDecToB(int x)
        {
            bool notFound = true;
            int k = 0;
            if (dec0[k].Equals('-'))
            {
                sign = "1";
            }
            else
            {
                sign = "0";
            }
            while (notFound && k < dec0.Length)
            {
                if (dec0[k].Equals('.'))
                {
                    notFound = false;
                    decs1 = dec0.Substring(0, k);
                    decs2 = dec0.Substring(k + 1, dec0.Length - k-1);

                }
                k++;
            }
            if (notFound)
            {
                decs1 = dec0;
                decs2 = "0";
            }
            ieeedp.Text = decs2;
            BigInteger intp = BigInteger.Parse(decs1);
            BigInteger fracp = BigInteger.Parse(decs2);
            string y = "";
            if (intp < 0)
            {
                intp = intp * -1;
            }
            if (intp == 0)
            {
                y = "0";
            }
            while (intp > 0)
            {
                BigInteger rem = intp % x;
                if (rem == 10)
                {
                    y = "A" + y;
                }
                else if (rem == 11)
                {
                    y = "B" + y;
                }
                else if (rem == 12)
                {
                    y = "C" + y;
                }
                else if (rem == 13)
                {
                    y = "D" + y;
                }
                else if (rem == 14)
                {
                    y = "E" + y;
                }
                else if (rem == 15)
                {
                    y = "F" + y;
                }
                else
                {
                    y = rem + y;
                }
                bin1 = rem + bin1;
                intp = intp / x;
            }
            if (fracp != 0)
            {
                y = y + ".";
            }
            int kp = 1;
            while (fracp > 0 && kp <= prec0)
            {
                BigInteger intg = 0;
                int fraclength = decs2.Length;
                BigInteger intg1 = fracp * x;
                int newlength = (intg1 + "").Length;
                if (newlength > fraclength)
                {
                    intg = BigInteger.Parse((intg1 + "").Substring(0, newlength - fraclength));
                    fracp = BigInteger.Parse((intg1 + "").Substring(newlength - fraclength, fraclength));
                }
                else
                {
                    fracp = intg1;
                }
                if (intg == 10)
                {
                    y = y +"A";
                }
                else if (intg == 11)
                {
                    y = y + "B";
                }
                else if (intg == 12)
                {
                    y = y + "C";
                }
                else if (intg == 13)
                {
                    y = y + "D";
                }
                else if (intg == 14)
                {
                    y = y + "E";
                }
                else if (intg == 15)
                {
                    y = y + "F";
                }
                else
                {
                    y = y + intg;
                }
                bin2 = bin2 + intg;
                kp++;
            }
            if (x == 2)
            {
                bin0 = y;
            }
            if (x == 8)
            {
                oct0 = y;
            }
            if (x == 16)
            {
                hex0 = y;
            }
        }
        private void convertDecToOct()
        {

        }
        private void convertToHex()
        {

        }
        private string convertDecToIEEE(int f, int bias, int length)
        {
            int e= 0;
            int i = 1;
            int pos = 0;
            int pos1 = 0;
            string frac = "";
            bool notfound = true;
            if (bin0.Equals("0"))
            {
                if (f == 23)
                {
                    return sign + "0000000000000000000000000000000";
                }
                else
                {
                    return sign + "000000000000000000000000000000000000000000000000000000000000000";
                }
            }
            if (bin0[0] == '0')
            {
                while (notfound && bin0.Length > 1 && !bin2.Equals(""))
                {
                    if (bin0[i].Equals('1'))
                    {
                        notfound = false;
                        pos1 = i;
                    }
                    if (bin0[i].Equals('.'))
                    {
                        pos = i;
                    }
                    i++;
                }
                e = pos - pos1;
            }
            else
            {
                while (notfound && bin0.Length>1 && !bin2.Equals(""))
            {
                if (bin0[i].Equals('.'))
                {
                    notfound = false;
                }
                else
                {
                    frac = frac + bin0[i];
                    e++;
                }
                i++;
            }
            }
            if (bin2.Equals(""))
            {
                e = bin0.Length - 1;
            }
            if (bin0[0] != '0')
            {
                while (i <= f + 1)
                {
                    if (i < bin0.Length)
                    {
                        frac = frac + bin0[i];
                    }
                    else
                    {
                        frac = frac + 0;
                    }
                    i++;
                }
            }
            else
            {
                while (i <= pos1+f)
                {
                    if (i < bin0.Length)
                    {
                        frac = frac + bin0[i];
                    }
                    else
                    {
                        frac = frac + 0;
                    }
                    i++;
                }
            }
            if (bias == 127)
            {
                f32 = frac;
            }
            else
            {
                f64 = frac;
            }
            string m = "";
            if (e > (bias + 1) || e < (bias * -1))
            {
                if (bias == 127)
                {
                    return "Cannot be represented in IEEE Floating Point single precision";
                }
                else
                {
                    return "Cannot be represented in IEEE Floating Point double precision";
                }
                
            }
            else if (e == (bias + 1))
            {
                exp32 = "128";
                exp64 = "1024";
                m = sign + "infinity";
                for (int j = 0; j < f; j++)
                {
                    if (frac[j].Equals(1))
                    {
                        m = "NaN";
                    }
                }
                if (bias == 127)
                {
                    return sign + "11111111" + frac + " " + m;
                }
                else
                {
                    return sign + "11111111111" + frac + " " + m;
                }
                
            }
            else
            {
                
                exp32 = e + "";
                exp64 = e + "";
                e = e + bias;
                while (e > 0)
                {
                    int rem = e % 2;
                    frac = rem + frac;
                    e = e / 2;
                }
                while (frac.Length < (length-1))
                {
                    frac = "0" + frac;
                }
                frac = sign + frac;
                return frac;
            }
        }
        private string[] convertIEEEToHO(int b)
        {
            string ieee1 = ieeesp0;
            string ieee2 = ieeedp0;
            if (b == 3)
            {
                ieee1 = "0" + ieee1;
                ieee2 = "00" + ieee2;
            }
            string word1 = "";
            string word2 = "";
            for(int i = 0; i < 64; i = i + b)
            {
                string f1 = "";
                string f2 = ieee2.Substring(i, b);
                if (i < 32)
                {
                    f1 = ieee1.Substring(i, b);
                }
                if (f1.Equals("000"))
                {
                    word1 = word1 + "0";
                }
                if (f1.Equals("001"))
                {
                    word1 = word1 + "1";
                }
                if (f1.Equals("010"))
                {
                    word1 = word1 + "2";
                }
                if (f1.Equals("011"))
                {
                    word1 = word1 + "3";
                }
                if (f1.Equals("100"))
                {
                    word1 = word1 + "4";
                }
                if (f1.Equals("101"))
                {
                    word1 = word1 + "5";
                }
                if (f1.Equals("110"))
                {
                    word1 = word1 + "6";
                }
                if (f1.Equals("111"))
                {
                    word1 = word1 + "7";
                }
                if (f2.Equals("000"))
                {
                    word2 = word2 + "0";
                }
                if (f2.Equals("001"))
                {
                    word2 = word1 + "1";
                }
                if (f2.Equals("010"))
                {
                    word2 = word2 + "2";
                }
                if (f2.Equals("011"))
                {
                    word2 = word2 + "3";
                }
                if (f2.Equals("100"))
                {
                    word2 = word2 + "4";
                }
                if (f2.Equals("101"))
                {
                    word2 = word2 + "5";
                }
                if (f2.Equals("110"))
                {
                    word2 = word2 + "6";
                }
                if (f2.Equals("111"))
                {
                    word2 = word2 + "7";
                }
                if (f1.Equals("0000"))
                {
                    word1 = word1 + "0";
                }
                if (f1.Equals("0001"))
                {
                    word1 = word1 + "1";
                }
                if (f1.Equals("0010"))
                {
                    word1 = word1 + "2";
                }
                if (f1.Equals("0011"))
                {
                    word1 = word1 + "3";
                }
                if (f1.Equals("0100"))
                {
                    word1 = word1 + "4";
                }
                if (f1.Equals("0101"))
                {
                    word1 = word1 + "5";
                }
                if (f1.Equals("0110"))
                {
                    word1 = word1 + "6";
                }
                if (f1.Equals("0111"))
                {
                    word1 = word1 + "7";
                }
                if (f1.Equals("1000"))
                {
                    word1 = word1 + "8";
                }
                if (f1.Equals("1001"))
                {
                    word1 = word1 + "9";
                }
                if (f1.Equals("1010"))
                {
                    word1 = word1 + "A";
                }
                if (f1.Equals("1011"))
                {
                    word1 = word1 + "B";
                }
                if (f1.Equals("1100"))
                {
                    word1 = word1 + "C";
                }
                if (f1.Equals("1101"))
                {
                    word1 = word1 + "D";
                }
                if (f1.Equals("1110"))
                {
                    word1 = word1 + "E";
                }
                if (f1.Equals("1111"))
                {
                    word1 = word1 + "F";
                }
                if (f2.Equals("0000"))
                {
                    word2 = word2 + "0";
                }
                if (f2.Equals("0001"))
                {
                    word2 = word1 + "1";
                }
                if (f2.Equals("0010"))
                {
                    word2 = word2 + "2";
                }
                if (f2.Equals("0011"))
                {
                    word2 = word2 + "3";
                }
                if (f2.Equals("0100"))
                {
                    word2 = word2 + "4";
                }
                if (f2.Equals("0101"))
                {
                    word2 = word2 + "5";
                }
                if (f2.Equals("0110"))
                {
                    word2 = word2 + "6";
                }
                if (f2.Equals("0111"))
                {
                    word2 = word2 + "7";
                }
                if (f2.Equals("1000"))
                {
                    word2 = word2 + "8";
                }
                if (f2.Equals("1001"))
                {
                    word2 = word2 + "9";
                }
                if (f2.Equals("1010"))
                {
                    word2 = word2 + "A";
                }
                if (f2.Equals("1011"))
                {
                    word2 = word2 + "B";
                }
                if (f2.Equals("1100"))
                {
                    word2 = word2 + "C";
                }
                if (f2.Equals("1101"))
                {
                    word2 = word2 + "D";
                }
                if (f2.Equals("1110"))
                {
                    word2 = word2 + "E";
                }
                if (f2.Equals("1111"))
                {
                    word2 = word2 + "F";
                }
            }
            return new string[2] {word1,word2};
        }
        private string normalizeIEEE(int length)
        {
            string s = "+";
            if (sign.Equals("1"))
            {
                s = "-";
            }
            if (length == 32)
            {
                return s + "1." + f32 + "x2^(" + exp32 + ")";
            }
            return s + "1." + f64 + "x2^(" + exp64 + ")";
        }
        private void convertToIEEEdp()
        {

        }
        private void convertToIEEEdp1()
        {

        }
        private void convertToIEEEdpH()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (fdec)
            {
                float n;
                bool isNumeric = float.TryParse(dec.Text, out n);
                if (isNumeric)
                {
                    dec0 = dec.Text;
                }
                int n1;
                bool isNumeric1 = int.TryParse(prec.Text, out n1);
                if (isNumeric1)
                {
                    prec0 = int.Parse(prec.Text);
                }
                convertDecToB(2);
                bin.Text = bin0;
                convertDecToB(8);
                oct.Text = oct0;
                convertDecToB(16);
                hex.Text = hex0;
                ieeesp0 = convertDecToIEEE(23, 127, 32);
                ieeesp.Text = ieeesp0;
                ieeedp0 = convertDecToIEEE(52, 1023, 64);
                ieeedp.Text = ieeedp0;
                string[] words1 = convertIEEEToHO(3);
                string[] words2 = convertIEEEToHO(4);
                ieeesph.Text = words2[0];
                ieeedph.Text = words2[1];
                ieeeoct1.Text = words1[0];
                ieeeoct2.Text = words1[1];
                ieeesp1.Text = normalizeIEEE(32);
                ieeedp1.Text = normalizeIEEE(64);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
