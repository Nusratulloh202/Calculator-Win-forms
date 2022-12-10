namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string a_text = textBox1.Text;
            string b_text = textBox2.Text;
            if (a_text.Length == 0 || b_text.Length == 0)
            {
                textBox7.Text = $"Malumot to'ldirilmagan";

            }
            else
            {
                decimal a = Convert.ToDecimal(a_text);
                decimal b = Convert.ToDecimal(b_text);

                decimal yigindi = a + b;
                decimal ayirma = a - b;
                decimal kopaytma = a * b;
                decimal bolinma = a / b;


                textBox3.Text = $"{yigindi}";
                textBox4.Text = $"{ayirma}";
                textBox5.Text = $"{kopaytma}";
                textBox6.Text = $"{bolinma}";
                textBox7.Text = $"Xatolik yo'q";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
            this.ForeColor = Color.Red;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile("E:\\DCIM\\Camera\\Camera\\manzara.jpg");

        }
    }
}