using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatern_2.Models
{
    public class Player : Account
    {
        public Person? Person { get; set; }
        public int TotalGamesPlayed { get; set; }

        public bool WhiteSide { get; set; }

        public bool IsWhiteSide()
        {
            throw new NotImplementedException();
        }

        public bool IsChecked()
        {
            throw new Exception();
        }





    }
}
