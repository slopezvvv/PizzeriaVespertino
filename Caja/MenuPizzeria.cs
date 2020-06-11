using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class MenuPizzeria : Form
    {
        public MenuPizzeria()
        {
            InitializeComponent();
        }

        private void MenuPizzeria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCajero.Cajero' Puede moverla o quitarla según sea necesario.
            this.cajeroTableAdapter.Fill(this.dataSetCajero.Cajero);

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuAdmin().Visible = true;
        }
    }
}
