using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace CRUD_SQLITE {


    public partial class Form1 : Form
    {
        // NuGet install: System.Data.SQLite
        static string data_source = @"Data Source=DEJOTADB.db;Version=3;New=True;Compress=True;UTF8Encoding=True;";
        static SQLiteConnection conexao;
        static SQLiteCommand comandos;

        public Form1()
        {
            Console.WriteLine("=================SQLITE=====================");
            conexao = new SQLiteConnection(data_source);
            conexao.Open();
            comandos = conexao.CreateCommand();
            comandos.CommandText = "CREATE TABLE IF NOT EXISTS " +
                "cidade(id integer primary key, nome VARCHAR(40));";
            comandos.ExecuteNonQuery();
; ;
            InitializeComponent();
        }

    

        private void Btn_ler_Click(object sender, EventArgs e)
        {
            SQLiteDataReader leitor;
            comandos.CommandText = "SELECT * FROM cidade;";
            leitor = comandos.ExecuteReader();
            while (leitor.Read())
            {
                int idx = leitor.GetInt32(0);
                string cidade = leitor.GetString(1);
                Console.WriteLine("ID: "+ idx + ", CIDADA: "+ cidade);
            }
            leitor.Close();
            Console.WriteLine("=================AND=====================");
        }

        private void Btn_inserir_Click(object sender, EventArgs e)
        {
            comandos.CommandText = "INSERT INTO cidade values(null, 'Limoeiro do Norte');";
            comandos.ExecuteNonQuery();
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            comandos.CommandText = "UPDATE cidade SET nome = 'Alegre';";
            comandos.ExecuteNonQuery();
        }

        private void Btn_apagar_Click(object sender, EventArgs e)
        {
            comandos.CommandText = "DELETE FROM cidade;";
            comandos.ExecuteNonQuery();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fechar conexao ao sair do app
            conexao.Close();
        }
    }
}
