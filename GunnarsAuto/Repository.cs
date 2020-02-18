using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GunnarsAuto
{
    public class Repository
    {
        public static List<Car> cars = new List<Car>();
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GunnarsAutoDB;Integrated Security=True";

        public static List<Car> GetAll()
        {
            cars = new List<Car>();
            string sql = "SELECT * FROM Cars";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int carID = (int)reader["PK_CarID"];
                string make = (string)reader["Make"];
                string model = (string)reader["Model"];
                string vin = (string)reader["VIN_number"];
                string registration = (string)reader["RegistrationNumber"];
                string isUsed = (string)reader["IsUsed"];

                Car car = new Car(carID, make, model, vin, registration, isUsed);
                cars.Add(car);
            }

            connection.Close();
            return cars;
        }
    }
}
