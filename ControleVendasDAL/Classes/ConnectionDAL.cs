using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace ControleVendasDAL
{
    public class ConnectionDAL
    {
        public void ConectarBanco()
        {
            OleDbConnection dbConexao;
            string dbDrive = "Provider=Microsoft.ACE.OLEDB.12.0;";
            string Banco = "Data Source= " + Application.StartupPath + "\\ControleVendas.accdb";
            dbConexao = new OleDbConnection(dbDrive + Banco);
            dbConexao.Open();
            try
            {
                MessageBox.Show("OK");
            }
            catch
            {
                MessageBox.Show("Problemas ao conectar com o Banco de Dados");
            }
        }

        public void DesconectarBanco()
        {
            OleDbConnection dbConexao;
            string dbDrive = "Provider=Microsoft.ACE.OLEDB.12.0;";
            string Banco = "Data Source= " + Application.StartupPath + "\\ControleVendas.mdb";
            dbConexao = new OleDbConnection(dbDrive + Banco);
            dbConexao.Close();
            try
            {
                MessageBox.Show("Banco Desconectado com sucesso.");
            }
            catch
            {
                MessageBox.Show("Erro ao Desconectar do Banco.");                
            }
        }

    }
}
