using System;
using Assignment1;
using Assignment1.CarBrands;
using Assignment1.ColourDecoration;
using Assignment1.Command;
using Assignment1.Engine;
using Assignment1.Main;
using Assignment1.Vehicles;
using Assignment1.WheelDecorations;
using Xunit;

namespace Assignment1Test
{
    public class UnitTest1
    {
        [Fact]
        public void ChangePriceCommandTest()
        {
            CarDealer carDealer = new CarDealer();
            Vehicle veh1 = new Car(new Black(new Matt()), new Summer(new SteelRims()), new VW(), new Numberplate("12-GG-13"), new Diesel());
            Vehicle veh2 = new Car(new White(new Shiney()), new Winter(new AluRims()), new BMW(), new Numberplate("12-yy-99"), new Benzin());
            Vehicle veh3 = new Car(new Green(new Metallic()), new Both(new SpareTire()), new Mercedes(), new Numberplate("24-04-09"), new Electro());
            carDealer.AddVehicleToList(veh1);
            carDealer.AddVehicleToList(veh2);
            carDealer.AddVehicleToList(veh3);

            Assert.Equal(1,veh1.ID);
            Assert.Equal(2,veh2.ID);
            Assert.Equal(3, veh3.ID);

            Assert.Equal(3,carDealer.Vehicles.Count);

        }
    }
}
