namespace S4L1_2WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            string s1 = "Anton", s2 = "Ivanov";
            string buf = "Result: ";

            for (int i = 0; i < s2.Length; i++)
            {
                if (i < s1.Length)
                {
                    buf += sum_byte(s1[i], s2[i]);
                }
                else
                    buf += s2[i];
            }

            MessageBox.Show(buf);
        }
    }

}