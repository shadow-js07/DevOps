using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string resultado = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            resultado += "+";
            label1.Text = resultado;

        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            resultado += "-";
            label1.Text = resultado;

        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            resultado += ".";
            label1.Text = resultado;

        }

        private void botonResultado_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(resultado, null).ToString();
                label1.Text = result;
                resultado = result;  
            }
            catch (Exception ex)
            {
                label1.Text = "Sintax error";
                resultado = "";
            }

        }

        private void boton6_Click(object sender, EventArgs e)
        {
            resultado += "6";
            label1.Text = resultado;
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            resultado += "5";
            label1.Text = resultado;
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            resultado += "4";
            label1.Text = resultado;
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            resultado += "9";
            label1.Text = resultado;
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            resultado += "8";
            label1.Text = resultado;
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            resultado += "7";
            label1.Text = resultado;
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            resultado += "/";
            label1.Text = resultado;
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            resultado += "*";
            label1.Text = resultado;
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            resultado += "0";
            label1.Text = resultado;
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            resultado += "2";
            label1.Text = resultado;
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            resultado += "1";
            label1.Text = resultado;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            resultado = "";
            label1.Text = "";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            resultado += "3";
            label1.Text = resultado;
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (resultado.Length > 0)
            {
                resultado = resultado.Substring(0, resultado.Length - 1);
                label1.Text = resultado;
            }
        }
    }
}
