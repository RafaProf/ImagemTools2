﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpa_Imagem
{
    internal class ConnDB
    {

        static string serverName = "192.168.0.6";
        static string port = "5433";
        static string userName = "postgres";
        static string password = "#intellissis--40";
        static string databaseName = "emt_ip_um";


        static string ConnectionString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                serverName, port, userName, password, databaseName);

        public static NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);

        public static bool Connected()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool Conectar(string host, string porta, string database, string usuario, string senha) {

         string ConnectionString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                               host, porta, usuario, senha, database);

         NpgsqlConnection conexao = new NpgsqlConnection(ConnectionString);

            try
            {
                conexao.Open();
                MessageBox.Show("Sucesso na conexão");
                connection = conexao;
                return true;
                
            }
            catch (Exception)
            {
                conexao.Close();
                MessageBox.Show("Falha na conexão");
                return false;
                throw;
            }

    }

        public static bool FecharConexao()
        {
            connection.Close();
            return true;
        }

        public static List<string> LerImagemColeta()
        {
            NpgsqlCommand cmd = new NpgsqlCommand(@"select distinct caminho_imagem  from imagens_coleta order by caminho_imagem desc; ", connection);

            NpgsqlDataReader dados = cmd.ExecuteReader();

            List<string> imagemColeta = new List<string>();

            while (dados.Read())
            {
                try
                {
                    imagemColeta.Add(dados.GetString(0));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return imagemColeta;
        }
}
}
