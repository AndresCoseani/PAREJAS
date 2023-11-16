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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = textBox1.Text;
            string Password = textBox2.Text;

            Datos d = new Datos();
            string sql = $@"
                SELECT Foto
                FROM Usuarios 
                WHERE Email='{Email}' AND Password='{Password}' 
            ";
            DataTable tabla = d.GetTabla(sql);

            if(tabla.Rows.Count==0)
            {
                MessageBox.Show("ACCESO DENEGADO", "ERROR");
            }else
            {
                string Foto = tabla.Rows[0]["Foto"].ToString();
                pictureBox1.Load($"fotos/{Foto}");
            }
        }
    }
}
