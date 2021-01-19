using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiEFCoreRepository.Models
{
    public partial class User
    {
        public int Idx { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyUser { get; set; }
    }
}
