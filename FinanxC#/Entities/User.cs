namespace Finanx.Entities
{
    public class User
    {
        public User(String id, String name, String lastName, String email, String password) 
        {
           Id = id;
           Name = name;
           LastName = lastName;
           Email = email;
           Password = password;
        }

        private String Id { get; set; }
        private String Name { get; set; }
        private String LastName {  get; set; }
        private String Email { get; set; }
        private String Password { get; set; }
    }
}
