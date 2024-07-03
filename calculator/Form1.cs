namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Num1;
        double res = 0;
        char op;
        bool Finished = false;
        private void btn11_Click(object sender, EventArgs e)
        {
            if (Finished)
            {
                txtScreen.Text = "";
                txtScreen.Text += ((Button)sender).Text;
                Finished = false;
            }
            else
            {
                txtScreen.Text += ((Button)sender).Text;
            }
        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            double num1;
            while (!double.TryParse(txtScreen.Text, out  num1))
            {
                MessageBox.Show("Please enter a valid number.");
                txtScreen.Text = ""; 
                txtScreen.Focus();
            }
            Num1 = num1;
            txtScreen.Text = "";
            op = char.Parse(((Button)sender).Text);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num2;
            double Num2;
            while (!double.TryParse(txtScreen.Text, out num2))
            {
                MessageBox.Show("Please enter a valid number.");
                txtScreen.Text = "";
                txtScreen.Focus();
            }
            Num2 = num2;
            
            switch (op)
            {
                case '+':
                    res = Num1 + Num2;
                    txtScreen.Text = res.ToString();
                    Finished = true;
                    break;
                case '-':
                    res = Num1 - Num2;
                    txtScreen.Text = res.ToString();
                    Finished = true;
                    break;
                case '*':
                    res = Num1 * Num2;
                    txtScreen.Text = res.ToString();
                    Finished = true;
                    break;
                case '/':
                    res = Num1 / Num2;
                    txtScreen.Text = res.ToString();
                    Finished = true;
                    break;
                default:
                    break;
            }
        }
    }
}
