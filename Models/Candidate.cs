namespace Course.Models
{
    public class Candidate
    {
        //? kısımları nullcheck olarak geçer. ? varsa bu null olabilir demektir.
        public String? Email {get; set;} = string.Empty;
        public String? FirstName {get; set;} = string.Empty;
        public String? LastName {get; set;} = string.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}"; //eğer bir soyisim var ise onu büyüt. ? koymazsak uyarı verir.
        public int Age {get; set;}

        public String SelectedCourse {get; set;} = string.Empty;
        public DateTime ApplyAt {get; set;}

        public Candidate() {

            ApplyAt = DateTime.Now;
        }

    }


    
}