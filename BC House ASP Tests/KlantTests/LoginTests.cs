using BC_House_ASP.Container;
using BC_House_ASP.Models;
using BC_House_ASP_Tests.Stub;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BC_House_ASP_Tests.KlantTests
{
    public class LoginTests
    {
        [Fact]
        public void Check_If_Email_Exist_Passed()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            Klant klant = new Klant();
            klantDalStub.ExistReturnValue = true;

            // act 
            var Result = klantDalStub.CheckEmailExistance(klant);

            // assert
            Assert.True(Result);
        }

        [Fact]
        public void Check_If_Email_Exist_Failed()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            //var klantdal = new KlantDAL();
            Klant klant = new Klant();
            klantDalStub.ExistReturnValue = false;

            // act 
            var Result = klantDalStub.CheckEmailExistance(klant);

            // assert
            Assert.False(Result);
        }

        [Fact]
        public void Check_Password_By_Email_Passed()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            //var klantdal = new KlantDAL();
            Klant klant = new Klant();
            klantDalStub.ExistReturnValue = true;

            // act 
            var Result = klantDalStub.CheckPasswordByEmail(klant);

            // assert
            Assert.True(Result);
        }

        [Fact]
        public void Check_Password_By_EmailFailed()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            //var klantdal = new KlantDAL();
            Klant klant = new Klant();
            klantDalStub.ExistReturnValue = false;

            // act 
            var Result = klantDalStub.CheckPasswordByEmail(klant);

            // assert
            Assert.False(Result);
        }

        [Fact]
        public void Check_If_User_exists()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            var klantContainer = new KlantContainer(klantDalStub);
            Klant klant = new Klant();
            klantDalStub.ExistReturnValue = true;

            // act 
            var result = klantContainer.CheckIfUserExists(klant);

            // assert
            Assert.True(result);

        }

        [Fact]
        public void Check_If_Get_LoginKlant()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            var klantContainer = new KlantContainer(klantDalStub);
            Klant klant = new Klant();
            klantDalStub.ExistReturnValue = true;
            

            // act 
            var result = klantContainer.LoginKlant(klant);
            
            // assert
            Assert.Equal(12, result.Id);
        }

        [Fact]
        public void Check_If_Get_GetKlant()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            Klant klant = new Klant();
            klantDalStub.ExistReturnValue = true;

            // act 
            var result = klantDalStub.GetKlant(klant);
           
            // assert
            Assert.Equal(klant, result);
        }
    }
}
