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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar uma instância de Form (FrmAluno)
            FrmAluno frmAluno = new FrmAluno();
            frmAluno.MdiParent = this;
            frmAluno.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar uma instância de Form (FrmProfessor)
            FrmProfessor frmProfessor = new FrmProfessor();
            frmProfessor.MdiParent = this;
            frmProfessor.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //criar uma instância de Form para efetuar o login do usuário.
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            if (Program.usuarioLogado != null)
            {
                Text = "FrmPrincipal - " + Program.usuarioLogado.Nome_user;
            }

        }

        private void matrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar uma instância de Form (FrmMatricula)
            FrmMatricula frmMatricula = new FrmMatricula();
            frmMatricula.MdiParent = this;
            frmMatricula.Show();
        }
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar uma instância de Form (FrmCurso)
            FrmCurso frmCurso = new FrmCurso();
            frmCurso.MdiParent = this;
            frmCurso.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar uma instância de Form (FrmUsuario)
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da sua conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (Program.usuarioLogado != null)
                {
                    Text = "FrmPrincipal - " + Program.usuarioLogado.Nome_user;
                }
            }
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        
    }
}
