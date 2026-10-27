using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace calculadoraprogra
{
    public partial class Form1 : Form
    {
        float a = 0f, b = 0, resultado = 0;
        int ope = 0, limite = 0;
        char operador = ' ';
        int puntaje = 0;
        int p1 = 0, e1 = 0;
        int puntajegeneral = 0;
        int erroresgeneral = 0;
        int p2 = 0, e2 = 0;
        int turno = 0;
        int errores = 0;
        int turnoactual = 0;
        float resultadocorrecto = 0;
        int[,] datosJugadores = new int[2, 2];

        public Form1()
        {
            InitializeComponent();

            limite = 10;

            Seleccion_Operacion();

            resultadocorrecto = resultado;
            op.Text = operador.ToString();
        }


        private void Seleccion_Operacion()
        {
            a = Random.Shared.Next(1, limite);
            b = Random.Shared.Next(1, limite);
            ope = Random.Shared.Next(1, 5);

            switch (ope)
            {
                case 1:
                    operador = '+';
                    resultado = a + b;
                    break;
                case 2:
                    operador = '-';
                    resultado = a - b;
                    break;
                case 3:
                    operador = '*';
                    resultado = a * b;
                    break;
                case 4:
                    operador = '/';
                    resultado = a / b;
                    break;

                default:
                    operador = '?';
                    break;
            }
            resultadocorrecto = resultado;
            num1.Text = a.ToString();
            num2.Text = b.ToString();
            op.Text = operador.ToString();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Error: Selecciona si jugarás con 1 o 2 jugadores.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.SuppressKeyPress = true;
                    return;
                }
                if (float.TryParse(textBox2.Text, out float resultadousuario))
                {
                    bool esCorrecto = (resultadousuario == resultadocorrecto);

                    if (radioButton1.Checked)
                    {
                        if (esCorrecto)
                        {
                            datosJugadores[0, 0] += 5;
                        }
                        else
                        {
                            datosJugadores[0, 1]++;
                        }

                        puntajej1.Text = datosJugadores[0, 0].ToString();
                        errores1.Text = datosJugadores[0, 1].ToString();
                    }

                    else if (radioButton2.Checked)

                    {
                        if (esCorrecto)
                        {
                            datosJugadores[turno, 0] += 5;
                        }
                        else
                        {
                            datosJugadores[turno, 1]++;
                            turno = (turno == 0) ? 1 : 0;
                        }

                        puntajej1.Text = datosJugadores[0, 0].ToString();
                        errores1.Text = datosJugadores[0, 1].ToString();
                        pj2.Text = datosJugadores[1, 0].ToString();
                        errores2.Text = datosJugadores[1, 1].ToString();
                    }


                    Seleccion_Operacion();
                    textBox2.Clear();
                    e.SuppressKeyPress = true;
                }
            }
        }

     
    }
}