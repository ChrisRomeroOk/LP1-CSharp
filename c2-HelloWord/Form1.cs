namespace c2_HelloWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2;

            n1 = 5;
            n2 = 4;

            int resultado = sumar(n1, n2);

            MessageBox.Show("el suma de " + n1 + " y " + n2 + " es: " + resultado.ToString());
        }

        private int sumar(int a, int b)
        {
            return a + b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}