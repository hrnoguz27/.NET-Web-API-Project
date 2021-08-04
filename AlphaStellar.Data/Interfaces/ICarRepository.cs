using System;
using System.Collections.Generic;
using System.Text;
using AlphaStellar.Data.Models;

namespace AlphaStellar.Data.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarByColor(string color);
        bool RemoveCar(int id);
        bool SetCarHeadLights(int id);
    }
}
