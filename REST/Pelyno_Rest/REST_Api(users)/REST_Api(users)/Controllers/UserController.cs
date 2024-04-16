using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using REST_Api_users_.Models;
using MySql.Data.MySqlClient;

namespace REST_Api_users_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly string connectionString = "server=localhost;port=3306;database=users;user=root;password=Peleno28;";

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> users = new List<User>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sqlQuery = "SELECT u.*, p.* FROM user u LEFT JOIN user_profile p ON u.user_id = p.user_id";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        UserId = Convert.ToInt32(reader["user_id"]),
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        UserProfile = new User_Profile
                        {
                            ProfileId = Convert.ToInt32(reader["profile_id"]),
                            UserId = Convert.ToInt32(reader["user_id"]),
                            Address = reader["address"].ToString(),
                            PhoneNumber = reader["phone_number"].ToString()
                        }
                    };
                    users.Add(user);
                }
                connection.Close();
            }
            return users;
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User user = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sqlQuery = "SELECT u.*, p.* FROM user u LEFT JOIN user_profile p ON u.user_id = p.user_id WHERE u.user_id = @user_id";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@user_id", id);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user = new User
                    {
                        UserId = Convert.ToInt32(reader["user_id"]),
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        UserProfile = new User_Profile
                        {
                            ProfileId = Convert.ToInt32(reader["profile_id"]),
                            UserId = Convert.ToInt32(reader["user_id"]),
                            Address = reader["address"].ToString(),
                            PhoneNumber = reader["phone_number"].ToString()
                        }
                    };
                }
                connection.Close();
            }
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
        //api/User/Params
        [HttpGet("Params")]
        public ActionResult<User> Get_Params([FromQuery] int user_id)
        {
            User user = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sqlQuery = "SELECT u.*, p.* FROM user u LEFT JOIN user_profile p ON u.user_id = p.user_id WHERE u.user_id = @user_id";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@user_id", user_id);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user = new User
                    {
                        UserId = Convert.ToInt32(reader["user_id"]),
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        UserProfile = new User_Profile
                        {
                            ProfileId = Convert.ToInt32(reader["profile_id"]),
                            UserId = Convert.ToInt32(reader["user_id"]),
                            Address = reader["address"].ToString(),
                            PhoneNumber = reader["phone_number"].ToString()
                        }
                    };
                }
                connection.Close();
            }
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
        // GET: api/User/Header
        [HttpGet("Header")]
        public ActionResult<User> Header([FromHeader(Name = "user_id")] int id)
        {
            User user = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sqlQuery = "SELECT u.*, p.* FROM user u LEFT JOIN user_profile p ON u.user_id = p.user_id WHERE u.user_id = @user_id";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@user_id", id);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user = new User
                    {
                        UserId = Convert.ToInt32(reader["user_id"]),
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        UserProfile = new User_Profile
                        {
                            ProfileId = Convert.ToInt32(reader["profile_id"]),
                            UserId = Convert.ToInt32(reader["user_id"]),
                            Address = reader["address"].ToString(),
                            PhoneNumber = reader["phone_number"].ToString()
                        }
                    };
                }
                connection.Close();
            }
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sqlQuery = "INSERT INTO user (username, email) VALUES (@username, @email)";
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@email", user.Email);
                    connection.Open();
                    command.ExecuteNonQuery();


                    int userId = Convert.ToInt32(command.LastInsertedId);
                    sqlQuery = "INSERT INTO user_profile (user_id, address, phone_number) VALUES (@user_id, @address, @phone_number)";
                    command = new MySqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@address", user.UserProfile.Address ?? "");
                    command.Parameters.AddWithValue("@phone_number", user.UserProfile.PhoneNumber ?? "");
                    command.ExecuteNonQuery();
                    
                }
                return Ok("Користувача успішно створено.");
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    return Conflict("Користувач з таким email вже існує.");
                }
                else
                {
                    return StatusCode(500, "Помилка на сервері.");
                }
            }
        }


        // PUT: api/User/Params
        [HttpPut("Params")]
        public IActionResult Put_Params([FromQuery] int user_id, [FromBody] User updatedUser)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string checkUserQuery = "SELECT COUNT(*) FROM user WHERE user_id = @user_id";
                    MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, connection);
                    checkUserCommand.Parameters.AddWithValue("@user_id", user_id);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        return NotFound("Користувача з вказаним user_id не знайдено.");
                    }
                    string updateUserQuery = "UPDATE user SET username = @username, email = @email WHERE user_id = @user_id";
                    MySqlCommand updateUserCommand = new MySqlCommand(updateUserQuery, connection);
                    updateUserCommand.Parameters.AddWithValue("@user_id", user_id);
                    updateUserCommand.Parameters.AddWithValue("@username", updatedUser.Username);
                    updateUserCommand.Parameters.AddWithValue("@email", updatedUser.Email);
                    updateUserCommand.ExecuteNonQuery();

                    string updateProfileQuery = "UPDATE user_profile SET address = @address, phone_number = @phone_number WHERE user_id = @user_id";
                    MySqlCommand updateProfileCommand = new MySqlCommand(updateProfileQuery, connection);
                    updateProfileCommand.Parameters.AddWithValue("@user_id", user_id);
                    updateProfileCommand.Parameters.AddWithValue("@address", updatedUser.UserProfile.Address ?? "");
                    updateProfileCommand.Parameters.AddWithValue("@phone_number", updatedUser.UserProfile.PhoneNumber ?? "");
                    updateProfileCommand.ExecuteNonQuery();
                    
                    connection.Close();
                }

                return Ok("Дані користувача оновлено успішно.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Помилка на сервері: {ex.Message}");
            }
        }
        
        // PUT: api/User/Header
        [HttpPut("Header")]
        public IActionResult Put_Header([FromHeader(Name = "user_id")] int userId, [FromBody] User userUpdate)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string checkUserQuery = "SELECT COUNT(*) FROM user WHERE user_id = @user_id";
                    MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, connection);
                    checkUserCommand.Parameters.AddWithValue("@user_id", userId);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        return NotFound("Користувача з вказаним ID не знайдено.");
                    }

                    string updateUserQuery = "UPDATE user SET username = @username, email = @email WHERE user_id = @user_id";
                    MySqlCommand updateUserCommand = new MySqlCommand(updateUserQuery, connection);
                    updateUserCommand.Parameters.AddWithValue("@user_id", userId);
                    updateUserCommand.Parameters.AddWithValue("@username", userUpdate.Username);
                    updateUserCommand.Parameters.AddWithValue("@email", userUpdate.Email);
                    updateUserCommand.ExecuteNonQuery();
                    string updateProfileQuery = "UPDATE user_profile SET address = @address, phone_number = @phone_number WHERE user_id = @user_id";
                    MySqlCommand updateProfileCommand = new MySqlCommand(updateProfileQuery, connection);
                    updateProfileCommand.Parameters.AddWithValue("@user_id", userId);
                    updateProfileCommand.Parameters.AddWithValue("@address", userUpdate.UserProfile.Address ?? "");
                    updateProfileCommand.Parameters.AddWithValue("@phone_number", userUpdate.UserProfile.PhoneNumber ?? "");
                    updateProfileCommand.ExecuteNonQuery();
                    

                    connection.Close();
                }
                return Ok("Дані користувача успішно оновлено.");
            }
            catch (MySqlException ex)
            {
                return StatusCode(500, "Помилка на сервері: " + ex.Message);
            }
        }
        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM user WHERE user_id = @user_id";
                    MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, connection);
                    checkUserCommand.Parameters.AddWithValue("@user_id", id);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        return NotFound("Користувача з таким ID не знайдено.");
                    }

                    string deleteUserQuery = "DELETE FROM user WHERE user_id = @user_id";
                    MySqlCommand deleteUserCommand = new MySqlCommand(deleteUserQuery, connection);
                    deleteUserCommand.Parameters.AddWithValue("@user_id", id);
                    deleteUserCommand.ExecuteNonQuery();

                    connection.Close();

                    return Ok("Користувача успішно видалено.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Помилка сервера: {ex.Message}");
            }
        }
        // DELETE: api/User/Params
        [HttpDelete("Params")]
        public IActionResult Delete_Params([FromQuery] int user_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM user WHERE user_id = @user_id";
                    MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, connection);
                    checkUserCommand.Parameters.AddWithValue("@user_id", user_id);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        return NotFound("Користувача з вказаним user_id не знайдено.");
                    }

                    string deleteUserQuery = "DELETE FROM user WHERE user_id = @user_id";
                    MySqlCommand deleteUserCommand = new MySqlCommand(deleteUserQuery, connection);
                    deleteUserCommand.Parameters.AddWithValue("@user_id", user_id);
                    deleteUserCommand.ExecuteNonQuery();

                    connection.Close();
                }

                return Ok("Користувача успішно видалено.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Помилка на сервері: {ex.Message}");
            }
        }
        // DELETE: api/User/Header
        [HttpDelete("Header")]
        public IActionResult Delete_Header([FromHeader(Name = "user_id")] int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string checkUserQuery = "SELECT COUNT(*) FROM user WHERE user_id = @user_id";
                    MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, connection);
                    checkUserCommand.Parameters.AddWithValue("@user_id", id);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        return NotFound("Користувача з вказаним user_id не знайдено.");
                    }
                    string deleteUserQuery = "DELETE FROM user WHERE user_id = @user_id";
                    MySqlCommand deleteUserCommand = new MySqlCommand(deleteUserQuery, connection);
                    deleteUserCommand.Parameters.AddWithValue("@user_id", id);
                    deleteUserCommand.ExecuteNonQuery();

                    connection.Close();
                }

                return Ok("Користувача успішно видалено.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Помилка на сервері: {ex.Message}");
            }
        }
    }
}
