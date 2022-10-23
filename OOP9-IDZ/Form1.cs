namespace OOP9_IDZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int n = int.Parse(textBox3.Text);
            int r = int.Parse(textBox4.Text);
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; i <= r; i++)
                {
                    result += (Math.Pow(p, i) * Math.Pow(y, j)) / (i * j);
                }
            }
            textBox5.Text = result.ToString();
        }
    }
}