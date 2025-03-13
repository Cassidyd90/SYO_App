namespace SYO_App.Models
{
    public class QuestionsDaily
    {
        public int UserID { get; set; } // Convention: Pascal case for property names
        public string UserName { get; set; } // Convention: Pascal case for property names
        public string UserEmail { get; set; } // Store email as string for easier handling
        public string UserPasswordHash { get; set; } // Store the hashed password, not the PasswordHasher
        public DateTime CreatedUserDate { get; set; } // Convention: Pascal case for property names
    }
}
