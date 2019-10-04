using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SysScreen.mylib
{  
    class ConfigSQLite
    {

        // NuGet install: System.Data.SQLite
        private const string data_source = @"Data Source=sysscreen.db;Version=3;New=True;Compress=True;UTF8Encoding=True;";
        private static SQLiteConnection conexao;
        private static SQLiteCommand comandos;

        private static void start()
        {
            if (conexao == null)
            {
                conexao = new SQLiteConnection(data_source);
                conexao.Open();
                comandos = conexao.CreateCommand();
                comandos.CommandText = "CREATE TABLE IF NOT EXISTS " +
                    "config(" +
                        "id integer primary key, " +
                        "navegador VARCHAR(40) NOT NULL DEFAULT 'chrome', " +
                        "salvar_computador INT NOT NULL DEFAULT '1', " +
                        "salvar_nuvem INT NOT NULL DEFAULT '1', " +
                        "abrir_diretorio_image INT NOT NULL DEFAULT '0', " +
                        "capiture_modo_rapido INT NOT NULL DEFAULT '0', " +
                        "pathSaveImage VARCHAR(255) NOT NULL DEFAULT '0', " +
                        "lastFormatSave VARCHAR(255) NOT NULL DEFAULT '0' " +
                    ");";
                
                
                comandos.ExecuteNonQuery();
            }            


        }

        private static void close()
        {
            comandos.Dispose();
            conexao.Close();
            comandos = null;
            conexao = null;
        }

        public static void loadConfig()
        {
            start();
            SQLiteDataReader leitor;
            comandos.CommandText = "SELECT * FROM config WHERE id=1;";
            leitor = comandos.ExecuteReader();
            while (leitor.Read())
            {
                //int idx = leitor.GetInt32(0);
                Config.navegador = leitor.GetString(1);
                Config.salvar_computador = Convert.ToBoolean(leitor.GetInt32(2));
                Config.salvar_nuvem = Convert.ToBoolean(leitor.GetInt32(3));
                Config.abrir_diretorio_image = Convert.ToBoolean(leitor.GetInt32(4));
                Config.capiture_modo_rapido = Convert.ToBoolean(leitor.GetInt32(5));
                Config.pathSaveImage = leitor.GetString(6);
                Config.lastFormatSave = leitor.GetString(7);
            }
            leitor.Close();
            close();
        }

        public static void saveConfig()
        {
            start();
            SQLiteDataReader leitor;
            comandos.CommandText = "SELECT * FROM config WHERE id=1;";
            leitor = comandos.ExecuteReader();
            bool isEmpty = !leitor.HasRows;
            leitor.Close();
            if (isEmpty)
            {
                comandos.CommandText = "INSERT INTO config values(1, " +
                    "'" + Config.navegador + "', " +
                    "'" + Convert.ToInt32(Config.salvar_computador) + "', " +
                    "'" + Convert.ToInt32(Config.salvar_nuvem) + "', " +
                    "'" + Convert.ToInt32(Config.abrir_diretorio_image) + "', " +
                     "'" + Convert.ToInt32(Config.capiture_modo_rapido) + "', " +
                     "'" + Config.pathSaveImage + "', " +
                     "'" + Config.lastFormatSave + "' " +
                    ");";   
                comandos.ExecuteNonQuery();
                
            }
            else
            {
                comandos.CommandText = "UPDATE config SET" +
                    " navegador = '" + Config.navegador + "', " +
                    " salvar_computador = '" + Convert.ToInt32(Config.salvar_computador) + "', " +
                    " salvar_nuvem = '" + Convert.ToInt32(Config.salvar_nuvem) + "', " +
                    " abrir_diretorio_image = '" + Convert.ToInt32(Config.abrir_diretorio_image) + "', " +
                    " capiture_modo_rapido = '" + Convert.ToInt32(Config.capiture_modo_rapido) + "', " +
                    " pathSaveImage = '" + Config.pathSaveImage + "', " +
                    " lastFormatSave = '" + Config.lastFormatSave + "' " +
                    " WHERE id = 1;";
                comandos.ExecuteNonQuery();
            }
            close();
        }

       


    }
}
