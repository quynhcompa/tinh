namespace TinhToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            double c = a + b;
            txtkq.Text = c.ToString();
        }
    }
}