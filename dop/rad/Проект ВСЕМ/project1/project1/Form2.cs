using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace project1
{
    public partial class Form2 : Form

    {
        NpgsqlConnection conn;
        string sql;
        string connect;
        public Form2()
        {
            InitializeComponent();
        }
        void UpdateGrid()
        {
            conn = new NpgsqlConnection("Server = localhost;Port = 5432;User Id=postgres;Password = postpass;Database = Kavokin");
            conn.Open();
            sql = "select*from Client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
