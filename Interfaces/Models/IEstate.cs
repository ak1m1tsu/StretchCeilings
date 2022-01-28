﻿using System.Collections.Generic;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Interfaces.Models
{
    public interface IEstate
    {
        void Add();
        void Update();
        void Delete();
        List<Room> GetRooms();
    }
}
