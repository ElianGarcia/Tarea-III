using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_III.Tarea_III;

namespace Tarea_3
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void TiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tienda tienda = new Tienda();
            tienda.MdiParent = this;
            tienda.Show();
        }

        private void PersonaYMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonayMascota personayMascota = new PersonayMascota();
            personayMascota.MdiParent = this;
            personayMascota.Show();
        }

        private void EstrellasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Neumaticos neumaticos = new Neumaticos();
            neumaticos.MdiParent = this;
            neumaticos.Show();
        }

        private void InventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioTienda inventarioTienda = new InventarioTienda();
            inventarioTienda.MdiParent = this;
            inventarioTienda.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.MdiParent = this;
            estudiantes.Show();
        }
    }
}
