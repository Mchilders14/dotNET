using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace SqlServerLibrary
{
    public class SqlServerLib
    {
        SqlConnection sqlConn = null;   // Setting initial sql connection to null

        public User UserGetByPK(int Id) // Perfroming get user by ID
        {
            if (sqlConn == null)
            {
                throw new Exception("No Connection");
            }

            var sql = "SELECT * FROM [User] Where Id = @Id";
            var sqlcmd = new SqlCommand(sql, sqlConn);
            sqlcmd.Parameters.AddWithValue("@Id", Id);
            var reader = sqlcmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            var user = new User();
            user.Id = Convert.ToInt32(reader["Id"]);
            user.Username = Convert.ToString(reader["Username"]);
            // user.Password = Convert.ToString(reader["Password"]);
            user.FirstName = Convert.ToString(reader["FirstName"]);
            user.LastName = Convert.ToString(reader["LastName"]);
            user.Phone = Convert.ToString(reader["Phone"]);
            user.Email = Convert.ToString(reader["Email"]);
            user.Reviewer = Convert.ToBoolean(reader["Reviewer"]);
            user.Admin = Convert.ToBoolean(reader["Admin"]);

            reader.Close();
            return user;
        }

        public List<User> UserGetAll()  // Perfroming a SELECT ALL from the User table
        {
            if(sqlConn == null)
            {
                throw new Exception("No Connection");
            }

            var sql = "SELECT * FROM [User];";
            var sqlcmd = new SqlCommand(sql, sqlConn);
            var reader = sqlcmd.ExecuteReader();
            var users = new List<User>();

            while (reader.Read())
            {
                var user = new User();
                user.Id = Convert.ToInt32(reader["Id"]);
                user.Username = Convert.ToString(reader["Username"]);
                // user.Password = Convert.ToString(reader["Password"]);
                user.FirstName = Convert.ToString(reader["FirstName"]);
                user.LastName = Convert.ToString(reader["LastName"]);
                user.Phone = Convert.ToString(reader["Phone"]);
                user.Email = Convert.ToString(reader["Email"]);
                user.Reviewer = Convert.ToBoolean(reader["Reviewer"]);
                user.Admin = Convert.ToBoolean(reader["Admin"]);

                users.Add(user);
            }
            reader.Close(); // Can only have one reader open at a time
            return users;
        }

        public List<Vendor> VendorGetAll()  // Perfroming a SELECT ALL from the Vendor table
        {
            if (sqlConn == null)
            {
                throw new Exception("No Connection");
            }

            var sql = "SELECT * FROM Vendor;";
            var sqlcmd = new SqlCommand(sql, sqlConn);
            var reader = sqlcmd.ExecuteReader();
            var vendors = new List<Vendor>();

            while (reader.Read())
            {
                var vendor = new Vendor();
                vendor.Id = Convert.ToInt32(reader["Id"]);
                vendor.Code = Convert.ToString(reader["Code"]);
                vendor.Name = Convert.ToString(reader["Name"]);
                vendor.Address = Convert.ToString(reader["Address"]);
                vendor.City = Convert.ToString(reader["City"]);
                vendor.State = Convert.ToString(reader["State"]);
                vendor.Zip = Convert.ToString(reader["Zip"]);
                vendor.Email = Convert.ToString(reader["Email"]);
                vendor.Phone = Convert.ToString(reader["Phone"]);


                vendors.Add(vendor);
            }
            reader.Close(); // Can only have one reader open at a time
            return vendors;
        }

        public Vendor VendorGetByPK(int Id) // Perfroming get Vendor by ID
        {
            if (sqlConn == null)
            {
                throw new Exception("No Connection");
            }

            var sql = "SELECT * FROM Vendor Where Id = @Id";
            var sqlcmd = new SqlCommand(sql, sqlConn);
            sqlcmd.Parameters.AddWithValue("@Id", Id);
            var reader = sqlcmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            var vendor = new Vendor();
            vendor.Id = Convert.ToInt32(reader["Id"]);
            vendor.Code = Convert.ToString(reader["Code"]);
            vendor.Name = Convert.ToString(reader["Name"]);
            vendor.Address = Convert.ToString(reader["Address"]);
            vendor.City = Convert.ToString(reader["City"]);
            vendor.State = Convert.ToString(reader["State"]);
            vendor.Zip = Convert.ToString(reader["Zip"]);
            vendor.Email = Convert.ToString(reader["Email"]);
            vendor.Phone = Convert.ToString(reader["Phone"]);

            reader.Close();
            return vendor;
        }

        public void Connect(string server, string database)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = $"{server}";
            builder.UserID = "SA";
            builder.Password = "Bluetruck14";
            builder.InitialCatalog = $"{database}";

            //var connStr = $"server={server};"
            //                + $"database={database};";

            sqlConn = new SqlConnection(builder.ConnectionString);
            sqlConn.Open();
            if (sqlConn.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Connection did not open!");
            }
        }

        public void Disconnect()
        {
            if (sqlConn.State == System.Data.ConnectionState.Open)
            {
                sqlConn.Close();
            }
        }
    }
}
