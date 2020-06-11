using Caja.DataSetCajeroTableAdapters;
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
    public partial class MenuAdmin : Form
    {
        private static Dictionary<int, Cajero> _cajeros = new Dictionary<int, Cajero>();

        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCajero.Cajero' Puede moverla o quitarla según sea necesario.
            this.cajeroTableAdapter.Fill(this.dataSetCajero.Cajero);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = txtPass.Text.Trim(), repetir = txtRepetir.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string sRut = txtRut.Text.Trim();

                int rut = -1;

                if (!int.TryParse(sRut, out rut))
                {
                    MessageBox.Show("El rut no es válido");
                    txtRut.Text = string.Empty;
                    txtDigito.Text = string.Empty;
                    txtRut.Focus();
                    return;
                }
                if (nombre.Length >= 50)
                {
                    MessageBox.Show("El nombre no puede superar los 50 caracteres.");
                    txtNombre.Text = string.Empty;
                    txtNombre.Focus();
                    return;
                }
                if (pass != repetir)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtPass.Text = string.Empty;
                    txtRepetir.Text = string.Empty;
                    txtPass.Focus();
                    return;
                }

                Cajero cajero = new Cajero();
                cajero.nombre = nombre;
                cajero.rut = rut;
                cajero.pass = pass;

                CajeroTableAdapter ta = new CajeroTableAdapter();
                ta.Insert(cajero.rut, cajero.nombre, cajero.pass);
            }
            catch(Exception ex)
            {
                MessageBox.Show("El cajero ya existe");
                clear();
                Console.WriteLine(ex.Message);
            }
        }

        private void clear()
        {
            txtRut.Text = string.Empty;
            txtDigito.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtRepetir.Text = string.Empty;
            txtRut.Focus();
        }

        private bool isEnter(int tecla)
        {
            return tecla == 13;
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(isEnter((int)e.KeyChar))
                txtDigito.Focus();
            
        }

        private void txtDigito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isEnter((int)e.KeyChar))
                txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isEnter((int)e.KeyChar))
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isEnter((int)e.KeyChar))
                txtRepetir.Focus();
        }

        private void txtRepetir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isEnter((int)e.KeyChar))
                btnAgregar_Click(sender, e);
        }
    }
}
