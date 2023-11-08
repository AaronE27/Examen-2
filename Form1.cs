namespace Converciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double peso, dolarusa, dolarca, euro, yen, cambio, ingreso;


            //Converciones peso
            if (comboBox1.SelectedItem == "MXN - Peso mexicano")
            {
                ingreso = Convert.ToDouble(textBox1.Text);
                dolarusa = ingreso / 20;
                dolarca = ingreso / 16.66;
                euro = ingreso / 25;
                yen = ingreso / 0.18796;
                lblpeso.Visible = true;
                lblcad.Visible = true;
                lblusa.Visible = true;
                lblyen.Visible = true;
                lbleu.Visible = true;
                txtdolarcan.Visible = true;
                txtdolarusa.Visible = true;
                txteuro.Visible = true;
                txtpesos.Visible = true;
                txtyen.Visible = true;

                
                txtpesos.Text = "$ " + ingreso.ToString();
                txtdolarusa.Text = "$ " + dolarusa.ToString();   
                txteuro.Text = "€ " + euro.ToString();
                txtdolarcan.Text = "$ " + dolarca.ToString();
                txtyen.Text = "¥ " + yen.ToString();
            } 
            // dolar Usa
            if (comboBox1.SelectedItem == "USD - Dolar Estadounidense")
            {
                ingreso = Convert.ToDouble(textBox1.Text);
                peso = ingreso / 0.04710316;
                dolarca = ingreso / 0.78125;
                euro = ingreso / 1.12359551;
                yen = ingreso / 0.00884564;




                lblpeso.Visible = true;
                lblcad.Visible = true;
                lblusa.Visible = true;
                lblyen.Visible = true;
                lbleu.Visible = true;
                txtdolarcan.Visible = true;
                txtdolarusa.Visible = true;
                txteuro.Visible = true;
                txtpesos.Visible = true;
                txtyen.Visible = true;


                txtpesos.Text = "$ " + peso.ToString();
                txtdolarusa.Text = "$ " + ingreso.ToString();
                txteuro.Text = "€ " + euro.ToString();
                txtdolarcan.Text = "$ " + dolarca.ToString();
                txtyen.Text = "¥ " + yen.ToString();


            }
            // dolar Canada
            if (comboBox1.SelectedItem == "CAD - Dolar canadiense")
            {
                ingreso = Convert.ToDouble(textBox1.Text);
                peso = ingreso / 0.06042296;
                dolarusa = ingreso / 1.28205128;
                euro = ingreso / 1.44927536;
                yen = ingreso / 0.01134816;

                lblpeso.Visible = true;
                lblcad.Visible = true;
                lblusa.Visible = true;
                lblyen.Visible = true;
                lbleu.Visible = true;
                txtdolarcan.Visible = true;
                txtdolarusa.Visible = true;
                txteuro.Visible = true;
                txtpesos.Visible = true;
                txtyen.Visible = true;


                txtpesos.Text = "$ " + peso.ToString();
                txtdolarusa.Text = "$ " + dolarusa.ToString();
                txteuro.Text = "€ " + euro.ToString();
                txtdolarcan.Text = "$ " + ingreso.ToString();
                txtyen.Text = "¥ " + yen.ToString();

            }
            // dolar Ceuro
            if (comboBox1.SelectedItem == "EUR - Euro")
            {
                ingreso = Convert.ToDouble(textBox1.Text);
                peso = ingreso / 0.04173623;
                dolarca = 0.68965517;
                dolarusa = ingreso / 0.88495575;
                yen = ingreso / 0.00783945;

                lblpeso.Visible = true;
                lblcad.Visible = true;
                lblusa.Visible = true;
                lblyen.Visible = true;
                lbleu.Visible = true;
                txtdolarcan.Visible = true;
                txtdolarusa.Visible = true;
                txteuro.Visible = true;
                txtpesos.Visible = true;
                txtyen.Visible = true;


                txtpesos.Text = "$ " + peso.ToString();
                txtdolarusa.Text = "$ " + dolarusa.ToString();
                txteuro.Text = "€ " + ingreso.ToString();
                txtdolarcan.Text = "$ " + dolarca.ToString();
                txtyen.Text = "¥ " + yen.ToString();

            }
            // dolar yen
            if (comboBox1.SelectedItem == "JPY - Yen Japones")
            {
                ingreso = Convert.ToDouble(textBox1.Text);
                peso = ingreso / 5.32481363;
                dolarusa = ingreso / 113.636364;
                euro = ingreso / 128.205128;
                dolarca = ingreso / 84.4955752;
                lblpeso.Visible = true;
                lblcad.Visible = true;
                lblusa.Visible = true;
                lblyen.Visible = true;
                lbleu.Visible = true;
                txtdolarcan.Visible = true;
                txtdolarusa.Visible = true;
                txteuro.Visible = true;
                txtpesos.Visible = true;
                txtyen.Visible = true;


                txtpesos.Text = "$ " + peso.ToString();
                txtdolarusa.Text = "$ " + dolarusa.ToString();
                txteuro.Text = "€ " + euro.ToString();
                txtdolarcan.Text = "$ " + dolarca.ToString();
                txtyen.Text = "¥ " + ingreso.ToString();

            }
        }
    }
}