using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;



namespace AppEmpleadosCrut_2_
{
    public class ConexionMysql
    {
        private static MySqlConnection objetoConexion;
        private static string error;


        public static MySqlConnection getConexion()
        {
            if (objetoConexion != null)
                return objetoConexion;

            objetoConexion = new MySqlConnection("Server=localhost;Database=sena2020;Uid=UserSena;Pwd=Sena2020Yesica;");

            try
            {
                objetoConexion.Open();
                return objetoConexion;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
        }

        public static void cerrarConexion()
        {
            if (objetoConexion != null)
                objetoConexion.Close();
        }
    }
}