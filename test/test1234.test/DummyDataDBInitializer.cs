using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using test1234.Models;

namespace test1234.test
{
    class DummyDataDBInitializer
    {
        public void Seed()
        {

            // MongoClient client = new MongoClient("mongodb://CarGalleryDb:27017");
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            IMongoDatabase database = client.GetDatabase("CarGalleryDb");

            var cars = database.GetCollection<Car>("Cars");
            var model1 = new Car
            {
                Brand = "BMWX",
                Model = "X7",
                Year = 2019,
                Price = 54321,
                ImageUrl = "\\images\\bmw.png"

            };

            var model2 = new Car
            {
                Brand = "Acura",
                Model = "MDX",
                Year = DateTime.Now.Year,
                Price = 54321,
                ImageUrl = "\\images\\acura.png"

            };
            var model3 = new Car
            {
                Brand = "bugatti",
                Model = "veyron",
                Year = DateTime.Now.Year,
                Price = 99999,
                ImageUrl = "\\images\\bugatti.png"

            };

            cars.InsertManyAsync(new[] { model1, model2});
            cars.InsertOne( model3 );
        }

    }

     
}
