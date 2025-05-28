namespace calcular_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IMC_Click(object sender, EventArgs e)
        {

            //converter de string para int/float
            if(float.TryParse(peso.Text,out float pesos))
            {

            }
            if (float.TryParse(altura.Text, out float alturas))
            {

            }

             float imcs = pesos / (alturas * alturas);

             imc1.Text = imcs.ToString("F2");

        }
    }
}
