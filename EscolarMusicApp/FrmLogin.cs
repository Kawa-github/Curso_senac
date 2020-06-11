using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolarMusicApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(textBox1.Text, textBox2.Text);
            if (usuario.EfetuarLogin(usuario))
            {
                this.Close();
                //FrmPrincipal frmPrincipal = new FrmPrincipal();
                //frmPrincipal.Show();
                Program.usuarioLogado = usuario;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}