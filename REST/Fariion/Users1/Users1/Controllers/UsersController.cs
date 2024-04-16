using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Users1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public List<object> Index()
        {
            List<object> userList = new List<object>();

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;Database=database;User Id=root;Password=12341234;"))
            {
                connection.Open();

                
                if (Request.Headers.TryGetValue("Id", out StringValues idString) && int.TryParse(idString, out int id))
                {   

                   
                    using (MySqlCommand command = new MySqlCommand("CALL get_user(@id)", connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new
                                {
                                    Id = reader.GetInt32("idusers"),
                                    Name = reader.GetString("username"),
                                    Password = reader.GetString("password"),
                                    iduserdetails = reader.GetInt32("iduserdetails"),
                                    fullname = reader.GetString("fullname"),
                                    address = reader.GetString("address"),
                                    phonenumber = reader.GetString("phonenumber")
                                };

                                userList.Add(user);
                            }
                        }
                    }
                }
                else 
                {
                    using (MySqlCommand command = new MySqlCommand("CALL get_all_users()", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new
                                {
                                    Id = reader.GetInt32("idusers"),
                                    Name = reader.GetString("username"),
                                    Password = reader.GetString("password"),
                                    iduserdetails = reader.GetInt32("iduserdetails"),
                                    fullname = reader.GetString("fullname"),
                                    address = reader.GetString("address"),
                                    phonenumber = reader.GetString("phonenumber")
                                };

                                userList.Add(user);
                            }
                        }
                    }
                }
            }

            return userList;
        }

        [HttpPost]
        public async Task<ActionResult> Register()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var requestBody = await reader.ReadToEndAsync();
                var requestBodyJson = JsonConvert.DeserializeObject<dynamic>(requestBody);

                
                if (requestBodyJson.username == null || requestBodyJson.password == null ||
                    requestBodyJson.fullname == null || requestBodyJson.address == null ||
                    requestBodyJson.phonenumber == null)
                {
                    return BadRequest("Please provide username, password, fullname, address, and phonenumber in the request body.");
                }

                string message;

               
                using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;Database=database;User Id=root;Password=12341234;"))
                {
                    connection.Open();

                    
                    using (MySqlCommand command = new MySqlCommand("CALL register(@p_username, @p_password, @p_fullname, @p_address, @p_phonenumber)", connection))
                    {
                        command.Parameters.AddWithValue("@p_username", requestBodyJson.username);
                        command.Parameters.AddWithValue("@p_password", requestBodyJson.password);
                        command.Parameters.AddWithValue("@p_fullname", requestBodyJson.fullname);
                        command.Parameters.AddWithValue("@p_address", requestBodyJson.address);
                        command.Parameters.AddWithValue("@p_phonenumber", requestBodyJson.phonenumber);

                        
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

                return Ok(message);
            }
        }

        [HttpDelete]
        public ActionResult DeleteUser(string id)
        {
            
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Please provide a valid user id.");
            }

            
            if (!int.TryParse(id, out int userId))
            {
                return BadRequest("Please provide a valid user id.");
            }

            string message;

           
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;Database=database;User Id=root;Password=12341234;"))
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

            return Ok(message);
        }

        [HttpPatch]
        public async Task<ActionResult> UpdateUser()
        {
            if (!Request.Headers.TryGetValue("userId", out var userIdValue))
            {
                return BadRequest("User ID is missing in the request headers.");
            }

            if (!int.TryParse(userIdValue, out int userId))
            {
                return BadRequest("Invalid user ID format in the request headers.");
            }

            string requestBody;
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                requestBody = await reader.ReadToEndAsync();
            }

            dynamic requestBodyJson = JsonConvert.DeserializeObject<dynamic>(requestBody);

            
            if (requestBodyJson.username == null || requestBodyJson.password == null ||
                requestBodyJson.fullname == null || requestBodyJson.address == null ||
                requestBodyJson.phonenumber == null)
            {
                return BadRequest("Please provide username, password, fullname, address, and phonenumber in the request body.");
            }

            string message;

            
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;Database=database;User Id=root;Password=12341234;"))
            {
                connection.Open();

                
                using (MySqlCommand command = new MySqlCommand("CALL update_user(@p_user_id, @p_username, @p_password, @p_fullname, @p_address, @p_phonenumber)", connection))
                {
                    command.Parameters.AddWithValue("@p_user_id", userId);
                    command.Parameters.AddWithValue("@p_username", requestBodyJson.username);
                    command.Parameters.AddWithValue("@p_password", requestBodyJson.password);
                    command.Parameters.AddWithValue("@p_fullname", requestBodyJson.fullname);
                    command.Parameters.AddWithValue("@p_address", requestBodyJson.address);
                    command.Parameters.AddWithValue("@p_phonenumber", requestBodyJson.phonenumber);

                    
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

            return Ok(message);
        }






    }
}
