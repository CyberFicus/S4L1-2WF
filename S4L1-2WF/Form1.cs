namespace S4L1_2WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_btn_Click(object sender, EventArgs e)
        {
            char sum_byte(char c1, char c2)
            {
                byte bit_selector = 1;
                for (int i = 0; i < 7; i++)
                {
                    c1 = (char)(c1 | (c2 & bit_selector));
                    bit_selector <<= 1;
                }
                return c1;
            }

            string s1 = textBox_fn.Text, s2 = textBox_sn.Text;

            if (s1 != "" && s2 != "")
            {
                Console.Write($"{s1} + {s2} = ");

                if (s1.Length > s2.Length)
                {
                    string buf = s2;
                    s2 = s1;
                    s1 = buf;
                } // итого, s2 длиннее (или равно по длине) s1

                string res = "Result: ";

                for (int i = 0; i < s2.Length; i++)
                {
                    res += sum_byte(s1[i % s1.Length], s2[i]);
                }

                MessageBox.Show(res);
            }
            else
            {
                MessageBox.Show("Incorrect input!!!");
            }
        }

        private void encrypt_btn_Click(object sender, EventArgs e)
        {

            string caesar(string s, int shift)
            {
                char shift_fun(char c, int shift)
                {
                    int a = ((int)c + shift);

                    if (c >= 'A' && c <= 'Z')
                    {
                        a -= (int)'A';
                        a = a % 26;
                        a += (int)'A';
                        c = (char)a;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        a -= (int)'a';
                        a = a % 26;
                        a += (int)'a';
                        c = (char)a;
                    }

                    return c;
                }

                string res = "";
                for (int i = 0; i < s.Length; i++)
                {
                    res += shift_fun(s[i], shift);
                }

                return res;
            }

            try
            {
                int shift = Convert.ToInt32(textBox_shift.Text);

                string fn = textBox_fn.Text, sn = textBox_sn.Text;
                string fn_c = caesar(fn, shift), sn_c = caesar(sn, shift);

                MessageBox.Show($"Before: {fn} {sn}\n After: {fn_c} {sn_c}");
            }
            catch
            {
                MessageBox.Show("Error! Incorrect shift value!");
            }

        }

        private void rand_btn_Click(object sender, EventArgs e)
        {
            string rand_name()
            {
                Random rand = new Random();
                
                String s = "";
                s += (char) rand.Next((int)'A', (int)'Z');

                int len = rand.Next(4, 10);
                for (int i = 1; i<len; i++)
                {
                    s += (char) rand.Next((int)'a', (int)'z');
                }

                return s;
            }

            textBox_fn.Text = rand_name();
            textBox_sn.Text = rand_name();
        }
    }

}