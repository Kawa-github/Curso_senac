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
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            var listaAluno = aluno.ListarAlunos();
            cmbAluno.DataSource = listaAluno;
            cmbAluno.DisplayMember = "Nome";
            cmbAluno.ValueMember = "Id";

            // preenche o combobox cmbCurso com a lista dos cursos, e valorado com ID
            Curso curso = new Curso();
            var listaCurso = curso.ListarCursos();
            cmbCurso.DataSource = listaCurso;
            cmbCurso.DisplayMember = "Nome_course";
            cmbCurso.ValueMember = "Id_course";

            //// preenche o datagrid com os dados das matrículas ativas ()
            //dgvMatricula.Rows.Clear();
            //Matricula matricula = new Matricula();
            //DataTable dt = new DataTable();
            //dt.Load(matricula.ListarAtivas());
            //dgvMatricula.DataSource = dt;
            //var dr = matricula.ListarAtivas();
            //int i = 0;
            //while (dr.Read())
            //{
            //    dgvMatricula.Rows.Add();
            //    dgvMatricula.Rows[i].Cells[0].Value = dr.GetValue(0);
            //    dgvMatricula.Rows[i].Cells[1].Value = dr.GetValue(1);
            //    dgvMatricula.Rows[i].Cells[2].Value = dr.GetValue(2);
            //    dgvMatricula.Rows[i].Cells[3].Value = dr.GetValue(3);
            //    i++;
            //}
        }
        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.ObterPorId(Convert.ToInt32(cmbAluno.SelectedValue));
            Curso curso = new Curso();
            curso.ObterPorId(Convert.ToInt32(cmbCurso.SelectedValue));
            Matricula matricula = new Matricula();
            matricula.Inserir(aluno, curso, Program.usuarioLogado);
            MessageBox.Show("Matrícula realizada com sucesso.");
            FrmMatricula_Load(sender, e);

        }

    }

}
