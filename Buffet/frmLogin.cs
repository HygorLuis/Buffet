using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Buffet
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public static int IdUsuario;

        private bool Login(string user, string password)
        {
            try
            {
                bool bReturn = false;

                using (var connection = new MySqlConnection(Connections.LocalHost))
                {
                    connection.Open();
                    using (var sqlCommand = connection.CreateCommand())
                    {
                        sqlCommand.CommandText = $@"SELECT idusuario, Login, Senha FROM usuario WHERE Login = '{txtLogin.Text}';";
                        var rd = sqlCommand.ExecuteReader();

                        if (rd.Read())
                        {
                            if (rd["Senha"].Equals(txtSenha.Text))
                            {
                                IdUsuario = Convert.ToInt32(rd["idusuario"].ToString());
                                bReturn = true;
                            }
                        }
                    }
                    connection.Close();
                }
                return bReturn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Login(txtLogin.Text, txtSenha.Text))
            {
                var frmConsulta = new FrmConsulta();
                frmConsulta.Show();
                
                Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
