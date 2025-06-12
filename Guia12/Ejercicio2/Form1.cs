using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Declarando e iniciando el formulario 2

            FormModal FDialogo = new FormModal();

            //Inicializando ventana2- Mostrar el valor de tbvalor en lbvalor de la Modal

            FDialogo.lbMostrarValor.Text = tbValor.Text;

            //Mostrar Ventana Modal
            
            if (FDialogo.ShowDialog() == DialogResult.OK)
            {
                
                FDialogo.Close();//Si se presiona el boton "Aceptar" se cierra la ventana 2
                tbValor.Clear(); //borra el valor del textbox de la ventana 1
            }
            else
            {
                //Si se presiona el boton "Cancelar" se cierra la ejecucion.
                Close();
            }

        }
    }
}
