using apiForUserCrud.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace apiForUserCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        private IUserRespository _users;
        public UserController(IUserRespository Users)
        {
            _users = Users;
        }

        [HttpGet("GetAllUser")]
        public List<User> GetAllUsers()
        {
            return _users.GetAllUsers().ToList();
        }


        [HttpGet("GetUser/{id}")]
        public User GetUser(int id = 1)
        {
            return _users.GetById(id);
            
        }

        [HttpPost("AddUser")]
        public ActionResult AddUser( User user)
        {
            _users.AddUser(user);
            return Ok("success");
;
        }

        [HttpPut("UpdateUser/{id}")]
        public ActionResult UpdateUser(User userfromClient, int id )
        {
            User user = _users.GetById(id);
            user.Name = userfromClient.Name;
            user.Age = userfromClient.Age;
            user.Email = userfromClient.Email;
            user.Gender = userfromClient.Gender;
            user.Department = userfromClient.Gender;

            return Ok("success");
            
        }



        [HttpDelete]
        public void DeleteUser(int id)
        {
            _users.DeleteUser(id);
        }

    }
}
