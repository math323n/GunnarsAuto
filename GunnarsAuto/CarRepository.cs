using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GunnarsAuto
{
     public class CarRepository
     {
        static List<Car> cars = new List<Car>();

        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GunnarsAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public static List<Car> GetAll()
        {
            string sql = "SELECT * FROM Cars";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string make = (string)reader["Make"];
                string model = (string)reader["Model"];
                string vin = (string)reader["VIN_number"];
                string registration = (string)reader["RegistrationsNumber"];
                string isUsed = (string)reader["IsUsed"];

                Car car = new Car
                {
                    Make = make,
                    Model = model,
                    VIN_number = vin,
                    RegistrationNumber = registration,
                    IsUsed = isUsed
                };
                cars.Add(car);
            }

            connection.Close();
            return cars;
        }
    }
}