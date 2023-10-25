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
            MessageBox.Show((dentaku.pushequal("3", "+", "8")).ToString());
           
        }
    }
}