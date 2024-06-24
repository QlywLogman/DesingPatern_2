using DesingPatern_2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatern_2.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Password { get; set; } = string.Empty;
        AccountStatus Status { get; set; }
        public bool ResetPassword()
        {
            throw new NotImplementedException();
        }

    }

}
