﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatern_2.Models
{
    public interface IPiece
    {
        bool Killed { get; set; }
        bool IsWhite();
        bool IsKilled();
        bool CanMove();


    }
}