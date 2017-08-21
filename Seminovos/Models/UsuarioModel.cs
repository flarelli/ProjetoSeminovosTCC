using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Seminovos.Models
{
    public class UsuarioModel
    {

        public static bool ValidarUsuario(string login, string senha)
        {
            var ret = false;

            using (var conexao = new SqlConnection())
            {
                //conexão com o banco de dados para a validação do usuário do sistema
                conexao.ConnectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=sndb;User Id=admin;Password=123";
                conexao.Open();

                //realiza a execução da query e valida se o valor informado bate com o cadastrado
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format(
                        "select count (*) from usuario where login = '{0}' and senha = '{1}'", login, senha);
                    ret = ((int)comando.ExecuteScalar() > 0);
                }
            }

            return ret;
        }
    }
}