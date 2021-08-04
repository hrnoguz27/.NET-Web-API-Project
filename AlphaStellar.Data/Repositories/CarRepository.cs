using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaStellar.Data.Interfaces;
using AlphaStellar.Data.Models;

namespace AlphaStellar.Data.Repositories
{
    public class CarRepository:ICarRepository
    {
        public List<Car> cars = new List<Car>()
        {
            new Car {id = 1,wheels = true, headlights = true, color = "red", brand = "BMW", model = "340i"},
            new Car {id = 2,wheels = true, headlights = true, color = "blue", brand = "BMW", model = "420d"},
            new Car {id = 3,wheels = true, headlights = true, color = "black", brand = "BMW", model = "M3"},
            new Car {id = 4,wheels = true, headlights = true, color = "white", brand = "BMW", model = "M4"},
            new Car {id = 5,wheels = true, headlights = true, color = "red", brand = "Mercedes Benz", model = "CLA"},
            new Car {id = 6,wheels = true, headlights = true, color = "blue", brand = "Mercedes Benz", model = "A200"},
            new Car {id = 7,wheels = true, headlights = true, color = "black", brand = "Mercedes Benz", model = "C180"},
            new Car {id = 8,wheels = true, headlights = true, color = "white", brand = "Mercedes Benz", model = "GLA"},
            new Car {id = 9,wheels = true, headlights = true, color = "red", brand = "Renault", model = "Clio"},
            new Car {id = 9,wheels = true, headlights = true, color = "blue", brand = "Renault", model = "Megane"},
            new Car {id = 9,wheels = true, headlights = true, color = "black", brand = "Renault", model = "Fluence"},
            new Car {id = 9,wheels = true, headlights = true, color = "white", brand = "Renault", model = "Latitude"},
            new Car {id = 13,wheels = true, headlights = true, color = "red", brand = "Audi", model = "A1"},
            new Car {id = 14,wheels = true, headlights = true, color = "blue", brand = "Audi", model = "A3"},
            new Car {id = 15,wheels = true, headlights = true, color = "black", brand = "Audi", model = "A4"},
            new Car {id = 16,wheels = true, headlights = true, color = "white", brand = "Audi", model = "A6"},
            new Car {id = 17,wheels = true, headlights = true, color = "red", brand = "Citroen", model = "C1"},
            new Car {id = 18,wheels = true, headlights = true, color = "blue", brand = "Citroen", model = "C2"},
            new Car {id = 19,wheels = true, headlights = true, color = "black", brand = "Citroen", model = "C3"},
            new Car {id = 20,wheels = true, headlights = true, color = "white", brand = "Citroen", model = "C4"},

        };


        public List<Car> GetCarByColor(string color)
        {
            return cars.Where(t => t.color == color).ToList();
        }

        public bool RemoveCar(int id)
        {
            try
            {
                var itemToRemove = cars.Single(t => t.id == id);
                if (itemToRemove != null)
                {
                    cars.Remove(itemToRemove);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public bool SetCarHeadLights(int id)
        {
            try
            {
                var carToUpdate = cars.Single(t => t.id == id);
                if (carToUpdate != null)
                {
                    carToUpdate.headlights = !carToUpdate.headlights; // if headlight is on then turn off , if headlight is off then turn on
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
