namespace Course.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
        private static IEnumerable<Candidate> Applications => applications; //readonly erişim

        public static void Add(Candidate candidate)//formdan gelen elemanları ekleme
        { 
            applications.Add(candidate);

        } 






    }
}