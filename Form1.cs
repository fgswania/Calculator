namespace calculator
{
    public partial class Form1 : Form
    {
        double rs = 0;
        string perf = "";
        bool op = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void nclick(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if ((textBox1.Text == "0") || (op))
                textBox1.Clear(); 
            textBox1.Text = textBox1.Text + n.Text;
            lbl.Text = rs + " " + perf;
            op = false;
        }

        private void opclick(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            perf = n.Text;
            rs = double.Parse(textBox1.Text);
            op = true;
        }

        private void nce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            rs = 0;
        }

        private void equalclick(object sender, EventArgs e)
        {
            switch (perf)
            {
                case "+":
                    textBox1.Text = (rs + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (rs - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (rs * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (rs / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
