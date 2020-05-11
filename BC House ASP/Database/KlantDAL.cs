using BC_House_ASP.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Database
{
    public class KlantDAL : Databasehandler, IKlantDAL
    {
        /// <summary>
        /// Querys voor de login en registeren.
        /// </summary>

        // login
        // checkt of de email bestaat
        public bool CheckEmailExistance(string klantEmail)
        {
            cmd = new SqlCommand("SELECT COUNT(Email) FROM Customer WHERE Email = @inputEmail", GetCon());
            cmd.Parameters.AddWithValue("@inputEmail", klantEmail);

            OpenConnectionToDB();
            if (Convert.ToInt32(cmd.ExecuteScalar()) != 0)
            {
                CloseConnectionToDB();
                cmd = new SqlCommand();

                return true;
            }
            else
            {
                CloseConnectionToDB();
                cmd = new SqlCommand();

                return false;
            }
        }

        // checkt of dat de wachtwoord bij het email hoort.
        public bool CheckPasswordByEmail(string klantPassword, string klantEmail)
        {
            cmd = new SqlCommand("SELECT COUNT(Password) FROM Customer WHERE Password = @inputPass AND Email = @inputEmail", GetCon());
            cmd.Parameters.AddWithValue("@inputPass", klantPassword);
            cmd.Parameters.AddWithValue("@inputEmail", klantEmail);

            OpenConnectionToDB();

            if (Convert.ToInt32(cmd.ExecuteScalar()) != 0)
            {
                CloseConnectionToDB();
                cmd = new SqlCommand();

                return true;
            }
            else
            {
                CloseConnectionToDB();
                cmd = new SqlCommand();

                return false;
            }
        }

        // register - gegevens in de databse toevoegen.
        public void AddKlant(string klantNaam, string klantEmail, int telefoonNummer, string klantPassword, string postcode, string huisNummer, string straat, string woonplaats)
        {
            cmd = new SqlCommand(@"INSERT INTO Customer(Name, Email, [Phone nr], Password, [Postal code], [House nr], Street, Residence) 
                                   VALUES (@inputName, @inputEmail, @inputPhone, @inputPassword, @inputPostal, @inputHouseNR, @inputStreet, @inputResidence)", GetCon());

            OpenConnectionToDB();

            cmd.Parameters.AddWithValue("@inputName", klantNaam);
            cmd.Parameters.AddWithValue("@inputEmail", klantEmail);
            cmd.Parameters.AddWithValue("@inputPhone", telefoonNummer);
            cmd.Parameters.AddWithValue("@inputPassword", klantPassword);
            cmd.Parameters.AddWithValue("@inputPostal", postcode);
            cmd.Parameters.AddWithValue("@inputHouseNR", huisNummer);
            cmd.Parameters.AddWithValue("@inputStreet", straat);
            cmd.Parameters.AddWithValue("@inputResidence", woonplaats);

            cmd.ExecuteNonQuery();
            CloseConnectionToDB();
        }
    }
}

