using System;
using System.Collections.Generic;
using Xunit;

namespace bagOLoot.Tests
{
    public class BagShould
    {
        [Fact]
        public void AddChildToRegister()
        {
            Child dude = new Child();
            dude.FirstName = "Dude";
            dude.LastName = "El Duderino";
            dude.Address = "Passadena";

            ChildRegister childRegister = new ChildRegister();
            childRegister.AddChild(dude);


            Assert.Contains(dude, childRegister.GetRegister());
        }
        [Fact]
        public void AddPresent()
        {
            
            Child bobby = new Child();
            bobby.FirstName = "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "123 Fake St";

            Present bike = new Present(bobby);
            bike.Name = "Bike";
            bike.Child = bobby;

            Bag bag = new Bag();
            bag.AddPresent(bike);

            Assert.Contains(bike, bag.GetContents());
        }

        [Fact]
        public void RemovePresent()
        {
            
            Child bobby = new Child();
            bobby.FirstName = "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "123 Fake St";

            Present bike = new Present(bobby);
            bike.Name = "Bike";
            bike.Child = bobby;

            Bag bag = new Bag();
            bag.AddPresent(bike);
            bag.RemovePresent(bike);
            Assert.DoesNotContain(bike, bag.GetContents());
        }

        [Fact]
        public void DeliverPresent()
        {
            
            Child bobby = new Child();
            bobby.FirstName = "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "123 Fake St";

            Present bike = new Present(bobby);
            bike.Name = "Bike";
            bike.Child = bobby;

            Bag bag = new Bag();
            bag.AddPresent(bike);
            bag.DeliverPresent(bike);

            Assert.True(bike.Delivered);
            Assert.DoesNotContain(bike, bag.GetContents());
        }

        
    }
}
