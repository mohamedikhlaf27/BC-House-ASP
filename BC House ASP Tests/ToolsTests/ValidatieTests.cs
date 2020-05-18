using BC_House_ASP.Tools;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BC_House_ASP_Tests
{
    public class ValidatieTests
    {
        [Fact]
        public void CheckValidatiePassword()
        {
            // wachtwoord moet minimaal 8 karaters lang zijn, 1 cijfer bevatten en een hoofdletter bevatten.
            // Arrange
            bool check = false;
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            string passFout = "Welkom"; // niet 8 karaters lang zijn en bevat geen cijfer
            string passFout1 = "welkom123"; // bevat geen hoofdletter
            string passFout2 = "WelkomWelkom"; // bevat geen cijfers
            string passGoed = "Welkom123";

            // Act
            Validatie val = new Validatie();
            if (val.ValidatieWachtwoord(passFout))
            {
                check = true;
            }

            if (val.ValidatieWachtwoord(passFout1))
            {
                check1 = true;
            }

            if (val.ValidatieWachtwoord(passFout2))
            {
                check2 = true;
            }

            if (val.ValidatieWachtwoord(passGoed))
            {
                check3 = true;
            }

            // Assert
            Assert.False(check);
            Assert.False(check1);
            Assert.False(check2);
            Assert.True(check3);
        }
        [Fact]
        public void CheckValidatieEmail()
        {
            // validatie voor email. moet een '@' in zitten.
            // Arrange
            bool check = false;
            bool check1 = false;
            string EmailFout = "ubfiebf.com";
            string EmailGoed = "email@gmail.com";

            // Act
            Validatie val = new Validatie();
            if (val.ValidatieEmail(EmailFout))
            {
                check = true;
            }

            if (val.ValidatieEmail(EmailGoed))
            {
                check1 = true;
            }

            // Assert
            Assert.False(check);
            Assert.True(check1);

        }

        [Fact]
        public void CheckValidatieTelefoonNR()
        {
            // Arrange
            bool check = false;
            bool check1 = false;
            bool check2 = false;
            string NummerFout = "2546154522";
            string NummerGoed = "0612345678";
            string NummerGoed2 = "+31612345678";

            // Act
            Validatie val = new Validatie();
            if (val.ValidatieTelefoonNR(NummerFout))
            {
                check = true;
            }

            if (val.ValidatieTelefoonNR(NummerGoed))
            {
                check1 = true;
            }
            if (val.ValidatieTelefoonNR(NummerGoed2))
            {
                check2 = true;
            }

            // Assert
            Assert.False(check);
            Assert.True(check1);
            Assert.True(check2);

        }

        [Fact]
        public void CheckValidatiePostcode()
        {
            // Arrange
            bool check = false;
            bool check1 = false;
            string PostcodeFout = "1234 ASSS";
            string PostcodeGoed = "1234 AS";

            // Act
            Validatie val = new Validatie();
            if (val.ValidatiePostcode(PostcodeFout))
            {
                check = true;
            }

            if (val.ValidatiePostcode(PostcodeGoed))
            {
                check1 = true;
            }

            // Assert
            Assert.False(check);
            Assert.True(check1);
        }
    }
}
