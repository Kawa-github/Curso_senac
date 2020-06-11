using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolarMusicApp
{
    public class Usuario
    {
        public int Id_user { get; set; }
        public string Nome_user { get; set; }
        public string Email_user { get; set; }
        public string Senha_user { get; set; }
        public string Situacao_user { get; set; }
        
        public Usuario()
        {
        }

        public Usuario(int id_user, string nome_user, string email_user, string senha_user, string situacao_user)
        {
            Id_user = id_user;
            Nome_user = nome_user;
            Email_user = email_user;
            Senha_user = senha_user;
            Situacao_user = situacao_user;
        }


        public Usuario(string nome_user, string email_user, string senha_user, string situacao_user)
        {
            Nome_user = nome_user;
            Email_user = email_user;
            Senha_user = senha_user;
            Situacao_user = situacao_user;
        }

        public Usuario(string nome_user, string email_user, string senha_user)
        {
            Nome_user = nome_user;
            Email_user = email_user;
            Senha_user = senha_user;
        }
        public Usuario(string email_user, string senha_user)
        {
            Email_user = email_user;
            Senha_user = senha_user;
        }

        public void InserirUser(Usuario usuario)
        {
            MySqlCommand cmd = Banco.Conexao();
            cmd.CommandText = "insert tb_usuario values(null, @nome_usuario, @email_usuario, @senha_usuario, @situacao_usuario);";
            cmd.Parameters.Add("@nome_usuario", MySqlDbType.VarChar).Value = usuario.Nome_user;
            cmd.Parameters.Add("@email_usuario", MySqlDbType.VarChar).Value = usuario.Email_user;
            cmd.Parameters.Add("@senha_usuario", MySqlDbType.VarChar).Value = usuario.Senha_user;
            cmd.Parameters.Add("@situacao_usuario", MySqlDbType.VarChar).Value = usuario.Situacao_user;
            cmd.ExecuteNonQuery();
        }

        public void AlterarUser(Usuario usuario)
        {
            MySqlCommand cmd = Banco.Conexao();
            cmd.CommandText = "update tb_usuario set nome_usuario=@nome_usuario where id_usuario =@id_usuario";
            cmd.Parameters.Add("@nome_usuario", MySqlDbType.VarChar).Value = usuario.Nome_user;
            cmd.Parameters.Add("@id_usuario", MySqlDbType.Int32).Value = usuario.Id_user;
            cmd.ExecuteNonQuery();
        }
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var cmd = Banco.Conexao();
            cmd.CommandText = "select * from tb_usuario";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(
                    new Usuario(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4)
                        ));
            }
            return usuarios;
        }
        public void ObterPorId(int id_user)
        {
            var cmd = Banco.Conexao();
            cmd.CommandText = "select * from tb_usuario where id_usuario = " + id_user;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id_user = dr.GetInt32(0);
                Nome_user = dr.GetString(1);
                Email_user = dr.GetString(2);
                Senha_user = dr.GetString(3);
                Situacao_user = dr.GetString(4);
            }
        }
        public bool EfetuarLogin(Usuario usuario) //Método do tipo Bool para efetuar o login do usuário.
        {
            bool valido = false;
            var cmd = Banco.Conexao();
            cmd.CommandText =
                "select * from tb_usuario where senha_usuario = md5(@senha) " + 
                "and email_usuario = @email;";
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha_user;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = usuario.Email_user;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id_user = dr.GetInt32(0);
                Nome_user = dr.GetString(1);
                Situacao_user = dr.GetString(2);
                valido = true;
            }
            return valido;
        }
    }

}

