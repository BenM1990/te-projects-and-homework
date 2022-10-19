﻿using System;
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

            using(SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM park WHERE park_id = @park_id", conn);
                cmd.Parameters.AddWithValue("@park_id", parkId);

                SqlDataReader reader = cmd.ExecuteReader();
                 
                if (reader.Read()) //if only one row is expected back, just check to see if it can be read, don't need a whole while loop for one row 
                {
                    park = CreateParkFromReader(reader);
                }

            }

            return park; 
        }

        public IList<Park> GetParksByState(string stateAbbreviation)
        {

            IList<Park> parks = new List<Park>(); 

            using(SqlConnection parkConnection = new SqlConnection(connectionString))
            {
                parkConnection.Open();
                SqlCommand parkCommand = new SqlCommand("SELECT * FROM park JOIN park_state ON park_state.park_id = park.park_id WHERE state_abbreviation = @state_abbreviation", parkConnection);
                parkCommand.Parameters.AddWithValue("@state_abbreviation", stateAbbreviation);

                SqlDataReader reader = parkCommand.ExecuteReader(); //execute select query

                //create park object(s) from the data coming back from the reader
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
            //we want to return a park object
            //we also take in a park object
            //should we return the same park object as we took in? -> no
            //we want to put the park object we took in into the database, and then make sure it got the okay by retrieving the data and giving it back instead

            int newParkId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO park (park_name, date_established, area, has_camping) " +
                                                "OUTPUT INSERTED.park_id " +
                                                "VALUES (@park_name, @date_established, @area, @has_camping);", conn);
                cmd.Parameters.AddWithValue("@park_name", park.ParkName);
                cmd.Parameters.AddWithValue("@date_establsished", park.DateEstablished);
                cmd.Parameters.AddWithValue("@area", park.Area);
                cmd.Parameters.AddWithValue("@has_camping", park.HasCamping);

                //ExecuteScalar() since we expect the id from the query
                newParkId = Convert.ToInt32(cmd.ExecuteScalar()); // need to do the conversion to a data type that C# understands

                // Park newParkId = GetPark(GetParkId)----> other way of returning
                //return newParkId                    ----> other way of returning
            }
            return GetPark(newParkId);
        }

        public void UpdatePark(Park park)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE park SET park_name = @park_name, date_establsihed = @date_established, area = @area, has_camping = @has_camping WHERE park_id = @park_id;", conn);
                cmd.Parameters.AddWithValue("@park_name", park.ParkName);
                cmd.Parameters.AddWithValue("@date_established", park.DateEstablished);
                cmd.Parameters.AddWithValue("@area", park.Area);
                cmd.Parameters.AddWithValue("@has_camping", park.HasCamping);
                cmd.Parameters.AddWithValue("@park_id", park.ParkId);

                cmd.ExecuteNonQuery(); //returns # of rows changed, but not doing anything with that information
            }
        }

        public void DeletePark(int parkId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM park_state WHERE park_id = @park_id;" + 
                                                "DELETE FROM park WHERE park_id = @park_id;", conn);
                cmd.Parameters.AddWithValue("@park_id", parkId);
                

                cmd.ExecuteNonQuery();

            }
        }

        public void AddParkToState(int parkId, string state_abbreviation)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO park_state(park_id, state_abbreviation) VALUES(@park_id, @state_abbreviation;", conn);
                cmd.Parameters.AddWithValue("@park_id", parkId);
                cmd.Parameters.AddWithValue("@state_abbreviation", state_abbreviation);

                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveParkFromState(int parkId, string state_abbreviation)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM park_state WHERE park_id = @park_id, state_abbreviation = @state_abbreviation;", conn);
                cmd.Parameters.AddWithValue("@park_id", parkId);
                cmd.Parameters.AddWithValue("@state_abbreviation", state_abbreviation);

                cmd.ExecuteNonQuery();

            }
        }

        private Park CreateParkFromReader(SqlDataReader reader) //make a park object out of row of SQL data
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
