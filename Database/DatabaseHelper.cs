using Hotel.Forms;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel.Database
{
    internal class DatabaseHelper
    {

        private string connectionString;

        public DatabaseHelper()
        {
            // Retrieve the connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["HotelSystem"].ConnectionString;
        }



        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();

                    // Debugging: Log the query and parameters
                    Console.WriteLine($"Executing Query: {query}");
                    foreach (var param in parameters)
                    {
                        Console.WriteLine($"{param.ParameterName}: {param.Value}");
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}");

                    return rowsAffected;
                }
            }
        }



        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }



        public DataTable ExecuteReader(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }


        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Optionally, log the exception or display a message
                System.Windows.Forms.MessageBox.Show("Database Connection Failed: " + ex.Message);
                return false;
            }
        }



        // Create (Register a New User)
        public int UserC(User user)
        {
            string query = "INSERT INTO Usertable (Username, [Password], Email, Address, Mobile) VALUES (@Username, @Password, @Email, @Address, @Mobile); SELECT CAST(scope_identity() AS int);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@Username", user.Username),
                 new SqlParameter("@Password", user.Password),
                 new SqlParameter("@Email", user.Email),
                 new SqlParameter("@Address", user.Address),
                 new SqlParameter("@Mobile", user.Mobile)

            };

            // Execute the query and return the new UserID
            return (int)ExecuteScalar(query, parameters);
        }


        public void UserProfileC(UserProfile profile)
        {
            string query = @"
            INSERT INTO UserProfile (UserID, Username, ProfilePicture, Email, Address, Mobile)
            VALUES (@UserID, @Username, @ProfilePicture, @Email, @Address, @Mobile);";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UserID", profile.UserID),
            new SqlParameter("@Username", string.IsNullOrEmpty(profile.Username) ? string.Empty : profile.Username),
            new SqlParameter("@ProfilePicture", profile.ProfilePicture ?? (object)DBNull.Value),
            new SqlParameter("@Email", string.IsNullOrEmpty(profile.Email) ? string.Empty : profile.Email),
            new SqlParameter("@Address", string.IsNullOrEmpty(profile.Address) ? string.Empty : profile.Address),
            new SqlParameter("@Mobile", string.IsNullOrEmpty(profile.Mobile) ? string.Empty : profile.Mobile)
            };

            ExecuteNonQuery(query, parameters);
        }



        public User GetUserByname(string username)
        {
            string query = "SELECT * FROM Usertable WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Password = reader.GetString(reader.GetOrdinal("Password")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                Mobile = reader.GetString(reader.GetOrdinal("Mobile"))
                                // Add other fields as necessary
                            };
                        }
                        else
                        {
                            return null; // User not found
                        }
                    }
                }
            }
        }



        public User GetUserByID(int userId)
        {
            string query = "SELECT * FROM Usertable WHERE UserID = @UserID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userId)
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Password = reader.GetString(reader.GetOrdinal("Password")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                Mobile = reader.GetString(reader.GetOrdinal("Mobile"))
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }





        public void AddRoomBuy(int userId,
                      string roomType,
                      decimal price,
                      string food,
                      int nights,
                      string paymentMethod,
                      DateTime checkIn,
                      DateTime checkOut)

        {

            // 1) First, load the user’s details
            string userSql = @"
            SELECT Username
            FROM Usertable
            WHERE UserID = @UserID";

            var userTable = ExecuteReader(userSql, new SqlParameter("@UserID", userId));
            if (userTable.Rows.Count == 0)
                throw new Exception($"No user found with ID {userId}");

            DataRow u = userTable.Rows[0];
            string username = u["Username"].ToString();


            // … fetch username …
            const string insert = @"
      INSERT INTO dbo.RoomBuy
        (UserID, Username, RoomType, Price, Food, Nights, PaymentMethod, CheckInDate, CheckOutDate, PurchaseDate)
      VALUES
        (@UserID, @Username, @RoomType, @Price, @Food, @Nights, @PaymentMethod, @CheckIn, @CheckOut, GETDATE())";
            var ps = new[]{
        new SqlParameter("@UserID",      userId),
        new SqlParameter("@Username",    username),
        new SqlParameter("@RoomType",    roomType),
        new SqlParameter("@Price",       price),
        new SqlParameter("@Food",        food),
         new SqlParameter("@Nights",     nights),
        new SqlParameter("@PaymentMethod", paymentMethod ?? (object)DBNull.Value),
        new SqlParameter("@CheckIn",     checkIn),
        new SqlParameter("@CheckOut",    checkOut)
    };
            ExecuteNonQuery(insert, ps);
        }



        public DataRow GetUserProfileById(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    ProfileID, 
                    UserID, 
                    Username, 
                    ProfilePicture, 
                    Email, 
                    Address,
                    Mobile
                FROM  UserProfile
                WHERE UserID = @UserID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable resultTable = new DataTable();

                    adapter.Fill(resultTable);

                    if (resultTable.Rows.Count > 0)
                    {
                        return resultTable.Rows[0]; // Return the first row
                    }
                    else
                    {
                        return null; // No matching user profile found
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching user profile: {ex.Message}");
            }
        }






        public void UpdateUserProfile(int userId, string profilePicture, string email, string address, string mobile)
        {
            string query = @"
        BEGIN TRANSACTION;

        -- Update UserProfile
        IF EXISTS (SELECT 1 FROM UserProfile WHERE UserID = @UserID)
        BEGIN
            UPDATE UserProfile
            SET ProfilePicture = @ProfilePicture,
                Email = @Email,
                Address = Address,
                Mobile = @Mobile
            WHERE UserID = @UserID;
        END
        ELSE
        BEGIN
            INSERT INTO UserProfile (UserID, ProfilePicture, Email, Address, Mobile)
            VALUES (@UserID, @ProfilePicture, @Email, @Address, @Mobile);
        END

        -- Update Usertable
        UPDATE Usertable
        SET Email = @Email, UpdatedDate = GETDATE()
        WHERE UserID = @UserID;

        COMMIT TRANSACTION;
    ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userId),
                new SqlParameter("@ProfilePicture", string.IsNullOrWhiteSpace(profilePicture) ? (object)DBNull.Value : profilePicture),
                new SqlParameter("@Email", string.IsNullOrWhiteSpace(email) ? (object)DBNull.Value : email),
                new SqlParameter("@Address", string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address),
                new SqlParameter("@Mobile", string.IsNullOrWhiteSpace(mobile) ? (object)DBNull.Value : mobile)
            };

            ExecuteNonQuery(query, parameters);
        }






        public void UpdateUser(User user)
        {
            string query = "UPDATE Usertable SET Username = @Username, [Password] = @Password, Email = @Email, Address = @Address, Mobile = @Mobile WHERE UserID = @UserID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", user.Username),
            new SqlParameter("@Password", user.Password),
            new SqlParameter("@Email", user.Email),
            new SqlParameter("@Address", user.Address),
            new SqlParameter("@Mobile", user.Mobile),
            new SqlParameter("@UserID", user.UserID)
            };

            ExecuteNonQuery(query, parameters);
        }






        public GetAdmin GetAdminByName(string adminname)
        {
            string query = "SELECT * FROM Admintable WHERE Adminname = @Adminname";
            SqlParameter[] parameters =

         {
        new SqlParameter("@Adminname", adminname)


         };

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return null;
                    return new GetAdmin
                    {
                        AdminID = reader.GetInt32(reader.GetOrdinal("AdminID")),
                        Adminname = reader.GetString(reader.GetOrdinal("Adminname")),
                        Password = reader.GetString(reader.GetOrdinal("Password")),
                        Email = reader.GetString(reader.GetOrdinal("Email")),
                        Address = reader.GetString(reader.GetOrdinal("Address")),
                        Mobile = reader.GetString(reader.GetOrdinal("Mobile"))
                    };
                }
            }
        }





        public GetAdmin GetAdminByID(int adminId)
        {
            string query = "SELECT * FROM Admintable WHERE AdminID = @AdminID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@AdminID", adminId)
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GetAdmin
                            {
                                AdminID = reader.GetInt32(reader.GetOrdinal("AdminID")),
                                Adminname = reader.GetString(reader.GetOrdinal("Adminname")),
                                Password = reader.GetString(reader.GetOrdinal("Password")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                Mobile = reader.GetString(reader.GetOrdinal("Mobile"))
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }



        public int GetAdmin(GetAdmin admin)
        {
            string query = "INSERT INTO Admintable (Adminname, [Password], Email, Address, Mobile) VALUES (@Adminname, @Password, @Email, @Address, @Mobile); SELECT CAST(scope_identity() AS int);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@Adminname", admin.Adminname),
                 new SqlParameter("@Password", admin.Password),
                 new SqlParameter("@Email", admin.Email),
                 new SqlParameter("@Address", admin.Address),
                 new SqlParameter("@Mobile", admin.Mobile)

            };

            // Execute the query and return the new UserID
            return (int)ExecuteScalar(query, parameters);
        }


        public bool UpdatePassword(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    string query = @"
                UPDATE Usertable
                SET Password = @Password
                WHERE Email = @Email";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error resetting password: {ex.Message}");
            }
        }




        public DataTable SearchByUsername(string username)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                if (string.IsNullOrWhiteSpace(username))
                {
                    cmd.CommandText = "SELECT * FROM dbo.RoomBuy";
                }
                else
                {
                    cmd.CommandText = @"
                SELECT * 
                FROM dbo.RoomBuy
                WHERE Username LIKE '%' + @Filter + '%'";
                    cmd.Parameters.AddWithValue("@Filter", username);
                }
                var dt = new DataTable();
                using (var da = new SqlDataAdapter(cmd))
                    da.Fill(dt);
                return dt;
            }
        }




        public DataTable GetBuy(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;

                if (userId == 0)
                {

                    cmd = new SqlCommand("SELECT * FROM RoomBuy", conn);
                }
                else
                {

                    cmd = new SqlCommand("SELECT * FROM RoomBuy WHERE UserID = @UserID", conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                }

                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                return dt;


            }
        }



        public DataTable GetRoomBuyByUser(int userId)
        {
            const string sql = @"
SELECT UserID, RoomType, Price, Food, Nights, PaymentMethod, CheckInDate, CheckOutDate, PurchaseDate
FROM dbo.RoomBuy
WHERE UserID = @UserID
ORDER BY PurchaseDate DESC";
            return ExecuteReader(sql, new SqlParameter("@UserID", userId));
        }




    }
}
