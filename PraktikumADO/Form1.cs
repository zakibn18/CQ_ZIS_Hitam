using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        // Variabel Koneksi
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        // Method Koneksi Database
        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=DESKTOP-8TS9IRD\\ZAKIBN; Initial Catalog=DBAkademikADO; Integrated Security=True"
            );
        }
    }
}
