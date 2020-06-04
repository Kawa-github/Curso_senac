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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            Usuario usuario = new Usuario();
            foreach (var item in usuario.ListarUsuarios())
            {
                listBox4.Items.Add(item.Id_user + " - " + item.Nome_user + " - " +
                    item.Email_user + " - " + item.Situacao_user);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtId_user.Clear();
            txtNome_user.Clear();
            txtEmail_user.Clear();
            txtSituacao_user.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtId_user.ReadOnly == true)
            {
                txtId_user.ReadOnly = false;
                button3.Text = "Buscar";
                txtId_user.Focus();
                LimparCampos();
            }
            else
            {
                if (txtId_user.Text != string.Empty)
                {
                    Usuario usuario = new Usuario();
                    usuario.ObterPorId(int.Parse(txtId_user.Text));
                    if (usuario.Id_user > 0)
                    {
                        txtNome_user.Text = usuario.Nome_user;
                        txtEmail_user.Text = usuario.Email_user;
                        txtSituacao_user.Text = usuario.Situacao_user;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não cadastrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Digite um ID existente para buscar!");
                    txtId_user.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
            txtNome_user.Text,txtEmail_user.Text,txtSenha_user.Text,txtSituacao_user.Text);
            usuario.InserirUser(usuario);
            MessageBox.Show("Usuário inserido com sucesso!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id_user = int.Parse(txtId_user.Text);
            usuario.Nome_user = txtNome_user.Text;
            usuario.AlterarUser(usuario);
            MessageBox.Show("Usuário alterado com sucesso!");
        }
    }
    
}
