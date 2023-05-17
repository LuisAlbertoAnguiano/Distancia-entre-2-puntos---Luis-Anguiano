namespace Distancia_entre_2_puntos___Luis_Anguiano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double DistanciaPunto()
        {
            double Distancia;

            double X1 = Double.Parse(tbX1.Text);
            double Y1 = Convert.ToDouble(tbY1.Text);
            double X2 = Convert.ToDouble(tbX2.Text);
            double Y2 = Convert.ToDouble(tbY2.Text);

            Distancia = Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1) * (Y2 - Y1)));
            Distancia = Math.Round(Distancia, 2);

            return Distancia;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Distancia_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tb_Distancia.Text = Convert.ToString(DistanciaPunto());
            }
            catch (Exception)
            {
                MessageBox.Show("Error, los valores no son validos o no fueron ingresados");
                throw;
            }
        }
    }
}