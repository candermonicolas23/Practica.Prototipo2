using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practica.Prototipo2.PracticaPrototipo
{
    public partial class PracticaForm : Form
    {
        private readonly PracticaModelo modelo = new();
        public PracticaForm()
        {
            InitializeComponent();
        }

    }
}
