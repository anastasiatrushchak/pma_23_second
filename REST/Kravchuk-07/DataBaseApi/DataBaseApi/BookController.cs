using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DataBaseApi;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataBaseApi.Controllers
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly string baseconnection = "server=localhost;port=3306;database=forapi;user=root;password=20052005mM;";

       
        [HttpGet]
        public IEnumerable<Book> Get()
        {

            List<Book> books = new List<Book>();
            using (MySqlConnection connection = new MySqlConnection(baseconnection))
            {
                string sqlQuery = "SELECT u.*, p.* FROM book u LEFT JOIN bookinshop p ON book_id = id_on_shop_shelf ";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book
                    {
                        book_id = Convert.ToInt32(reader["book_id"]),
                        book_name = reader["book_name"].ToString(),
                        author = reader["author"].ToString(),
                        year_of_publishing = Convert.ToInt32(reader["year_of_publishing"]),
                        Book_in_shop = new BookInShop
                        {
                            id_on_shop_shelf = reader["id_on_shop_shelf"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id_on_shop_shelf"]),
                            count = Convert.ToInt32(reader["count"]),
                            price = Convert.ToInt32(reader["price"])

                        }
                    };
                    books.Add(book);
                }
                connection.Close();
            }
            return books;
        }

       
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            Book book = null;
            using (MySqlConnection connection = new MySqlConnection(baseconnection))
            {
                string sqlQuery = "SELECT b.*, s.* FROM book b LEFT JOIN bookinshop s ON b.book_id = s.id_on_shop_shelf WHERE b.book_id = @book_id";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@book_id", id);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    book = new Book
                    {
                        book_id = Convert.ToInt32(reader["book_id"]),
                        book_name = reader["book_name"].ToString(),
                        author = reader["author"].ToString(),
                        year_of_publishing = Convert.ToInt32(reader["year_of_publishing"]),
                        Book_in_shop = new BookInShop
                        {
                            id_on_shop_shelf = Convert.ToInt32(reader["id_on_shop_shelf"]),
                            count = Convert.ToInt32(reader["count"]),
                            price = Convert.ToInt32(reader["price"])
                        }
                    };
                }
                connection.Close();
            }
            if (book== null)
            {
                return NotFound();
            }
            return book;
        }
        

        [HttpGet("Params")]
        public IEnumerable<Book> Get(int? book_id = null, string book_name = null)
        {
            List<Book> books = new List<Book>();
            using (MySqlConnection connection = new MySqlConnection(baseconnection))
            {
                string sqlQuery = "SELECT b.*, s.* FROM book b LEFT JOIN bookinshop s ON b.book_id = s.id_on_shop_shelf WHERE (@book_id IS NULL OR b.book_id = @book_id) AND (@book_name IS NULL OR b.book_name = @book_name)";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                // Використовуємо умовний вираз для параметрів, які можуть бути null
                if (book_id.HasValue)
                {
                    command.Parameters.AddWithValue("@book_id", book_id);
                }
                else
                {
                    command.Parameters.AddWithValue("@book_id", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(book_name))
                {
                    command.Parameters.AddWithValue("@book_name", book_name);
                }
                else
                {
                    command.Parameters.AddWithValue("@book_name", DBNull.Value);
                }

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book
                    {
                        book_id = Convert.ToInt32(reader["book_id"]),
                        book_name = reader["book_name"].ToString(),
                        author = reader["author"].ToString(),
                        year_of_publishing = Convert.ToInt32(reader["year_of_publishing"]),
                        Book_in_shop = new BookInShop
                        {
                            id_on_shop_shelf = reader["id_on_shop_shelf"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id_on_shop_shelf"]),
                            count = Convert.ToInt32(reader["count"]),
                            price = Convert.ToInt32(reader["price"])
                        }
                    };
                    books.Add(book);
                }
                connection.Close();
            }
            return books;
        }


        [HttpGet("Header")]
        public ActionResult<Book> GetByIdFromHeader()
        {
            // Перевіряємо, чи є заголовок "book_id"
            if (!Request.Headers.ContainsKey("book_id"))
            {
                return BadRequest("Header 'book_id' is missing.");
            }

            // Отримуємо значення "book_id" з заголовка та перевіряємо, чи воно правильного формату
            if (!int.TryParse(Request.Headers["book_id"], out int bookId))
            {
                return BadRequest("Invalid book_id format.");
            }

            // Підключаємося до бази даних та виконуємо запит
            using (MySqlConnection connection = new MySqlConnection(baseconnection))
            {
                string sqlQuery = "SELECT b.*, s.* FROM book b LEFT JOIN bookinshop s ON b.book_id = s.id_on_shop_shelf WHERE b.book_id = @book_id";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@book_id", bookId);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // Перевіряємо, чи знайдено книжку за заданим book_id
                if (reader.Read())
                {
                    // Створюємо об'єкт книжки та повертаємо його
                    Book book = new Book
                    {
                        book_id = Convert.ToInt32(reader["book_id"]),
                        book_name = reader["book_name"].ToString(),
                        author = reader["author"].ToString(),
                        year_of_publishing = Convert.ToInt32(reader["year_of_publishing"]),
                        Book_in_shop = new BookInShop
                        {
                            id_on_shop_shelf = Convert.ToInt32(reader["id_on_shop_shelf"]),
                            count = Convert.ToInt32(reader["count"]),
                            price = Convert.ToInt32(reader["price"])
                        }
                    };
                    connection.Close(); // Закриваємо підключення до бази даних
                    return book; // Повертаємо книжку
                }
                else
                {
                    connection.Close(); // Закриваємо підключення до бази даних
                    return NotFound(); // Повертаємо помилку "404 Not Found", якщо книжка не знайдена
                }
            }
        }


        [HttpPost("BookInShop")]
        public IActionResult PostBookInShop([FromBody] Book book)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baseconnection))
                {
                    // Додаємо нову книгу до таблиці "book"
                    string addBookQuery = "INSERT INTO book (book_name, author, year_of_publishing) VALUES (@book_name, @author, @year_of_publishing)";
                    MySqlCommand addBookCommand = new MySqlCommand(addBookQuery, connection);
                    addBookCommand.Parameters.AddWithValue("@book_name", book.book_name);
                    addBookCommand.Parameters.AddWithValue("@author", book.author);
                    addBookCommand.Parameters.AddWithValue("@year_of_publishing", book.year_of_publishing);
                    connection.Open();
                    addBookCommand.ExecuteNonQuery();

                    // Отримуємо ідентифікатор нової книги
                    string getLastInsertedIdQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand getLastInsertedIdCommand = new MySqlCommand(getLastInsertedIdQuery, connection);
                    int lastInsertedId = Convert.ToInt32(getLastInsertedIdCommand.ExecuteScalar());

                    // Додаємо новий запис про книгу в магазині до таблиці "bookinshop"
                    string addBookInShopQuery = "INSERT INTO bookinshop (id_on_shop_shelf, price, count) VALUES (@id_on_shop_shelf, @price, @count)";
                    MySqlCommand addBookInShopCommand = new MySqlCommand(addBookInShopQuery, connection);
                    addBookInShopCommand.Parameters.AddWithValue("@id_on_shop_shelf", lastInsertedId);
                    addBookInShopCommand.Parameters.AddWithValue("@book_id", lastInsertedId);
                    addBookInShopCommand.Parameters.AddWithValue("@price", book.Book_in_shop.price);
                    addBookInShopCommand.Parameters.AddWithValue("@count", book.Book_in_shop.count);
                    addBookInShopCommand.ExecuteNonQuery();

                    connection.Close();
                }
                return Ok("Книгу успішно додано до бази даних разом із даними магазину.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Помилка сервера: {ex.Message}");
            }
        }


        [HttpPost("Params")]
        public IActionResult Post_Query([FromQuery] Book book)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baseconnection))
                {
                    connection.Open();

                    // Insert into book table
                    string sqlQueryBook = "INSERT INTO book (book_name, year_of_publishing, author) VALUES (@book_name, @year_of_publishing, @author)";
                    MySqlCommand commandBook = new MySqlCommand(sqlQueryBook, connection);
                    commandBook.Parameters.AddWithValue("@book_name", book.book_name);
                    commandBook.Parameters.AddWithValue("@year_of_publishing", book.year_of_publishing);
                    commandBook.Parameters.AddWithValue("@author", book.author);
                    commandBook.ExecuteNonQuery();

                    // Get the last inserted book_id
                    long lastInsertedBookId = commandBook.LastInsertedId;

                    // Insert into bookinshop table
                    string sqlQueryBookInShop = "INSERT INTO bookinshop (id_on_shop_shelf, price, count) VALUES (@id_on_shop_shelf, @price, @count)";
                    MySqlCommand commandBookInShop = new MySqlCommand(sqlQueryBookInShop, connection);
                    commandBookInShop.Parameters.AddWithValue("@id_on_shop_shelf", lastInsertedBookId);
                    commandBookInShop.Parameters.AddWithValue("@count", book.Book_in_shop.count);
                    commandBookInShop.Parameters.AddWithValue("@price", book.Book_in_shop.price);
                    commandBookInShop.ExecuteNonQuery();
                }

                return Ok();
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


        [HttpPost("Header")]
        public IActionResult PostHeader([FromHeader(Name = "book_name")] string book_name, [FromHeader(Name = "year_of_publishing")] int year_of_publishing, [FromHeader(Name = "author")] string author, 
                                        [FromHeader(Name = "price")] int price, [FromHeader(Name = "count")] int count)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baseconnection))
                {
                    connection.Open();

                    string sqlQuery = "INSERT INTO book (book_name, year_of_publishing, author) VALUES (@book_name, @year_of_publishing, @author)";
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@book_name", book_name);
                    command.Parameters.AddWithValue("@year_of_publishing", year_of_publishing);
                    command.Parameters.AddWithValue("@author", author);
                    command.ExecuteNonQuery();

                    long lastInsertedBookId = command.LastInsertedId;

                    // Insert into bookinshop table
                    string sqlQueryBookInShop = "INSERT INTO bookinshop (id_on_shop_shelf, price, count) VALUES (@id_on_shop_shelf, @price, @count)";
                    MySqlCommand commandBookInShop = new MySqlCommand(sqlQueryBookInShop, connection);
                    commandBookInShop.Parameters.AddWithValue("@id_on_shop_shelf", lastInsertedBookId);
                    commandBookInShop.Parameters.AddWithValue("@count", count);
                    commandBookInShop.Parameters.AddWithValue("@price", price);
                    commandBookInShop.ExecuteNonQuery();

                    connection.Close();
                }
                return Ok();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    return Conflict("Така книга існує.");
                }
                else
                {
                    return StatusCode(500, "Помилка на сервері.");
                }
            }
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
            using (MySqlConnection connection = new MySqlConnection(baseconnection))
            {
                connection.Open();

                string sqlQuery = "UPDATE book SET book_name = @book_name, author = @author, year_of_publishing = @year_of_publishing WHERE book_id = @book_id";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@book_name", book.book_name);
                command.Parameters.AddWithValue("@author", book.author);
                command.Parameters.AddWithValue("@year_of_publishing", book.year_of_publishing);
                command.Parameters.AddWithValue("@book_id", id);
                command.ExecuteNonQuery();

                string sqlQueryBookInShop = "UPDATE bookinshop SET price = @price, count = @count WHERE id_on_shop_shelf = @id_on_shop_shelf";
                MySqlCommand commandBookInShop = new MySqlCommand(sqlQueryBookInShop, connection);
                commandBookInShop.Parameters.AddWithValue("@id_on_shop_shelf", id);
                commandBookInShop.Parameters.AddWithValue("@count", book.Book_in_shop.count);
                commandBookInShop.Parameters.AddWithValue("@price", book.Book_in_shop.price);
                commandBookInShop.ExecuteNonQuery();

                connection.Close();
            }
        }


        [HttpPut("{id}/Params")]
        public void PutParams(int id, [FromQuery] Book book)
        {
            using (MySqlConnection connection = new MySqlConnection(baseconnection))
            {
                connection.Open();

                string sqlQuery = "UPDATE book SET book_name = @book_name, author = @author, year_of_publishing = @year_of_publishing WHERE book_id = @book_id";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@book_name", book.book_name);
                command.Parameters.AddWithValue("@author", book.author);
                command.Parameters.AddWithValue("@year_of_publishing", book.year_of_publishing);
                command.Parameters.AddWithValue("@book_id", id);
                command.ExecuteNonQuery();

                string sqlQueryBookInShop = "UPDATE bookinshop SET price = @price, count = @count WHERE id_on_shop_shelf = @id_on_shop_shelf";
                MySqlCommand commandBookInShop = new MySqlCommand(sqlQueryBookInShop, connection);
                commandBookInShop.Parameters.AddWithValue("@id_on_shop_shelf", id);
                commandBookInShop.Parameters.AddWithValue("@count", book.Book_in_shop.count);
                commandBookInShop.Parameters.AddWithValue("@price", book.Book_in_shop.price);
                commandBookInShop.ExecuteNonQuery();

                connection.Close();
            }
        }


        [HttpPut("{id}/Header")]
        public IActionResult PutHeader(int id, [FromHeader(Name = "book_name")] string book_name, [FromHeader(Name = "year_of_publishing")] int year_of_publishing, [FromHeader(Name = "author")] string author,
                                        [FromHeader(Name = "price")] int price, [FromHeader(Name = "count")] int count)
        {
            try
            {
                using (MySqlConnection myConnection = new MySqlConnection(baseconnection))
                {
                    myConnection.Open();

                    string sqlQuery = "UPDATE book SET book_name = @book_name, author = @author, year_of_publishing = @year_of_publishing WHERE book_id = @book_id";
                    MySqlCommand myCommand = new MySqlCommand(sqlQuery, myConnection);
                    myCommand.Parameters.AddWithValue("@book_name", book_name);
                    myCommand.Parameters.AddWithValue("@author", author);
                    myCommand.Parameters.AddWithValue("@year_of_publishing", year_of_publishing);
                    myCommand.Parameters.AddWithValue("@book_id", id);
                    myCommand.ExecuteNonQuery();

                    string sqlQueryBookInShop = "UPDATE bookinshop SET price = @price, count = @count WHERE id_on_shop_shelf = @id_on_shop_shelf";
                    MySqlCommand commandBookInShop = new MySqlCommand(sqlQueryBookInShop, myConnection);
                    commandBookInShop.Parameters.AddWithValue("@id_on_shop_shelf", id);
                    commandBookInShop.Parameters.AddWithValue("@count", count);
                    commandBookInShop.Parameters.AddWithValue("@price", price);
                    commandBookInShop.ExecuteNonQuery();

                    myConnection.Close();
                }
                return Ok();
            }
            catch (MySqlException myEx)
            {
                if (myEx.Number == 1062)
                {
                    return Conflict("Така книга вже існує.");
                }
                else
                {
                    return StatusCode(500, "Помилка на сервері.");
                }
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baseconnection))
                {
                    string checkUserQuery = "SELECT COUNT(*) FROM book WHERE book_id = @book_id";
                    MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, connection);
                    checkUserCommand.Parameters.AddWithValue("@book_id", id);
                    connection.Open();
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());
                    connection.Close();

                    if (userCount == 0)
                    {
                        // Користувача не знайдено
                        return NotFound("Користувача з таким ID не знайдено.");
                    }

                    string deleteUserQuery = "DELETE FROM book WHERE book_id = @book_id";
                    MySqlCommand deleteUserCommand = new MySqlCommand(deleteUserQuery, connection);
                    deleteUserCommand.Parameters.AddWithValue("@book_id", id);
                    connection.Open();
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
    }
}
     