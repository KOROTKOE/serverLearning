using ShopLearning.Data.Interfaces;
using ShopLearning.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopLearning.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car>
                {
                    new Car
                {
                    name = "Tesla",
                    shortDesc = "Электродвигатель",
                    longDesc = "Электрический двигатель настолько бесшумный что вы услышите как пердит воробей чем звук мотора",
                    img = "https://wsjournal.ru/wp-content/uploads/2020/09/dc62f311d55547ce849117d0aac88d83-scaled.jpg",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.First()
                },
                    new Car
                {
                    name = "Honda",
                    shortDesc = "Подтяшки",
                    longDesc = "Подтяшки этой марки автомобиля поможет Вам ощутить что такое по-настоящему удобство",
                    img = "http://otzyvy-avtovladelcev.ru/img/auto-body-image/3186/48383.jpg",
                    price = 35000,
                    isFavorite = false,
                    available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
                    new Car
                {
                    name = "Toyota",
                    shortDesc = "Японская машина",
                    longDesc = "Та самая машина которая будет выручать вас в любой трудный момент",
                    img = "https://4-x-4.ru/wp-content/uploads/2019/12/f191237d.jpeg",
                    price = 30000,
                    isFavorite = true,
                    available = false,
                    Category = _categoryCars.AllCategories.Last()
                },
                    new Car
                {
                    name = "Skoda",
                    shortDesc = "Что то там на знаке непонятное",
                    longDesc = "Вот это реально машина, все есть, и качество и удобное расположение сиденей сразу заметно",
                    img = "https://a.d-cd.net/27e035es-960.jpg",
                    price = 55000,
                    isFavorite = false,
                    available = false,
                    Category = _categoryCars.AllCategories.Last()
                },
                    new Car
                {
                    name = "Электрокар",
                    shortDesc = "Электрический двигатель",
                    longDesc = "Это современный вариант усовершенствованного моделя будущего, я бы себе 10 штук купил бы",
                    img = "https://a.d-cd.net/a1c2b46s-1920.jpg",
                    price = 65000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.First()
                }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int CarID)
        {
            throw new NotImplementedException();
        }
    }
}
