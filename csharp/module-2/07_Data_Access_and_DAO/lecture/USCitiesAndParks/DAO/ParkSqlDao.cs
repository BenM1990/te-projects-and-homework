using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    public class ParkSqlDao : IParkDao
    {
        private readonly string connectionString;

        public ParkSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Park GetPark(int parkId)
        {
            Park park = null;

            using (SqlConnection parkConnection = new SqlConnection(connectionString))
            {
                parkConnection.Open(); // open the connection to the DB

                SqlCommand parkCommand = new SqlCommand("SELECT * FROM park WHERE park_id = @park_id;", parkConnection);
                parkCommand.Parameters.AddWithValue("@park_id", parkId); //add a value for the SQL parameter of @park_id in the query string above

                SqlDataReader reader = parkCommand.ExecuteReader(); //runs the SQL query against the database

                if (reader.Read()) // // if only one row is expected, just check to see if it can be read, don't need a whole while loop for one row
                {
                    park = CreateParkFromReader(reader);
                }
            }
            return park; //return the park object
        }

        public IList<Park> GetParksByState(string stateAbbreviation)
        {
            IList<Park> parks = new List<Park>();
            using(SqlConnection parkConnection = new SqlConnection (connectionString))
            {
                parkConnection.Open();
                SqlCommand parkCommand = new SqlCommand("SELECT * FROM park JOIN park_state ON park_state.park_id = park.park_id WHERE state_abbreviation = @state_abbreviation", parkConnection);
                parkCommand.Parameters.AddWithValue("@state_abbreviation", stateAbbreviation);

                SqlDataReader reader = parkCommand.ExecuteReader(); // exectue the select query

                //create park object(s) from the data comming back from the reader
                while (reader.Read())
                {
                    Park park = CreateParkFromReader(reader);
                    parks.Add(park);
                }
            }
            return parks;



        }

        public Park CreatePark(Park park)
        {
            int newParkId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand parkCommand = new SqlCommand("INSERT INTO park (park_id, park_name, date_established, area, has_camping) " +
                                                "OUTPUT INSERTED.park_id " +
                                                "VALUES (@park_id, @park_name, @date_established, @area, @has_camping);", conn);
                parkCommand.Parameters.AddWithValue("@park_id", park.ParkId);
                parkCommand.Parameters.AddWithValue("@park_name", park.ParkName);
                parkCommand.Parameters.AddWithValue("@date_established", park.DateEstablished);
                parkCommand.Parameters.AddWithValue("@area", park.Area);
                parkCommand.Parameters.AddWithValue("@has_camping", park.HasCamping);

                newParkId = Convert.ToInt32(parkCommand .ExecuteScalar());
            }
            return GetPark(newParkId);
        }

        public void UpdatePark(Park park)
        {
            using (SqlConnection parkConnection = new SqlConnection(connectionString))
            {
                parkConnection.Open();

                SqlCommand parkCommand = new SqlCommand("UPDATE city SET park_name = @park_name, date_established = @date_established, @has_camping = has_camping, area = @area WHERE park_id = @park_id;", parkConnection);
                parkCommand.Parameters.AddWithValue("@park_name", park.ParkName);
                parkCommand.Parameters.AddWithValue("date_established", park.DateEstablished);
                parkCommand.Parameters.AddWithValue("@area", park.Area);
                parkCommand.Parameters.AddWithValue("@has_camping", park.HasCamping);
                parkCommand.Parameters.AddWithValue("@park_id", park.ParkId);

                parkCommand.ExecuteNonQuery();
            }
        }

        public void DeletePark(int parkId)
        {
            throw new NotImplementedException();
        }

        public void AddParkToState(int parkId, string state_abbreviation)
        {
            throw new NotImplementedException();
        }

        public void RemoveParkFromState(int parkId, string state_abbreviation)
        {
            throw new NotImplementedException();
        }

        private Park CreateParkFromReader(SqlDataReader reader)
        {
            Park park = new Park();
            park.ParkId = Convert.ToInt32(reader["park_id"]);
            park.ParkName = Convert.ToString(reader["park_name"]);
            park.DateEstablished = Convert.ToDateTime(reader["date_established"]);
            park.Area = Convert.ToDecimal(reader["area"]);
            park.HasCamping = Convert.ToBoolean(reader["has_camping"]);
            return park;
        }
    }
}
