using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace RFID_MDI
{
    public class ConexaoBD
    {
        private MySqlConnection Conexao;

        public ConexaoBD()
        {
          string stringConexao = "Server=localhost;Database=sistemacontroleacesso;Uid=root;Pwd=;";
            Conexao = new MySqlConnection(stringConexao);
        }
        public MySqlConnection Conectar()
        {
            return Conexao;
        }
        public void Desconectar()
        {
            Conexao.Close();
        }
    }
}
