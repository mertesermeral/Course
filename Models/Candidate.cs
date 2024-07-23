namespace Course.Models
{
    public class Candidate
    {
        public String Email {get; set;} = string.Empty;
        public String FirstName {get; set;} = string.Empty;
        public String LastName {get; set;} = string.Empty;
        public int Age {get; set;}

        public String SelectedCourse {get; set;} = string.Empty;
        public DateTime ApplyAt {get; set;}

        public Candidate() {

            ApplyAt = DateTime.Now;
        }

    }


    
}