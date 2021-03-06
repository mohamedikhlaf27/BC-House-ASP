﻿using BC_House_ASP.Container;
using BC_House_ASP.Models;
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
            Klant klant = new Klant();

            klantDalStub.ExistReturnValue = false;

            // act 
            klantDalStub.AddKlant(klant);

            // assert
            Assert.True(klantDalStub.ExistReturnValue);
        }

        [Fact]
        public void Check_KlantContainer_AccountAanmaken()
        {
            // arrange
            var klantDalStub = new KlantDALStub();
            var klantContainer = new KlantContainer(klantDalStub);
            Klant klant = new Klant();
            klantDalStub.ExistReturnValue = false;

            // act 
            klantContainer.Accountmaken(klant);

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

            Klant klant = new Klant();
            klant.klantEmail = "test@live.com";
            klant.klantPassword = "Welkom12345";
            klant.telefoonNummer = "0612345678";
            klant.postcode = "5213AS";
            // act 
            var result = klantContainer.registerCheck(klant);

            // assert
            Assert.True(result);
        }
    }
}
