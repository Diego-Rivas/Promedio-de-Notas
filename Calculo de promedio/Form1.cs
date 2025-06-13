using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_promedio
{
    public partial class Form1 : Form
    {
        double nota_uno, nota_dos, nota_tres, promedio;

        private void btnAgre_prome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNota_uno.Text) || string.IsNullOrEmpty(txtNota_dos.Text) || string.IsNullOrEmpty(txtNota_tres.Text))
            {
                lblError.Text = "Existe un campo vacio\npor favor ingresa el dato que falta";
            }
            else
            {
                double.TryParse(txtNota_uno.Text, out nota_uno);
                double.TryParse(txtNota_dos.Text, out nota_dos);
                double.TryParse(txtNota_tres.Text, out nota_tres);
                if (nota_uno < 0 || nota_uno > 10 || nota_dos < 0 || nota_dos > 10 || nota_tres < 0 || nota_tres > 10)
                    {
                    lblError.Text = "Por favor ingresa un valor entre 0 y 10";
                    
                    }
                    else
                    {
                    promedio = (nota_uno + nota_dos + nota_tres) / 3;
                    txtPromedio.Text = promedio.ToString("N2");

                    lblError.Text = string.Empty;
                }
            }
            txtNota_tres.ReadOnly = true;
            txtNota_tres.ReadOnly = true;
            txtNota_tres.ReadOnly = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Regis_Click(object sender, EventArgs e)
        {
            txtNota_tres.ReadOnly = false;
            txtNota_tres.ReadOnly = false;
            txtNota_tres.ReadOnly = false;
            txtNota_uno.Clear();
            txtNota_dos.Clear();
            txtNota_tres.Clear();
            txtPromedio.Clear();
        }
    }
}
