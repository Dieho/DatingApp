namespace DatingApp.API.Models
{
    public class Users
    {
        public int Id {get ;set;}
        public string UserName {get;set;}
        public byte[] PasswordHash{get;set;}
        public byte[] PasswordSalt {get;set;}
    }
}