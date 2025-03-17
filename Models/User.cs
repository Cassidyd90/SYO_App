namespace SYO_App.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string ?UserPasswordHash { get; set; }
        public DateTime CreatedUserDate { get; set; }
    }
}
