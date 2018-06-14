using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Sesion;
using System;
using System.Windows.Forms;

namespace FrigLab.View.Usuarios {
    public partial class LoginForm:Form {
		
		private int intento = 0;
        private int padron;
        private string password;

        public LoginForm() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
			Application.Exit();
        }

        private bool CargarVerificarDatos() {
            try {
                padron = int.Parse(txtUsuario.Text);
            } catch(Exception) {
                MessageBox.Show("El padron no es valido.");
                return false;
            }
            password = txtPass.Text;
            if(string.IsNullOrEmpty(password)) {
                MessageBox.Show("Se debe ingresar un password.");
                return false;
            }
            return true;
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            if(CargarVerificarDatos()) {
                if(intento < 3) {
                    Usuario usuario = SesionDeUsuario.IniciarSesion(padron, password);

                    if(usuario != null) {
                        if(usuario.FechaNoVigente != null) {
                            MessageBox.Show("Este usuario no se encuentra autorizado.");
                            Application.Exit();
                        } else {
                            this.Dispose();
                            new MainForm().ShowDialog();
                        }
                    } else {
                        MessageBox.Show("No es correcto!");
                        intento++;
                    }
                } else {
                    MessageBox.Show("No está autorizado, contacte con un administrador.");
                    Application.Exit();
                }
            }
        }
    }
}