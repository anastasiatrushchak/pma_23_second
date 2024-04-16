using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Users1.Controllers
{
    public interface IUserRepository
    {
        List<object> GetAllUsers();
        List<object> GetUserById(int id);
        string RegisterUser(string mail, string password, string city, string instagram, string phone);
        string DeleteUserById(int userId);
        string UpdateUserById(int userId, string mail, string password, string city, string instagram, string phone);
    }

    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<object> GetAllUsers()
        {
            List<object> userList = new List<object>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("CALL get_all_users_data()", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new
                            {
                                id = reader.GetInt32("idusers"),
                                mail = reader.GetString("mail"),
                                password = reader.GetString("password"),
                                city = reader.GetString("city"),
                                instagram = reader.GetString("instagram"),
                                phone = reader.GetString("phone")
                            };

                            userList.Add(user);
                        }
                    }
                }
            }

            return userList;
        }

        public List<object> GetUserById(int id)
        {
            List<object> userList = new List<object>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("CALL get_user_by_id(@id)", connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new
                            {
                                id = reader.GetInt32("idusers"),
                                mail = reader.GetString("mail"),
                                password = reader.GetString("password"),
                                city = reader.GetString("city"),
                                instagram = reader.GetString("instagram"),
                                phone = reader.GetString("phone")
                            };

                            userList.Add(user);
                        }
                    }
                }
            }

            return userList;
        }

        public string RegisterUser(string mail, string password, string city, string instagram, string phone)
        {
            string message;

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("CALL register(@p_mail, @p_password, @p_city, @p_instagram, @p_phone)", connection))
                {
                    command.Parameters.AddWithValue("@p_mail", mail);
                    command.Parameters.AddWithValue("@p_password", password);
                    command.Parameters.AddWithValue("@p_city", city);
                    command.Parameters.AddWithValue("@p_instagram", instagram);
                    command.Parameters.AddWithValue("@p_phone", phone);

                    using (MySqlDataReader reader1 = command.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            message = reader1.GetString("message");
                        }
                        else
                        {
                            message = "User registration failed.";
                        }
                    }
                }
            }

            return message;
        }

        public string DeleteUserById(int userId)
        {
            string message;

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("CALL delete_user_by_id(@p_user_id)", connection))
                {
                    command.Parameters.AddWithValue("@p_user_id", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            message = reader.GetString("message");
                        }
                        else
                        {
                            message = "User with specified ID does not exist.";
                        }
                    }
                }
            }

            return message;
        }

        public string UpdateUserById(int userId, string mail, string password, string city, string instagram, string phone)
        {
            string message;

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("CALL update_user_by_id(@p_user_id, @p_mail, @p_password, @p_city, @p_instagram, @p_phone)", connection))
                {
                    command.Parameters.AddWithValue("@p_user_id", userId);
                    command.Parameters.AddWithValue("@p_mail", mail);
                    command.Parameters.AddWithValue("@p_password", password);
                    command.Parameters.AddWithValue("@p_city", city);
                    command.Parameters.AddWithValue("@p_instagram", instagram);
                    command.Parameters.AddWithValue("@p_phone", phone);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            message = reader.GetString("message");
                        }
                        else
                        {
                            message = "User with specified ID does not exist.";
                        }
                    }
                }
            }

            return message;
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        public List<object> GetUserById()
        {
            List<object> userList = new List<object>();


            if (Request.Headers.TryGetValue("id", out StringValues idString) && int.TryParse(idString, out int id))
            {

                userList = _userRepository.GetUserById(id);
                return userList;
            }
            else {
                return _userRepository.GetAllUsers();
            }

        }

        [HttpPost]
        public async Task<ActionResult> Register()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var requestBody = await reader.ReadToEndAsync();
                JObject requestBodyJson = JObject.Parse(requestBody);

                string mail = requestBodyJson["mail"]?.ToString();
                string password = requestBodyJson["password"]?.ToString();
                string city = requestBodyJson["city"]?.ToString();
                string instagram = requestBodyJson["instagram"]?.ToString();
                string phone = requestBodyJson["phone"]?.ToString();

                if (mail == null || password == null || city == null || instagram == null || phone == null)
                {
                    return BadRequest("Please provide data in the request body.");
                }

                string message = _userRepository.RegisterUser(mail, password, city, instagram, phone);

                return Ok(message);
            }
        }



        [HttpDelete]
        public ActionResult DeleteUser([FromQuery] string id)
        {
            if (string.IsNullOrEmpty(id) || !int.TryParse(id, out int userId))
            {
                return BadRequest("Please provide a valid user id.");
            }

            string message = _userRepository.DeleteUserById(userId);

            return Ok(message);
        }

    

    [HttpPatch]
        public async Task<ActionResult> UpdateUser()
        {
            if (Request.Headers.TryGetValue("id", out StringValues idString) && int.TryParse(idString, out int id))
            {
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    var requestBody = await reader.ReadToEndAsync();
                    JObject requestBodyJson = JObject.Parse(requestBody);

                    string mail = requestBodyJson["mail"]?.ToString();
                    string password = requestBodyJson["password"]?.ToString();
                    string city = requestBodyJson["city"]?.ToString();
                    string instagram = requestBodyJson["instagram"]?.ToString();
                    string phone = requestBodyJson["phone"]?.ToString();

                    if (mail == null || password == null || city == null || instagram == null || phone == null)
                    {
                        return BadRequest("Please provide data in the request body.");
                    }


                    string message = _userRepository.UpdateUserById(id, mail, password, city, instagram, phone);
                    return Ok(message);

                }

            }
            else {
                return Ok("error");
            }
        }
    }
}

