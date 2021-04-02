﻿using ClinicSupport.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with the Individual table of the ClinicSupport DB
    /// </summary>
    class IndividualDAL
    {
        /// <summary>
        /// Get the Individual object from the data source.
        /// </summary>
        /// <param name="iid">iid</param>
        /// <returns>the Individual object</returns>
        public Individual GeIndividualbyID(int iid)
        {
            Individual _individual = new Individual();
            string selectStatement =
                "SELECT fname, lname, streetAddress, city, state, zip, phone, dob " +
                 "FROM Individual " +
                 "WHERE iid = @iid";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@iid", SqlDbType.Int);
                    selectCommand.Parameters["@iid"].Value = iid;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _individual.FirstName = (string)reader["fname"];
                            _individual.LastName = (string)reader["lname"];
                            _individual.StreetAddress = (string)reader["streetAddress"];
                            _individual.City = (string)reader["city"];
                            _individual.State = (string)reader["state"];
                            _individual.ZipCode = (int)reader["zip"];
                            _individual.PhoneNumber = (int)reader["phone"];
                            _individual.DateOfBirth = Convert.ToDateTime(reader["dob"]);
                        }
                    }
                }
            }
            return _individual;
        }
    }
}