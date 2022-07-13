namespace ProyectoFin
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            txtPrecioHam.Clear();
            txtPrecioBebi.Clear();
            txtPrecioPapas.Clear();
            txtPrecioPizz.Clear();
            txtBebida.Clear();
            txtCambio.Clear();
            txtDinero.Clear();
            txthamb.Clear();
            txtPapas.Clear();
            txtPizza.Clear();
            txtTotal.Clear();


        }






        int cantidadHam = 0;

        int cantidadPapas = 0;

        int cantidadBebidas = 0;

        int cantidasPizzas = 0;

        double total = 0;

        double precioHamb;

        double precioPapas;

        double precioBebidas;

        double precioPizzas;

        double dineroCli = 0;

        double cambio = 0;


       



        double incrementar()
        {
            precioHamb = double.Parse(txtPrecioHam.Text);

            precioPapas = double.Parse(txtPrecioPapas.Text);

            precioBebidas = double.Parse(txtPrecioBebi.Text);

            precioPizzas = double.Parse(txtPrecioPizz.Text);


            total = (cantidadHam * precioHamb) + (cantidadPapas * precioPapas) + (cantidadBebidas * precioBebidas) + (cantidasPizzas * precioPizzas);


            txtTotal.Text = total.ToString();

            return total;

        }

        private void btnHMas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecioHam.Text))
            {
                MessageBox.Show("Debe Ingresar un monto");
            }
            else
            {
                cantidadHam++;
                txthamb.Text = cantidadHam.ToString();
                incrementar();
            }
        }

        private void btnHMenos_Click(object sender, EventArgs e)
        {
            if (cantidadHam >= 0)
            {
                cantidadHam--;
                txthamb.Text = cantidadHam.ToString();
            }

            incrementar();
        }

        private void btnPMenos_Click(object sender, EventArgs e)
        {
            if (cantidadPapas >= 0)
            {
                cantidadPapas--;
                txtPapas.Text = cantidadPapas.ToString();
            }

            incrementar();
        }

        private void btnPMas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecioPapas.Text))
            {
                MessageBox.Show("Debe Ingresar un monto");
            }
            else
            {
                cantidadPapas++;
                txtPapas.Text = cantidadPapas.ToString();
                incrementar();
            }
        }

        private void btnBMenos_Click(object sender, EventArgs e)
        {
            if (cantidadBebidas >= 0)
            {
                cantidadBebidas--;
                txtBebida.Text = cantidadBebidas.ToString();
            }

            incrementar();
        }

        private void btnBMas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecioBebi.Text))
            {
                MessageBox.Show("Debe Ingresar un monto");
            }
            else
            {

                cantidadBebidas++;
                txtBebida.Text = cantidadBebidas.ToString();
                incrementar();
            }
        }

        private void btnPiMenos_Click(object sender, EventArgs e)
        {
            if (cantidasPizzas >= 0)
            {
                cantidasPizzas--;
                txtPizza.Text = cantidasPizzas.ToString();
            }

            incrementar();

        }

        private void btnPiMas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecioPizz.Text))
            {
                MessageBox.Show("Debe Ingresar un monto");
            }
            else
            {

                cantidasPizzas++;
                txtPizza.Text = cantidasPizzas.ToString();
                incrementar();
            }

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDinero.Text))
            {
                MessageBox.Show("Debe Ingresar un monto");
            }
            else
            {

                dineroCli = double.Parse(txtDinero.Text);

                if (dineroCli >= total)
                {
                    cambio = dineroCli - total;

                    txtCambio.Text = cambio.ToString();
                }
                else
                {
                    MessageBox.Show("El Dinero Ingresado es Insufiente");
                }

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrecioHam.Text = "0";
            txtPrecioBebi.Text = "0";
            txtPrecioPapas.Text = "0";
            txtPrecioPizz.Text = "0";
            txtBebida.Text = "0";
            txtCambio.Text = "0";
            txtDinero.Text = "0";
            txthamb.Text = "0";
            txtPapas.Text = "0";
            txtPizza.Text = "0";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecioHam.Clear();
            txtPrecioBebi.Clear();
            txtPrecioPapas.Clear();
            txtPrecioPizz.Clear();
            txtBebida.Clear();
            txtCambio.Clear();
            txtDinero.Clear();
            txthamb.Clear();
            txtPapas.Clear();
            txtPizza.Clear();
            txtTotal.Clear();
        }
    }

    
}