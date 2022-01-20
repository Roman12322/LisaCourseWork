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
    public partial class Reg : Form
    {
        private SqlConnection sqlConnection = null;
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_load(object sender, EventArgs e)
        {
            
        }
        private bool CheckAlreadyRegUsers()//проверка на уже зарегистрированного пользователя
        {
            bool nextStep=false;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Datas"].ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM DATA WHERE Login = @Login", sqlConnection);
            sqlCommand.Parameters.AddWithValue("Login", Login1.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return nextStep;
            }
            else
            {
                reader.Close();
                nextStep = true;
                return nextStep;
            }
        }
        private bool InsertData()
        {
            bool Check = CheckAlreadyRegUsers();
            bool continueReg = false;
            if(Check==true)
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Datas"].ConnectionString);
                sqlConnection.Open();
                SqlCommand insert = new SqlCommand($"INSERT INTO [DATA] (Login, Password) VALUES (@Login, @Password)", sqlConnection);
                insert.Parameters.AddWithValue("Login", Login1.Text);
                insert.Parameters.AddWithValue("Password", Password1.Text);
                insert.ExecuteNonQuery();
                sqlConnection.Close();
                continueReg = true;
                return continueReg;
            }
            else
            {
                Login1.BackColor = Color.LightCoral;
                MessageBox.Show("User already exist");
                return continueReg;
            }
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            bool next = InsertData();
            if(next == true)
            {
                Auth auth = new Auth();
                this.Hide();
                auth.Show();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            this.Hide();
            auth.Show();
        }
    }
}
