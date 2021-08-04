using System;
using System.Collections.Generic;
using System.Text;
using AlphaStellar.Data.Models;

namespace AlphaStellar.Data.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetBoatByColor(string color);
    }
}
