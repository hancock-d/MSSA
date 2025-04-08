using _10._3CarsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10._3CarsDB.Data;

namespace _10._3CarsDB.Services
{
    public class CRUD
    {
        public void AddInventory(Car car)
        {
            Data.Inventory.carContext.Add(car);
            Inventory.carContext.SaveChanges();
        }

        public void RemoveInventory(string vin)
        {
            var car = Inventory.carContext.Cars.Find(vin);
            if (car != null)
            {
                Inventory.carContext.Cars.Remove(car);
                Inventory.carContext.SaveChanges();
            }
        }

        //Edit/Update
        public void EditInventory(string vin, Car car) //vin of car I want to update, car contains updated info
        {
            var cartoedit = Inventory.carContext.Cars.Find(vin);
            if (cartoedit != null)
            {
                cartoedit.VIN = car.VIN;
                cartoedit.Make = car.Make;
                cartoedit.Model = car.Model;
                cartoedit.Year = car.Year;
                cartoedit.Price = car.Price;

                //cartoedit = new Car()
                //{
                //    VIN = car.VIN,
                //    Make = car.Make,
                //    Model = car.Model,
                //    Year = car.Year,
                //    Price = car.Price,
                //};
            }
        }

        public Car FindCar(string vin)
        {
            return Inventory.carContext.Cars.Find(vin);
        }

        public ICollection<Car> GetCars()
        {
            return Inventory.carContext.Cars.ToList();
        }
    }
}