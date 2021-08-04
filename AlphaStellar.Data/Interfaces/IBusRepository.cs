using System;
using System.Collections.Generic;
using System.Text;
using AlphaStellar.Data.Models;

namespace AlphaStellar.Data.Interfaces
{
    public interface IBusRepository
    {
        List<Bus> GetBusByColor(string color);
    }
}
