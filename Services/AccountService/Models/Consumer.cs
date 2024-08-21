namespace AccountService.Models
{
    public class Consumer
    {
        public int Id { get; set; }
        public required string Firstname { get; set; }
        public required string Surname { get; set; }
        public int Age { get; set; }
    }
}
