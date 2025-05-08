namespace DummyCiCd2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1=int.Parse(textBox1.Text);
            var num2 = int.Parse(textBox2.Text);
            var result = Add(num1, num2);
            textBox3.Text = result.ToString();
        }
    }
}
