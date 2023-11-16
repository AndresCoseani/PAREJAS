using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAREJAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sexo = checkBox1.Checked==true ? "F" : "M";

            Datos d = new Datos();

            string sql = $@"
                SELECT UserName, Email, Sexo
                FROM Usuarios
                WHERE Sexo='{Sexo}'
            ";
            DataTable tabla = d.GetTabla(sql);
            dataGridView1.Rows.Clear();
            foreach(DataRow fila in tabla.Rows)
            {
                dataGridView1.Rows.Add(fila["UserName"], fila["Email"], fila["Sexo"]);
            }
        }
    }
}
