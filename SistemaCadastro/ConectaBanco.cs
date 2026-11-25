using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaCadastro
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=sql.freedb.tech; port=3306; user id=u_cnLr44; password=testeteste; database=freedb_0JsZeSh0");
        public string mensagem;

        public bool insereEletrodomestico(Eletrodomestico novoEletrodomestico)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereEletrodomestico", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_nome", novoEletrodomestico.Nome);
                cmd.Parameters.AddWithValue("p_potencia", novoEletrodomestico.Potencia);
                cmd.Parameters.AddWithValue("p_tempoMedioAtivo", novoEletrodomestico.TempoMedioAtivo);
                cmd.Parameters.AddWithValue("p_dono", novoEletrodomestico.Dono);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listaDonos()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaDonos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listaEletrodomesticos()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaEletrodomesticos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deletaEletrodomestico(int idRemoveEletrodomestico)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeEletrodomestico", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_ideletrodomestico", idRemoveEletrodomestico);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool alteraEletrodomestico(Eletrodomestico eletrodomestico, int idEletrodomestico)
        {
            MySqlCommand cmd = new MySqlCommand("update_eletrodomestico", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_ideletrodomestico", idEletrodomestico);
            cmd.Parameters.AddWithValue("p_nome", eletrodomestico.Nome);
            cmd.Parameters.AddWithValue("p_dono", eletrodomestico.Dono);
            cmd.Parameters.AddWithValue("p_potencia", eletrodomestico.Potencia);
            cmd.Parameters.AddWithValue("p_tempoMedioAtivo", eletrodomestico.TempoMedioAtivo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool insereDono(string nomeDono)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereDono", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_nomeDono", nomeDono);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
