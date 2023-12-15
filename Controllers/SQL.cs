using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace QuizTime.Controllers
{
    public class SQL
    {

        // save the connection object as public
        private MySqlConnection _connection;

        public void closeConnection()
        {
            _connection.Close();
        }

        private void openConnection()
        {
            if (_connection == null)
            {
                _connection = new MySqlConnection();
                _connection.ConnectionString = "Server=localhost;User ID=root;Password=;Database=quiztime";
                _connection.Open();
            }

        }

        public MySqlConnection Connection
        {
            get
            {
                openConnection();
                return _connection;
            }
        }
    }
}
