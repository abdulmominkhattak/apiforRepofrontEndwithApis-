using System.ComponentModel.DataAnnotations;

namespace apiForUserCrud.Model
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
    
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
  
        public string Department
        {
            get; set;
        }
    }
}

