using System;
using System.Collections.Generic;
using Xunit;

namespace bagOLoot.Tests
{
    public class ChildRegisterShould
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
    }
}