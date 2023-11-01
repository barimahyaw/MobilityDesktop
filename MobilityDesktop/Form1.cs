using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MobilityDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FirstNumberBtn_Click(object sender, EventArgs e)
            => GeneratePrimeNumbers(FirstNumberTxt.Text);
        private void SeconNumberBtn_Click(object sender, EventArgs e)
            => GeneratePrimeNumbers(SeconNumberTxt.Text);

        private void GeneratePrimeNumbers(string number)
        {
            if (int.TryParse(number, out int n))
            {
                var primes = PrimeNumbers.FindPrimes(n);
                listPrimeNumbers.Items.Clear();
                foreach (var prime in primes)
                {
                    listPrimeNumbers.Items.Add(prime.ToString());
                }
            }
        }
    }
}