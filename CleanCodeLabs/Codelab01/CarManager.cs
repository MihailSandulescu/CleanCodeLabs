using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab01
{
    public class CarManager
    {
            private readonly CarDb _carsDb;

            public CarManager()
            {
                _carsDb = new CarDb();
            }

            public Car GetCarById(string id)
            {
                foreach (var car in _carsDb.GetCarsFromDb())
                {
                    if (car.Id.Equals(id))
                    {
                        return car;
                    }
                }
                return null;
            }

            public string GetCarsNames()
            {
                var sb = new StringBuilder();
                foreach (var car in _carsDb.GetCarsFromDb())
                {
                    sb.Append(car.Brand);
                    sb.Append(" ");
                    sb.Append(car.Model);
                    sb.Append(", ");
                }

                var carNames = sb.ToString();
                return carNames.Substring(0, carNames.Length - 2);
            }

            public Car GetBestCar()
            {
                Car bestCar = null;
                foreach (var car in _carsDb.GetCarsFromDb())
                {
                    if (bestCar == null || car.Model.CompareTo(bestCar.Model) > 0)
                    {
                        bestCar = car;
                    }
                }
                return bestCar;
            }
    }
 }
