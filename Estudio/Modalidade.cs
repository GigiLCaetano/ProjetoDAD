using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Estudio
{
    class Modalidade
    {
        private string Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

        public Modalidade (string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            Descricao1 = descricao;
            Preco1 = preco;
            Qtde_alunos = qtde_alunos;
            Qtde_aulas = qtde_aulas;
        }
        public Modalidade(string descricao)
        {
            Descricao1 = descricao;
        }

        public Modalidade()
        {

        }

        public bool cadastrarModalidade()
        {
                bool cad = false;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade(descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('" + Descricao + "'," + Preco + "," + qtde_alunos + "," + qtde_aulas + ")", DAO_Conexao.con);
                    insere.ExecuteNonQuery();
                    cad = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DAO_Conexao.con.Close();
                }
                return cad;
            
        }

        public bool consultarModalidade()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade" +
                    "WHERE descricaoModalidade ='" + Descricao + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }

        public MySqlDataReader consultarTodasModalidade()
        {
            bool existe = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //DAO_Conexao.con.Close();
            }
            return resultado;
        }

        public bool atualizarModalidade()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade = '" + Descricao + "', precoModalidade = " + Preco + ", qtde_alunos = " + qtde_alunos + ", qtde_aulas = " + qtde_aulas + " where descricaoModalidade = '" + Descricao + "'", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
        public bool excluirModalidade()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativo" +
                    "= 1 where descricaoModalidade = '" + Descricao + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }


    }

}
