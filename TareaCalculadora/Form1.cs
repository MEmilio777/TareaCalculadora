namespace TareaCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool S = true;
        double Numero1,resultado,Numero2;
        string tipo,Borrado;

        private void num1_Click(object sender, EventArgs e)
        {
        
            if(S == true)
            {
                PantallaPrincipal.Text = "1";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (S == true)
            {
                PantallaPrincipal.Text = "2";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (S == true)
            {
                PantallaPrincipal.Text = "3";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (S == true)
            {
                PantallaPrincipal.Text = "4";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (S == true)
            {
                PantallaPrincipal.Text = "5";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (S == true)
            {
                PantallaPrincipal.Text = "6";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (S == true)
            {
                PantallaPrincipal.Text = "7";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (S == true)
            {
                PantallaPrincipal.Text = "8";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text = "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (S == true)
            {
                PantallaPrincipal.Text = "9";
                S = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "9";
            }
        }

        private void cero_Click(object sender, EventArgs e)
        {
            if (PantallaPrincipal.Text == "0")
            {
                PantallaPrincipal.Text = "0";
               
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "0";
            }
        }

        private void doblecero_Click(object sender, EventArgs e)
        {
            if (PantallaPrincipal.Text == "0")
            {
                PantallaPrincipal.Text = "0";

            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "00";
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            tipo = "+";
            Numero1 = double.Parse(PantallaPrincipal.Text);
            PantallaAnterior.Text = PantallaPrincipal.Text + "+";
            S = true;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            tipo = "-";
            Numero1 = double.Parse(PantallaPrincipal.Text);
            PantallaAnterior.Text = PantallaPrincipal.Text + "-";
            S = true;
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            tipo = "";
            Numero1 = double.Parse(PantallaPrincipal.Text);
            PantallaAnterior.Text = PantallaPrincipal.Text + "*";
            S = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            tipo = "/";
            Numero1 = double.Parse(PantallaPrincipal.Text);
            PantallaAnterior.Text = PantallaPrincipal.Text + "/";
            S = true;
        }

        private void retroceder_Click(object sender, EventArgs e)
        {
            int contador = 0;
            Borrado = PantallaPrincipal.Text;
            contador = Borrado.Length - 1;
            Borrado = Borrado.Substring(0, contador);
            PantallaPrincipal.Text = Borrado;

            if(PantallaPrincipal.Text == "")
            {
                PantallaPrincipal.Text = "0";
                S = true;
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            Numero2 = double.Parse(PantallaPrincipal.Text);

            if (tipo == "*")
            {
                resultado = Numero1 * Numero2;
                PantallaAnterior.Text = "=" + PantallaAnterior.Text + Numero2.ToString();
                PantallaPrincipal.Text = resultado.ToString();
            }

            if (tipo == "-")
            {
                resultado = Numero1 - Numero2;
                PantallaAnterior.Text = "=" + PantallaAnterior.Text + Numero2.ToString();
                PantallaPrincipal.Text = resultado.ToString();
            }

            if (tipo == "+")
            {
                resultado = Numero1 + Numero2;
                PantallaAnterior.Text = "=" + PantallaAnterior.Text + Numero2.ToString();
                PantallaPrincipal.Text = resultado.ToString();
            }
            if (tipo == "/")
            {
                resultado = Numero1 / Numero2;
                PantallaAnterior.Text = "=" + PantallaAnterior.Text + Numero2.ToString();
                PantallaPrincipal.Text = resultado.ToString();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.Text = "0";
            PantallaAnterior.Text="";
            S = true;
        }

        private void elevacion2_Click(object sender, EventArgs e)
        {
            Numero1 = double.Parse(PantallaPrincipal.Text);
            resultado = Numero1 * Numero1;
            PantallaAnterior.Text = "=" + PantallaPrincipal.Text;
            PantallaPrincipal.Text = resultado.ToString();
        }
    }
}