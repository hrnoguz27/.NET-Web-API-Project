using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaStellar.Data.Interfaces;
using AlphaStellar.Data.Models;

namespace AlphaStellar.Data.Repositories
{
    public class BoatRepository:IBoatRepository
    {
        public List<Boat> boats = new List<Boat>()
        {
            new Boat {id = 1, color = "red", brand = "Motoryat", model = "A1234"},
            new Boat {id = 2, color = "blue", brand = "Motoryat", model = "A2165"},
            new Boat {id = 3, color = "black", brand = "Motoryat", model = "A3265"},
            new Boat {id = 4, color = "white", brand = "Motoryat", model = "A5486"},
            new Boat {id = 5, color = "red", brand = "Yelkenli", model = "B6546"},
            new Boat {id = 6, color = "blue", brand = "Yelkenli", model = "B2000"},
            new Boat {id = 7, color = "black", brand = "Yelkenli", model = "B1580"},
            new Boat {id = 8, color = "white", brand = "Yelkenli", model = "B9886"},
            new Boat {id = 9, color = "red", brand = "Sürat Teknesi", model = "C5465"},
            new Boat {id = 9, color = "blue", brand = "Sürat Teknesi", model = "C2126"},
            new Boat {id = 9, color = "black", brand = "Sürat Teknesi", model = "C6563"},
            new Boat {id = 9, color = "white", brand = "Sürat Teknesi", model = "C1543"},
            new Boat {id = 13, color = "red", brand = "Jet Ski", model = "D5656"},
            new Boat {id = 14, color = "blue", brand = "Jet Ski", model = "D5215"},
            new Boat {id = 15, color = "black", brand = "Jet Ski", model = "D5486"},
            new Boat {id = 16, color = "white", brand = "Jet Ski", model = "D3218"},
            new Boat {id = 17, color = "red", brand = "Gulet", model = "E1234"},
            new Boat {id = 18, color = "blue", brand = "Gulet", model = "E5456"},
            new Boat {id = 19, color = "black", brand = "Gulet", model = "E8474"},
            new Boat {id = 20, color = "white", brand = "Gulet", model = "E2155"},

        };

        public List<Boat> GetBoatByColor(string color)
        {
            return boats.Where(t => t.color == color).ToList();
        }
    }
}
