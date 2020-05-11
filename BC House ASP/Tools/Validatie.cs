using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BC_House_ASP.Tools
{
    public class Validatie
    {
        /// <summary>
        /// Hier staan alle validatie voor het registreren
        /// </summary>

        // validatie voor email. moet een '@' in zitten.
        public bool ValidatieEmail(string klantEmail)
        {
            return Regex.IsMatch(klantEmail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        // wachtwoord moet minimaal 8 karaters lang zijn, 1 cijfer bevatten en een hoofdletter bevatten.
        public bool ValidatieWachtwoord(string klantPassword)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(klantPassword) && hasUpperChar.IsMatch(klantPassword) && hasMinimum8Chars.IsMatch(klantPassword);
            return isValidated;

        }

        // validatie voor nederlandse telefoon nummer, moet beginnen met 0 en/of +31
        public bool ValidatieTelefoonNR(string telefoonnummer)
        {
            return Regex.IsMatch(telefoonnummer, @"^((\+|00(\s|\s?\-\s?)?)31(\s|\s?\-\s?)?(\(0\)[\-\s]?)?|0)[1-9]((\s|\s?\-\s?)?[0-9])((\s|\s?-\s?)?[0-9])((\s|\s?-\s?)?[0-9])\s?[0-9]\s?[0-9]\s?[0-9]\s?[0-9]\s?[0-9]$");
        }

        // validatie voor nederlandse postcodes
        public bool ValidatiePostcode(string postcode)
        {
            return Regex.IsMatch(postcode, @"^[1-9][0-9]{3} ?(?!sa|sd|ss|SA|SD|SS)[A-Za-z]{2}$");
        }
    }
}
