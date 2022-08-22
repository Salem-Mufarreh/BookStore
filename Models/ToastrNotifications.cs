namespace BookStore.Models
{

    public class ToastrNotifications
    {
        public string Message { get; set; }
        public string Type { get; set; }

        public ToastrNotifications(string message, string type)
        {
            this.Type = type;
            this.Message = message;
        }
        public ToastrNotifications()
        {

        }

    }

}
