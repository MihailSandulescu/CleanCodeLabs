using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab01
{
    public class CarDb
    {
        private readonly List<Car> _carsDb = new List<Car>(new[]
        {
            new Car("1", "Golf III", "Volkswagen"),
            new Car("2", "Multipla", "Fiat"),
            new Car("3", "Megane", "Renault")
        });

        public List<Car> GetCarsFromDb()
        {
            return _carsDb;
        }
    }
}