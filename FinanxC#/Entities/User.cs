namespace Finanx.Entities
{
    public class User
    {
        public User(String id, String name, String email, String password) 
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        private String Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
}
