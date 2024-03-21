namespace JobMatchingWebMVC.Models
{
    public class Users
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsMale { get; set; }
        public bool IsLocked { get; set; } = false;
        public bool IsDeleted { get; set; }
    }
}
