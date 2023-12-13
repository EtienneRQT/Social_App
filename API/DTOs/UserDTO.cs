using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs

{   /// <summary>
    /// Represents a user data transfer object for API requests and responses.
    /// Contains basic user information like username and auth token.
    /// </summary>
    public class UserDTO
    {
        public string Username { get; set; }
        public string Token { get; set; }
    }
}