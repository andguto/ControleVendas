using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace ControleVendasDAL.Classes
{
    public class UsersDAL
    {
        public void GetUserByName(string strName, string strSenha)
        {
            ConnectionDAL clsConnectionDAL = new ConnectionDAL();
            OleDbConnection dbConexao = clsConnectionDAL.ConectarBanco();

            //string dbDrive = "Provider=Microsoft.ACE.OLEDB.12.0;";
            //string Banco = "Data Source= " + Application.StartupPath + "\\ControleVendas.accdb";
            //dbConexao = new OleDbConnection(dbDrive + Banco);
            string selectSQL = "Select Codigo_Usuario, Nome_Usuario, Senha_Usuario " +
                               "From Usuarios " +
                               "Where Nome_Usuario = " + "'" + strName + "'" + " and Senha_Usuario = " + "'" + strSenha + "'";

            OleDbCommand command = new OleDbCommand(selectSQL, dbConexao);
            //dbConexao.Open();
           

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show("Login realizado com sucesso.");
                MessageBox.Show(reader[0].ToString()
                    +" - "+ reader[1].ToString()
                    +" - "+ reader[2].ToString());
            }
            reader.Close();


        }
    }
}
