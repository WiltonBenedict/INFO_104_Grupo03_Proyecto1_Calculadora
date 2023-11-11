using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INF0_104_Grupo03_Proyecto1
{
    public partial class Calculadora : System.Web.UI.Page
    {
        //INFO-104. Proyecto 01. Grupo 03.
        /*Integrantes
         * -Jose David Alvarez Vargas-
         * -Jose Pablo Arroyo Villalta-
         * -Wilton Ignacio Benedict Castillo-
         * -Gerardo Jonas Ugarte Navarro-
         * -Prof: Alexander Benjamin Curling-
         */
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btt0_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "0";

        }

        protected void btt1_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "1";
        }

        protected void btt2_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "2";
        }

        protected void btt3_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "3";
        }

        protected void btt4_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "4";
        }

        protected void btt5_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "5";
        }

        protected void btt6_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "6";
        }

        protected void btt7_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "7";
        }

        protected void btt8_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "8";
        }

        protected void btt9_Click(object sender, EventArgs e)
        {
            ValidarControl();
            tDato.Text += "9";
        }

        //METODO IGUAL
        protected void bttIgual_Click(object sender, EventArgs e)
        {
            //Ejemplo
            ValidarControl();
            if (Global.funcion == 1)
            {
                if(tDato.Text.Length == 0)
                {
                    Global.control = true;
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Segundo valor vacio";
                }
                else
                {
                    Global.val2 = double.Parse(tDato.Text);
                    Global.resultado = Global.val1 + Global.val2;
                    tFormula.Text = $"{Global.val1} + {Global.val2}";
                    tDato.Text = $"{Global.resultado}";
                    Global.funcion = 0; //Reinicia la funcion a cero para prevenir que entre en la estructura selectiva de igual.
                    Global.control = true; //Esto previene que se inicie una nueva operacion con numeros en la calculadora
                                           //Si Global.control es true, presionar cualquier otra tecla causara que se borren los datos dentro de los textos para 
                                           //iniciar una nueva operacion.
                }
            }
            else if (Global.funcion == 2)
            {
                if (tDato.Text.Length == 0)
                {
                    Global.control = true;
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Segundo valor vacio";
                }
                else
                {
                    Global.val2 = double.Parse(tDato.Text);
                    Global.resultado = Global.val1 - Global.val2;
                    tFormula.Text = $"{Global.val1} - {Global.val2}";
                    tDato.Text = $"{Global.resultado}";
                    Global.funcion = 0;
                    Global.control = true;
                }
            }
            else if (Global.funcion == 3)
            {
                if (tDato.Text.Length == 0)
                {
                    Global.control = true;
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Segundo valor vacio";
                }
                else
                {
                    Global.val2 = double.Parse(tDato.Text);
                    Global.resultado = Global.val1 * Global.val2;
                    tFormula.Text = $"{Global.val1} * {Global.val2}";
                    tDato.Text = $"{Global.resultado}";
                    Global.funcion = 0;
                    Global.control = true;
                }
            }
            else if (Global.funcion == 4)
            {
                if (tDato.Text.Length == 0)
                {
                    Global.control = true;
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Segundo valor vacio";
                }
                else if (double.Parse(tDato.Text) == 0)
                {
                    tFormula.Text = "Error. No divisible por cero";
                }
                else
                {
                    Global.val2 = double.Parse(tDato.Text);
                    Global.resultado = Global.val1 / Global.val2;
                    tFormula.Text = $"{Global.val1} / {Global.val2}";
                    tDato.Text = $"{Global.resultado}";
                }
                Global.funcion = 0;
                Global.control = true;
            }
            else if (Global.funcion == 5)
            {
                if (tDato.Text.Length == 0)
                {
                    Global.control = true;
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Segundo valor vacio";
                }
                else
                {
                    Global.val2 = double.Parse(tDato.Text);
                    Global.resultado = Math.Pow(Global.val1, Global.val2);
                    tFormula.Text = $"{Global.val1} ^ {Global.val2}";
                    tDato.Text = $"{Global.resultado}";
                    Global.funcion = 0;
                    Global.control = true;
                }
            }
            else if (Global.funcion == -1)
            {
                if (tDato.Text.Length == 0)
                {
                    Global.control = true;
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Segundo valor vacio";
                }
                else
                {
                    Global.val2 = double.Parse(tDato.Text);
                    Global.resultado = -+Global.val2;
                    tFormula.Text = $"- + {Global.val2}";
                    tDato.Text = $"{Global.resultado}";
                    Global.funcion = 0;
                    Global.control = true;
                }
            }
            else if (Global.funcion == -2)
            {
                if (tDato.Text.Length == 0)
                {
                    Global.control = true;
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Segundo valor vacio";
                }
                else
                {
                    Global.val2 = double.Parse(tDato.Text);
                    Global.resultado = Global.val2;
                    tFormula.Text = $"- - {Global.val2}";
                    tDato.Text = $"{Global.resultado}";
                    Global.funcion = 0;
                    Global.control = true;
                }
            }
            else
            {
                tConsola.Text = "Error. Seleccion Invalida";
                Global.control = true;
            }


        }
        
        // OPERACIONES DE DOS VALORES
        protected void bttSuma_Click(object sender, EventArgs e)
        {
            //NOTA: Operaciones de 2 valores Ejemplo
            ValidarControl();
            if(tDato.Text == "-")
            {
                //Excepcion -1. --valor es igual a -valor.
                Global.funcion = -1;
                Global.val1 = 0;
                tDato.Text = string.Empty;
                tConsola.Text = "+";
            }
            else if (tDato.Text.Length > 0)
            {
                Global.funcion = 1;
                //Guarda el valor del texto en val 1, limpia 
                //el label tDato para introducir nuevos datos
                //y asigna funcion 1 que indica a igual que
                //la operacion es una suma
                Global.val1 = double.Parse(tDato.Text);
                tDato.Text = string.Empty;
                tConsola.Text = "+";
            }
            else
            {
                tConsola.Text = "Error. Seleccion Invalida";
                //Mensaje de error en consola que no hay datos
            }
        }

        protected void bttRest_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                //Excepcion -2. --valor es igual a +valor.
                Global.funcion = -2;
                Global.val1 = 0;
                tDato.Text = string.Empty;
                tConsola.Text = "-";
            }
            else if (tDato.Text.Length > 0)
            {
                Global.funcion = 2;
                Global.val1 = double.Parse(tDato.Text);
                tDato.Text = string.Empty;
                tConsola.Text = "-";
            }
            else
            {
                tDato.Text = "-";
            }
        }

        protected void bttMult_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                Global.control = true;
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Opcion invalida";
            }
            else if (tDato.Text.Length > 0)
            {
                Global.funcion = 3;
                Global.val1 = double.Parse(tDato.Text);
                tDato.Text = string.Empty;
                tConsola.Text = "*";
            }
            else
            {
                tConsola.Text = "Error. No hay numeros";
                Global.control = true;
                //Mensaje de error en consola que no hay datos
            }
        }

        protected void bttDiv_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                Global.control = true;
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Opcion invalida";
            }
            else if (tDato.Text.Length > 0)
            {
                Global.funcion = 4;
                Global.val1 = double.Parse(tDato.Text);
                tDato.Text = string.Empty;
                tConsola.Text = "/";
            }
            else
            {
                tConsola.Text = "Error. No hay numeros";
                Global.control = true;
                //Mensaje de error en consola que no hay datos
            }
        }

        protected void bttElevarXY_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                Global.control = true;
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Opcion invalida";
            }
            else if (tDato.Text.Length > 0)
            {
                Global.funcion = 5;
                Global.val1 = double.Parse(tDato.Text);
                tDato.Text = string.Empty;
                tConsola.Text = "x^n";
            }
            else
            {
                tConsola.Text = "Error. Opcion invalida";
                Global.control = true;
                //Mensaje de error en consola que no hay datos
            }
        }

        //OPERACIONES DE UN VALOR
        protected void bttLog_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                Global.control = true;
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Opcion invalida";
            }
            else if (tDato.Text.Length > 0)
            {
                if (double.Parse(tDato.Text) < 0)
                {
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Operacion invalida";
                }
                else
                {
                    Global.control = true;
                    Global.val1 = double.Parse(tDato.Text);
                    tDato.Text = string.Empty;
                    tConsola.Text = "log";
                    Global.resultado = Math.Log(Global.val1,10);
                    tFormula.Text = $"log({Global.val1})";
                    tDato.Text = Global.resultado.ToString();
                }
            }
            else
            {
                tConsola.Text = "Error. No hay numeros";
                //Mensaje de error en consola que no hay datos
            }
        }

        protected void bttElevar10_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                Global.control = true;
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Opcion invalida";
            }
            else if (tDato.Text.Length > 0)
            {
                Global.control = true;
                Global.val1 = double.Parse(tDato.Text);
                tDato.Text = string.Empty;
                tConsola.Text = "log";
                Global.resultado = Math.Pow(10, Global.val1);
                tFormula.Text = $"10^{Global.val1}";
                tDato.Text = Global.resultado.ToString();
            }
            else
            {
                tConsola.Text = "Error. No hay numeros";
                //Mensaje de error en consola que no hay datos
            }
        }

        protected void bttRaiz_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Opcion invalida";
            }
            else if (tDato.Text.Length > 0)
            {
                if (double.Parse(tDato.Text) < 0)
                {
                    tDato.Text = string.Empty;
                    tConsola.Text = "Error. Operacion invalida";
                }
                else
                {
                    Global.control = true;
                    Global.val1 = double.Parse(tDato.Text);
                    tDato.Text = string.Empty;
                    tConsola.Text = "√";
                    Global.resultado = Math.Sqrt(Global.val1);
                    tFormula.Text = $"√{Global.val1}";
                    tDato.Text = Global.resultado.ToString();
                }
            }
            else
            {
                tConsola.Text = "Error. No hay numeros";
                Global.control = true;
                //Mensaje de error en consola que no hay datos
            }
        }

        protected void bttFactorial_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                Global.control = true;
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Opcion invalida";
            }
            else if(tDato.Text.Length == 0)
            {
                tConsola.Text = "Error. No hay numeros";
                Global.control = true;
            }
            else if (double.Parse(tDato.Text) < 0)
            {
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Operacion invalida";
            }
            else if (double.Parse(tDato.Text) > 0)
            {
                Global.val1 = double.Parse(tDato.Text);
                double i = Global.val1;
                double acumulador = 0;
                while (i != 1)
                {
                    if (Global.val1 == i)
                    {
                        i = i - 1;
                        acumulador = Global.val1 * i;
                    }
                    else
                    {
                        i = i - 1;
                        acumulador = acumulador * i;
                    }
                }
                Global.control = true;
                tDato.Text = string.Empty;
                tConsola.Text = "!";
                Global.resultado = acumulador;
                tFormula.Text = $"{Global.val1}!";
                tDato.Text = $"{Global.resultado}";
            }
            else
            {
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Operacion invalida";
                //Error al intentar usar 0 en la operacion
            }
        }

        protected void bttElevar2_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text == "-")
            {
                Global.control = true;
                tDato.Text = string.Empty;
                tConsola.Text = "Error. Opcion invalida";
            }
            else if (tDato.Text.Length > 0)
            {
                Global.control = true;
                Global.val1 = double.Parse(tDato.Text);
                tDato.Text = string.Empty;
                tConsola.Text = "x²";
                Global.resultado = Math.Pow(Global.val1,2);
                tFormula.Text = $"{Global.val1}²";
                tDato.Text = Global.resultado.ToString();
            }
            else
            {
                tConsola.Text = "Error. No hay numeros";
                //Mensaje de error en consola que no hay datos
            }
        }

        //METODOS DE CONCATENACION
        protected void bttMasMenos_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text.Contains('-'))
            {
                tDato.Text = tDato.Text.Substring(1);
                //Se asume que - esta al principio del string y lo elimina
            }
            else
            {
                tDato.Text = "-" + tDato.Text;
                //Agrega el menos al principio del string
            }
        }

        protected void bttcomma_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text.Contains("."))
            {
                tConsola.Text = "Accion no posible";
                //Excepcion para prevenir un numero con varios puntos
            }
            else if (tDato.Text.Contains('-') && tDato.Text.Length == 1)
            {
                tConsola.Text = "Accion no posible";
                //Excepcion para prevenir (-,)
            }
            else
            {
                tDato.Text = tDato.Text + ".";
            }
        }

        protected void bttRemover_Click(object sender, EventArgs e)
        {
            ValidarControl();
            if (tDato.Text.Length == 0)
            {
                tConsola.Text = "Nada que remover";
            }
            else
            {
                //Se remueve el ultimo caracter del string
                tDato.Text = tDato.Text.Substring(0, tDato.Text.Length - 1);
            }
        }

        protected void bttBorrar_Click(object sender, EventArgs e)
        {
            //Limpia todas las variables
            ReiniciarVariables();
        }
        
        private void ValidarControl()
        {
            if(Global.control == true)
            {
                //Se activa solo en caso una operacion ya fue completada y se necesita despejar los campos de texto.
                ReiniciarVariables();
            }
            else if(tDato.Text == ".")
            {
                tDato.Text = "0";
                //Cuando una calculadora solo detecta ".", lo considera como 0.
            }
            else if(tConsola.Text.Length > 0 && Global.funcion == 0)
            {
                tConsola.Text = string.Empty;
            }
        }

        private void ReiniciarVariables()
        {
            tFormula.Text = string.Empty;
            tDato.Text = string.Empty;
            tConsola.Text = string.Empty;
            Global.funcion = 0;
            Global.val1 = 0;
            Global.val2 = 0;
            Global.resultado = 0;
            Global.control = false;
        }
    }
}