using BC_House_ASP.Interface;
using BC_House_ASP.Models;
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
        public bool CheckEmailExistance(Klant klant)
        {
            cmd = new SqlCommand("SELECT COUNT(Email) FROM Customer WHERE Email = @inputEmail", GetCon());
            cmd.Parameters.AddWithValue("@inputEmail", klant.klantEmail);

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
        public bool CheckPasswordByEmail(Klant klant)
        {
            cmd = new SqlCommand("SELECT COUNT(Password) FROM Customer WHERE Password = @inputPass AND Email = @inputEmail", GetCon());
            cmd.Parameters.AddWithValue("@inputPass", klant.klantPassword);
            cmd.Parameters.AddWithValue("@inputEmail", klant.klantEmail);

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


        public Klant KlantLogin(Klant klant)
        {
            Klant newKlant = new Klant();

            if (CheckPasswordByEmail(klant))
            {
                cmd = new SqlCommand("SELECT * FROM Customer WHERE Email = @email", GetCon());
                cmd.Parameters.AddWithValue("email", klant.klantEmail);

                OpenConnectionToDB();

                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    newKlant.Id = Convert.ToInt32(dataReader["ID"]);
                    newKlant.klantNaam = dataReader["Name"].ToString();
                    newKlant.klantEmail = dataReader["Email"].ToString();
                    newKlant.telefoonNummer = dataReader["Phone nr"].ToString();
                    newKlant.straat = dataReader["Street"].ToString();
                    newKlant.huisNummer = dataReader["House nr"].ToString();
                    newKlant.postcode = dataReader["Postal code"].ToString();
                    newKlant.woonplaats = dataReader["Residence"].ToString();
                }
                dataReader.Close();
                CloseConnectionToDB();
            }
            return newKlant;
        }

        // register - gegevens in de databse toevoegen.

        public void AddKlant(Klant klant)
        {
            cmd = new SqlCommand(@"INSERT INTO Customer(Name, Email, [Phone nr], Password, [Postal code], [House nr], Street, Residence) 
                                   VALUES (@inputName, @inputEmail, @inputPhone, @inputPassword, @inputPostal, @inputHouseNR, @inputStreet, @inputResidence)", GetCon());

            OpenConnectionToDB();

            cmd.Parameters.AddWithValue("@inputName", klant.klantNaam);
            cmd.Parameters.AddWithValue("@inputEmail", klant.klantEmail);
            cmd.Parameters.AddWithValue("@inputPhone", klant.telefoonNummer);
            cmd.Parameters.AddWithValue("@inputPassword", klant.klantPassword);
            cmd.Parameters.AddWithValue("@inputPostal", klant.postcode);
            cmd.Parameters.AddWithValue("@inputHouseNR", klant.huisNummer);
            cmd.Parameters.AddWithValue("@inputStreet", klant.straat);
            cmd.Parameters.AddWithValue("@inputResidence", klant.woonplaats);

            cmd.ExecuteNonQuery();
            CloseConnectionToDB();
        }

    }
}

