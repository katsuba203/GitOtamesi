namespace GitOtamesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dentaku dentaku = new dentaku();
            textBox4.Text= dentaku.pushequal(textBox1.Text, textBox2.Text,textBox3.Text).ToString();
        }
    }
}