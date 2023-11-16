using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;

namespace PAREJAS
{
    class Datos
    {
        public DataTable GetTabla(string sql)
        {
            DataTable tabla = new DataTable();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, "Data Source=Parejas.db");
            adaptador.Fill(tabla);
            return tabla;
        }        
    }
}
