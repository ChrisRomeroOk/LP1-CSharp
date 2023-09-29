namespace c3_SegBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string clave = "";

        private void button1_Click(object sender, EventArgs e)
        {
            clave += "1";
            label1.Text = clave;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clave += "2";
            label1.Text = clave;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clave += "3";
            label1.Text = clave;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            String labelResultado = clave;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clave == "112233")
            {
                label1.Text = "Clave Correcta";
            }
            else
            {
                label1.Text = "Clave Incorrecta";
                clave = "";
            }
        }
    }
}