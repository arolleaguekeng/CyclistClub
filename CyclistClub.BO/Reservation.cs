﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BO
{
    public class Reservation : BaseModel
    {
        public int Id_membre { get; set; }
        public string TypeReservation { get; set; }

    }
}
