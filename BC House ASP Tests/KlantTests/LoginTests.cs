using BC_House_ASP.Container;
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
            //var klantdal = new KlantDAL();

            klantDalStub.ExistReturnValue = true;

            // act 
            var Result = klantDalStub.CheckEmailExistance("email");

            // assert
            Assert.True(Result);
        }

        [Fact]
        public void Check_If_Email_Exist_Failed()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            //var klantdal = new KlantDAL();

            klantDalStub.ExistReturnValue = false;

            // act 
            var Result = klantDalStub.CheckEmailExistance("email");

            // assert
            Assert.False(Result);
        }

        [Fact]
        public void Check_Password_By_Email_Passed()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            //var klantdal = new KlantDAL();

            klantDalStub.ExistReturnValue = true;

            // act 
            var Result = klantDalStub.CheckPasswordByEmail("aEmail", "aPassword");

            // assert
            Assert.True(Result);
        }

        [Fact]
        public void Check_Password_By_EmailFailed()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            //var klantdal = new KlantDAL();

            klantDalStub.ExistReturnValue = false;

            // act 
            var Result = klantDalStub.CheckPasswordByEmail("aEmail", "aPassword");

            // assert
            Assert.False(Result);
        }

        [Fact]
        public void Check_If_User_exists()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            var klantContainer = new KlantContainer(klantDalStub);

            klantDalStub.ExistReturnValue = true;

            // act 
            var result = klantContainer.CheckIfUserExists("aEmail", "aPassword");

            // assert
            Assert.True(result);

        }
    }
}
