namespace SYO_App.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public int DayNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
