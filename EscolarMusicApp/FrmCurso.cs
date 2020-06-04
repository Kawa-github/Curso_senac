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
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Curso curso = new Curso();

            foreach (var item in curso.ListarCursos())
            {
                listBox1.Items.Add(item.Id_course + " - " + item.Nome_course + " - " + item.Carga_course + " Horas" + " - " + "R$ " + item.Valor_course);
            }

        }
       
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void LimparCampos()
        {
            txtId_course.Clear();
            txtNome_course.Clear();
            txtCarga_course.Clear();
            txtValor_course.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtId_course.ReadOnly == true)
            {
                txtId_course.ReadOnly = false;
                button3.Text = "Buscar";
                txtId_course.Focus();
                LimparCampos();
            }
            else
            {
                if (txtId_course.Text != string.Empty)
                {
                    Curso curso = new Curso();
                    curso.ObterPorId(int.Parse(txtId_course.Text));
                    if (curso.Id_course > 0)
                    {
                        txtNome_course.Text = curso.Nome_course;
                        txtCarga_course.Text = curso.Carga_course;
                        txtValor_course.Text = curso.Valor_course;
                    }
                    else
                    {
                        MessageBox.Show("Curso não cadastrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Digite um ID existente para buscar!");
                    txtId_course.Focus();
                }
            }
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(txtNome_course.Text, txtCarga_course.Text, txtValor_course.Text);
            curso.InserirCourse(curso);
            MessageBox.Show("Curso inserido com sucesso!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Id_course = int.Parse(txtId_course.Text);
            curso.Nome_course = txtNome_course.Text;
            curso.Carga_course = txtCarga_course.Text;
            curso.AlterarCourse(curso);
            MessageBox.Show("Curso alterado com sucesso!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
