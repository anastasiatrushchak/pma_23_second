namespace REST_Api_users_.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public User_Profile UserProfile { get; set; }

    }
}
