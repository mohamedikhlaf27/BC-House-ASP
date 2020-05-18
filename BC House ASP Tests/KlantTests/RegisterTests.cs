using BC_House_ASP.Container;
using BC_House_ASP_Tests.Stub;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BC_House_ASP_Tests.KlantTests
{
    public class RegisterTests
    {
        [Fact]
        public void Check_If_User_Is_Added_To_Database()
        {
            // arrange
            var klantDalStub = new KlantDALStub();

            klantDalStub.ExistReturnValue = false;

            // act 
            klantDalStub.AddKlant("aName", "aEmail", "0612345678", "aPassword", "aPostalCode", "aHouseNR", "aStreet", "aResidence");

            // assert
            Assert.True(klantDalStub.ExistReturnValue);
        }

        [Fact]
        public void Check_KlantContainer_AccountAanmaken()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            var klantContainer = new KlantContainer(klantDalStub);

            klantDalStub.ExistReturnValue = false;

            // act 
            klantContainer.Accountmaken("aName", "aEmail", "0612345678", "aPassword", "aPostalCode", "aHouseNR", "aStreet", "aResidence");

            // assert
            Assert.True(klantDalStub.ExistReturnValue);

        }

        [Fact]
        public void Register_Check()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            var klantContainer = new KlantContainer(klantDalStub);

            klantDalStub.ExistReturnValue = true;

            // act 
            var result = klantContainer.registerCheck("test@live.com", "Welkom12345", "0612345678", "5213AS");

            // assert
            Assert.True(result);
        }
    }
}
