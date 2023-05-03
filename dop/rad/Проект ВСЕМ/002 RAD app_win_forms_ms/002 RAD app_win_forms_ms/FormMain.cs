using Npgsql;
using System.Data;

namespace _002_RAD_app_win_forms_ms
{
    public partial class FormMain : Form
    {

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public FormMain()
        {

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = postpass; Database = pastext");
            conn.Open();
            string sql = "select * from Product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewMain.DataSource = dt;
            dataGridViewMain.Columns[0].HeaderText = "Идентификатор";
            dataGridViewMain.Columns[1].HeaderText = "Название";
            dataGridViewMain.Columns[2].HeaderText = "Единицы измерения";
            conn.Close();
        }
    }
}