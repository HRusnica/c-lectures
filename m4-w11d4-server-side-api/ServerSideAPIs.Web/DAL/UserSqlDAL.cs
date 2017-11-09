using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServerSideAPIs.Web.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace ServerSideAPIs.Web.DAL
{
    public class UserSqlDAL : IUserDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ApiDB"].ConnectionString;

        public void AddUser(User newUser)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO users VALUES (@name, @username, @email);", conn);
                    cmd.Parameters.AddWithValue("@name", newUser.name);
                    cmd.Parameters.AddWithValue("@username", newUser.username);
                    cmd.Parameters.AddWithValue("@email", newUser.email);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE id = @id;", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public void UpdateUser(User updatedUser)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE users SET name = @name, username = @username, email = @email WHERE id = @id;", conn);
                    cmd.Parameters.AddWithValue("@name", updatedUser.name);
                    cmd.Parameters.AddWithValue("@username", updatedUser.username);
                    cmd.Parameters.AddWithValue("@email", updatedUser.email);
                    cmd.Parameters.AddWithValue("@id", updatedUser.id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users;", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User u = new User()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            name = Convert.ToString(reader["name"]),
                            username = Convert.ToString(reader["username"]),
                            email = Convert.ToString(reader["email"])
                        };
                        users.Add(u);
                    }

                    return users;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }            
        }

        public User GetUser(int id)
        {
            User user = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE id = @id;", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        user = new User()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            name = Convert.ToString(reader["name"]),
                            username = Convert.ToString(reader["username"]),
                            email = Convert.ToString(reader["email"])
                        };                        
                    }

                    return user;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}