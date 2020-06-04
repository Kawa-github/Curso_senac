using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolarMusicApp
{
    public class Curso
    {
        public int Id_course { get; set; } //Id do curso. Ex: 5
        public string Nome_course { get; set; } //Nome do curso. Ex: Administração
        public string Carga_course { get; set; } //Carga do curso. Ex: 350 horas
        public string Valor_course { get; set; } //Valor do curso: Ex: R$1,500

        public Curso()
        {
        }

        public Curso(int id_course, string nome_course, string carga_course, string valor_course) //Método construtor
        {
            Id_course = id_course;
            Nome_course = nome_course;
            Carga_course = carga_course;
            Valor_course = valor_course;
        }

        public Curso(string nome_course, string carga_course, string valor_course) //Método construtor
        {
            Nome_course = nome_course;
            Carga_course = carga_course;
            Valor_course = valor_course;
        }


        public void InserirCourse(Curso curso) //Método para inserção das informações no banco de dados
        {
            MySqlCommand cmd = Banco.Conexao();
            cmd.CommandText = "insert tb_curso values(null, @nome_curso, @carga_horaria_curso, @valor_curso);";
            cmd.Parameters.Add("@nome_curso", MySqlDbType.VarChar).Value = curso.Nome_course;
            cmd.Parameters.Add("@carga_horaria_curso", MySqlDbType.Int32).Value = curso.Carga_course;
            cmd.Parameters.Add("@valor_curso", MySqlDbType.VarChar).Value = curso.Valor_course;
            cmd.ExecuteNonQuery();

        }

        public void AlterarCourse(Curso curso)
        {
            MySqlCommand cmd = Banco.Conexao();
            cmd.CommandText = "update tb_curso set nome_curso=@nome_curso, carga_horaria_curso=@carga_horaria_curso where id_curso =@id_curso";
            cmd.Parameters.Add("@nome_curso", MySqlDbType.VarChar).Value = curso.Nome_course;
            cmd.Parameters.Add("@id_curso", MySqlDbType.Int32).Value = curso.Id_course;
            cmd.Parameters.Add("carga_horaria_curso", MySqlDbType.VarChar).Value = curso.Carga_course;
            cmd.ExecuteNonQuery();
        }

        public List<Curso> ListarCursos()
        {
            List<Curso> cursos = new List<Curso>();
            var cmd = Banco.Conexao();
            cmd.CommandText = "select * from tb_curso ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cursos.Add(
                    new Curso(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3)
                        ));
            }
            return cursos;
        }

        public void ObterPorId(int id_curso)
        {
            var cmd = Banco.Conexao();
            cmd.CommandText = "select * from tb_curso where id_curso = " + id_curso;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id_course = dr.GetInt32(0);
                Nome_course = dr.GetString(1);
                Carga_course = dr.GetString(2);
                Valor_course = dr.GetString(3);
            }
        }

    }
}
