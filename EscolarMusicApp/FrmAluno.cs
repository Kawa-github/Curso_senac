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
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = cmbSexo.Text;
            sexo = sexo.Substring(0, 1);
            Aluno aluno = new Aluno(
                txtNome.Text,txtCpf.Text,sexo,txtEmail.Text,txtTelefone.Text
                );
            aluno.Inserir(aluno);
            MessageBox.Show("Aluno inserido com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Aluno aluno = new Aluno();
            foreach (var item in aluno.ListarAlunos())
            {
                listBox2.Items.Add(item.Id + " - " + item.Nome + " - " +
                    item.Email + " - " + item.DataCadastro);
            }
        }
        private void LimparCampos() 
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            cmbSexo.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtId.ReadOnly==true)
            {
                txtId.ReadOnly = false;
                button3.Text = "Buscar";
              
                txtId.Focus();
                LimparCampos();
            }
            else 
            {
                if (txtId.Text != string.Empty)
                {
                    Aluno aluno = new Aluno();
                    aluno.ObterPorId(int.Parse(txtId.Text));
                    if (aluno.Id > 0)
                    {
                        txtNome.Text = aluno.Nome;
                        txtCpf.Text = aluno.Cpf;
                        txtEmail.Text = aluno.Email;
                        txtTelefone.Text = aluno.Telefone;
                        if (aluno.Sexo == "M")
                        {
                            cmbSexo.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbSexo.SelectedIndex = 1;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Aluno não cadastrado!");
                    }
                    txtId.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Digite um código para buscar...");
                    txtId.Focus();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sexo = cmbSexo.Text;
            sexo = sexo.Substring(0, 1);
            Aluno aluno = new Aluno();
            aluno.Id = int.Parse(txtId.Text);
            aluno.Nome = txtNome.Text;
            aluno.Sexo = sexo;
            aluno.Telefone = txtTelefone.Text;
            aluno.Alterar(aluno);
            MessageBox.Show("Aluno Alterado com sucesso!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
