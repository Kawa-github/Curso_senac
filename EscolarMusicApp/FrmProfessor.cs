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
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Professor professor = new Professor();
            foreach (var item in professor.ListarProf())
            {
                listBox3.Items.Add(item.Id_prof + " - " + item.Nome_prof + " - " +
                    item.Email_prof + " - " + item.DataCadastro_prof);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtId_prof.ReadOnly == true)
            {
                txtId_prof.ReadOnly = false;
                button3.Text = "Buscar";
                txtId_prof.Focus();
            }
            else
            {
                if (txtId_prof.Text != string.Empty)
                {
                    Professor professor = new Professor();
                    professor.ObterPorId(int.Parse(txtId_prof.Text));
                    if (professor.Id_prof > 0)
                    {
                        txtNome_prof.Text = professor.Nome_prof;
                        txtCpf_prof.Text = professor.Cpf_prof;
                        txtEmail_prof.Text = professor.Email_prof;
                        txtTel_prof.Text = professor.Tel_prof;
                    }
                    else
                    {
                        MessageBox.Show("Professor não cadastrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Digite um ID existente para buscar!");
                    txtId_prof.Focus();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Id_prof = int.Parse(txtId_prof.Text);
            professor.Nome_prof = txtNome_prof.Text;
            professor.Tel_prof = txtTel_prof.Text;
            professor.AlterarProf(professor);
            MessageBox.Show("Professor alterado com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor(txtNome_prof.Text, txtCpf_prof.Text,txtEmail_prof.Text, txtTel_prof.Text);
            professor.InserirProf(professor);
            MessageBox.Show("Professor inserido com sucesso!");
        }
    }
}
