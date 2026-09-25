using SistemaBancario.BE;
using SistemBancario.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.UI
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

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                Usuario usuario = usuarioBLL.IniciarSesion(
                    txtUsuario.Text,
                    txtContrasena.Text);

                MessageBox.Show(
                    "Bienvenido/a " +
                    usuario.Nombre + " " +
                    usuario.Apellido +
                    "\nRol: " + usuario.Rol,
                    "Inicio de sesión correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error de inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
