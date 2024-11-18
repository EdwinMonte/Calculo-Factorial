namespace Calculo_Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int n) && n > 0)
            {
                int result = FactorialRecursive(n);
                lblResult.Text = $"{n}! = {result}.";
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.");
            }
        }

        int FactorialRecursive(int n)
        {
            if (n == 1) return 1; // Condición de salida
            return n * FactorialRecursive(n - 1); // Segmento recursivo
        }
    }
}
