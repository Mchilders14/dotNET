using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace SqlServerLibrary
{
    public class SqlServerLib
    {
        SqlConnection sqlConn = null;   // Setting initial sql connection to null

        public List<User> UserGetAll()  // Get ALL User
        {
            if (sqlConn == null)
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

        public User UserGetByPK(int Id) // Get User by Id
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

        public bool UserCreate(User user)   // Add User
        {
            if (sqlConn == null)
            {
                throw new Exception("No connection!");
            }

            var sql = " INSERT INTO [User] " + " (Username, Password, FirstName, LastName, Phone, Email, Reviewer, Admin) "
                                             + " VALUES "
                                             + "(@Username, @Password, @FirstName, @LastName, @Phone, @Email, @Reviewer, @Admin)";

            var sqlcmd = new SqlCommand(sql, sqlConn);
            sqlcmd.Parameters.AddWithValue("@Username", user.Username);
            sqlcmd.Parameters.AddWithValue("@Password", user.Password);
            sqlcmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            sqlcmd.Parameters.AddWithValue("@LastName", user.LastName);
            sqlcmd.Parameters.AddWithValue("@Phone", user.Phone);
            sqlcmd.Parameters.AddWithValue("@Email", user.Email);
            sqlcmd.Parameters.AddWithValue("@Reviewer", user.Reviewer);
            sqlcmd.Parameters.AddWithValue("@Admin", user.Admin);

            var rowsAffected = sqlcmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }

        public bool UserChange(User user)
        {
            if (sqlConn == null)
            {
                throw new Exception("No connection!");
            }

            var sql = " UPDATE [User] SET "
                        + " Username = @Username, "
                        // + " Password = @Password, "
                        + " FirstName = @FirstName, "
                        + " LastName = @LastName, "
                        + " Phone = @Phone, "
                        + " Email = @Email, "
                        + " Reviewer = @Reviewer, "
                        + " Admin = @Admin "
                        + " WHERE Id = @Id; ";

            var sqlcmd = new SqlCommand(sql, sqlConn);
            sqlcmd.Parameters.AddWithValue("@Username", user.Username);
            //sqlcmd.Parameters.AddWithValue("@Password", user.Password);
            sqlcmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            sqlcmd.Parameters.AddWithValue("@LastName", user.LastName);
            sqlcmd.Parameters.AddWithValue("@Phone", user.Phone);
            sqlcmd.Parameters.AddWithValue("@Email", user.Email);
            sqlcmd.Parameters.AddWithValue("@Reviewer", user.Reviewer);
            sqlcmd.Parameters.AddWithValue("@Admin", user.Admin);
            sqlcmd.Parameters.AddWithValue("@Id", user.Id);


            var rowsAffected = sqlcmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }// Update User

        public List<Vendor> VendorGetAll()  // Get ALL Vendor
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

        public Vendor VendorGetByPK(int Id) // Get Vendor by ID
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

        public bool VendorCreate(Vendor vendor)   // Add Vendor 
        {
            if (sqlConn == null)
            {
                throw new Exception("No connection!");
            }

            var sql = " INSERT INTO Vendor " + " (Code, Name, Address, City, State, Zip, Email, Phone) "
                                             + " VALUES "
                                             + "(@Code, @Name, @Address, @City, @State, @Zip, @Email, @Phone)";

            var sqlcmd = new SqlCommand(sql, sqlConn);
            sqlcmd.Parameters.AddWithValue("@Code", vendor.Code);
            sqlcmd.Parameters.AddWithValue("@Name", vendor.Name);
            sqlcmd.Parameters.AddWithValue("@Address", vendor.Address);
            sqlcmd.Parameters.AddWithValue("@City", vendor.City);
            sqlcmd.Parameters.AddWithValue("@State", vendor.State);
            sqlcmd.Parameters.AddWithValue("@Zip", vendor.Zip);
            sqlcmd.Parameters.AddWithValue("@Email", vendor.Email);
            sqlcmd.Parameters.AddWithValue("@Phone", vendor.Phone);

            var rowsAffected = sqlcmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }

        public bool VendorChange(Vendor vendor)
        {
            if (sqlConn == null)
            {
                throw new Exception("No connection!");
            }

            var sql = " UPDATE Vendor SET "
                        + " Name = @Name, "
                        + " Address = @Address, "
                        + " City = @City, "
                        + " State = @State, "
                        + " Zip = @Zip, "
                        + " Email = @Email, "
                        + " Phone = @Phone "
                        + " WHERE Id = @Id; ";

            var sqlcmd = new SqlCommand(sql, sqlConn);
            sqlcmd.Parameters.AddWithValue("@Name", vendor.Name);
            sqlcmd.Parameters.AddWithValue("@Address", vendor.Address);
            sqlcmd.Parameters.AddWithValue("@City", vendor.City);
            sqlcmd.Parameters.AddWithValue("@State", vendor.State);
            sqlcmd.Parameters.AddWithValue("@Zip", vendor.Zip);
            sqlcmd.Parameters.AddWithValue("@Email", vendor.Email);
            sqlcmd.Parameters.AddWithValue("@Phone", vendor.Phone);
            sqlcmd.Parameters.AddWithValue("@Id", vendor.Id);

            var rowsAffected = sqlcmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }   // Update Vendor

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
