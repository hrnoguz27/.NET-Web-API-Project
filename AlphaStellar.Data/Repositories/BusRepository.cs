using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaStellar.Data.Interfaces;
using AlphaStellar.Data.Models;

namespace AlphaStellar.Data.Repositories
{
    public class BusRepository:IBusRepository
    {
        public List<Bus> buses = new List<Bus>()
        {
            new Bus {id = 1, color = "red", brand = "BMC", model = "Belde"},
            new Bus {id = 2, color = "blue", brand = "BMC", model = "Neocity"},
            new Bus {id = 3, color = "black", brand = "BMC", model = "Probus"},
            new Bus {id = 4, color = "white", brand = "BMC", model = "Procity"},
            new Bus {id = 5, color = "red", brand = "Mercedes Benz", model = "Travego"},
            new Bus {id = 6, color = "blue", brand = "Mercedes Benz", model = "Tourismo"},
            new Bus {id = 7, color = "black", brand = "Mercedes Benz", model = "MB"},
            new Bus {id = 8, color = "white", brand = "Mercedes Benz", model = "Conecto"},
            new Bus {id = 9, color = "red", brand = "Isuzu", model = "Citibus"},
            new Bus {id = 9, color = "blue", brand = "Isuzu", model = "Citimark"},
            new Bus {id = 9, color = "black", brand = "Isuzu", model = "Citiport"},
            new Bus {id = 9, color = "white", brand = "Isuzu", model = "Classic"},
            new Bus {id = 13, color = "red", brand = "MAN", model = "Fortuna"},
            new Bus {id = 14, color = "blue", brand = "MAN", model = "Lions"},
            new Bus {id = 15, color = "black", brand = "MAN", model = "S2000"},
            new Bus {id = 16, color = "white", brand = "MAN", model = "S3520"},
            new Bus {id = 17, color = "red", brand = "Otokar", model = "Doruk"},
            new Bus {id = 18, color = "blue", brand = "Otokar", model = "Kent"},
            new Bus {id = 19, color = "black", brand = "Otokar", model = "Kaplan"},
            new Bus {id = 20, color = "white", brand = "Otokar", model = "Boynar"},

        };

        public List<Bus> GetBusByColor(string color)
        {
            return buses.Where(t => t.color == color).ToList();
        }
    }
}
