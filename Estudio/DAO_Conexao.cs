using MySql.Data.MySqlClient;
using System;

namespace Estudio
{
    class DAO_Conexao
    {
        //atributos
        public static MySqlConnection con;

        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + "; User ID=" + user + ";" + "database=" + banco +
                    "; password=" + senha + "; SslMode = none");
               
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        public static Boolean Form2Login(String usuario, String senha, int tipo)
        {
            bool cad = false;
            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Login (usuario, senha, tipo)" + "values('" + usuario + "','" + senha+"'," + tipo + ")", con);
                insere.ExecuteNonQuery();
                cad = true;
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());

            }
            finally
            {
                con.Close();
            }
            return cad;
        }

        public static Boolean autenticaLogin(String usuario,String senha)
        {
            bool c = false;
            int xx;
            MySqlCommand insere2 = new MySqlCommand("select usuario from Estudio_Login where usuario=" + usuario + ";", con);
            xx=insere2.ExecuteNonQuery();
            if(xx!=1)
            {
                return c;
            }
            else
            {
                c = true;
                return c;
            }
        }
        public static int login(String usuario, String senha)
        {
            int tipo = 0;
            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("Select* from Estudio_Login where usuario= '"+usuario+"' and senha= '"+senha+"'",con);
                MySqlDataReader resultado = login.ExecuteReader();
                if(resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }
    }
}
