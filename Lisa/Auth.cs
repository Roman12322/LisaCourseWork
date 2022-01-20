using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Lisa
{
    public partial class Auth : Form
    {
        private SqlConnection connection = null;
        public Auth()
        {
            InitializeComponent();
        }
        private bool SelectSQL()
        {
            bool next = false;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Datas"].ConnectionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM DATA WHERE Login = @login AND Password = @password", connection);
            sqlCommand.Parameters.AddWithValue("Login", Login.Text);
            sqlCommand.Parameters.AddWithValue("Password", Password.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                Login.BackColor = Color.LightGreen;
                Password.BackColor = Color.LightGreen;
                connection.Close();
                MessageBox.Show("User identified in database");
                next = true;
                return next;
            }
            else
            {
                Login.BackColor = Color.LightPink;
                Password.BackColor = Color.LightPink;
                MessageBox.Show("Incorrect input");
                return next;
            }
        }
        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void AuthEntButton_Click(object sender, EventArgs e)
        {
            var step = SelectSQL();
            if(step == true)
            {
                this.Hide();
                Shiphr shiphr = new Shiphr();
                shiphr.Show();
            }
        }

        private void AuthCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();
            reg.Show();
        }
    }
}
