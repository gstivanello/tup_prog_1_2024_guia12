﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            FormModal FModal = new FormModal();
            if (FModal.ShowDialog() == DialogResult.OK)
            {
                lbMostrarValor.Text = FModal.tbValor.Text;

            }
            else
            {
                lbMostrarValor.Text = "valor cancelado";
            }
        }
    }
}
