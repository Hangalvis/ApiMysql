using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace Api.Model
{
    public class Conexion
    {
        public string conexion = @"Server=localhost; Database=apiproductos; Uid=root;";
        //using(var db = new MySqlConnection(Conexion))
        //{
        // var sql = "SELECT * FROM apiproductos.productos";

        //}
    }
}
