namespace BookStore.Models
{
    public class LoggedInUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string CartId { get; set; }
        public string Role { get; set; }

    }
}