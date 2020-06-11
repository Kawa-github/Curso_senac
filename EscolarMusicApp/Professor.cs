using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace EscolarMusicApp
{
    public class Professor
    {

        public int Id_prof { get; set; }
        public string Nome_prof { get; set; }
        public string Cpf_prof { get; set; }
        public string Email_prof { get; set; }
        public string Tel_prof { get; set; }
        public DateTime DataCadastro_prof { get; set; }

        public Professor(int id_prof, string nome_prof, string cpf_prof, string email_prof, string tel_prof, DateTime dataCadastro_prof)
        {//Método construtor
            Id_prof = id_prof;
            Nome_prof = nome_prof;
            Cpf_prof = cpf_prof;
            Email_prof = email_prof;
            Tel_prof = tel_prof;
            DataCadastro_prof = dataCadastro_prof;
        }

        public Professor()
        {
        }

        public Professor(string nome_prof, string cpf_prof, string email_prof, string tel_prof)
        {
            Nome_prof = nome_prof;
            Cpf_prof = cpf_prof;
            Email_prof = email_prof;
            Tel_prof = tel_prof;
        }


        public void InserirProf(Professor professor) // Método para inserção das informações no banco de dados MySql.
        {
            MySqlCommand cmd = Banco.Conexao();
            cmd.CommandText = "insert tb_professor values(null, @nome_professor, @cpf_professor, @email_professor, @telefone_professor, default);";
            cmd.Parameters.Add("@nome_professor", MySqlDbType.VarChar).Value = professor.Nome_prof;
            cmd.Parameters.Add("@cpf_professor", MySqlDbType.VarChar).Value = professor.Cpf_prof;
            cmd.Parameters.Add("@email_professor", MySqlDbType.VarChar).Value = professor.Email_prof;
            cmd.Parameters.Add("@telefone_professor", MySqlDbType.VarChar).Value = professor.Tel_prof;
            cmd.ExecuteNonQuery();
        }

        public void AlterarProf(Professor professor) // Método para alterar informações especificas no banco de dados.
        {
            MySqlCommand cmd = Banco.Conexao();
            cmd.CommandText = "update tb_professor set nome_professor=@nome_professor, telefone_professor=@telefone_professor where id_professor =@id_professor";
            cmd.Parameters.Add("@nome_professor", MySqlDbType.VarChar).Value = professor.Nome_prof;
            cmd.Parameters.Add("@id_professor", MySqlDbType.Int32).Value = professor.Id_prof;
            cmd.Parameters.Add("@telefone_professor", MySqlDbType.VarChar).Value = professor.Tel_prof;
            cmd.ExecuteNonQuery();
        }

        public List<Professor> ListarProf() // Listar os professores
        {
            List<Professor> professor = new List<Professor>();
            var cmd = Banco.Conexao();
            cmd.CommandText = "select * from tb_professor ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                professor.Add(
                    new Professor(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetDateTime(5)
                        ));
            }
            return professor;
        }

        public void ObterPorId(int id_prof) // Buscar os professores cadastrados através do ID. 
        {
            var cmd = Banco.Conexao();
            cmd.CommandText = "select * from tb_professor where id_professor = " + id_prof;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id_prof = dr.GetInt32(0);
                Nome_prof = dr.GetString(1);
                Cpf_prof = dr.GetString(2);
                Email_prof = dr.GetString(3);
                Tel_prof = dr.GetString(4);
                DataCadastro_prof = dr.GetDateTime(5);
            }
        }
    }
}