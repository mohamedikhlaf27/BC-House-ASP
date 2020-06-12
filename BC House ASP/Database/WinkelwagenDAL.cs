using BC_House_ASP.Interface;
using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Database
{
    public class WinkelwagenDAL : Databasehandler, IWinkelwagen
    {
        public Winkelwagen Getproduct(int ProductID)
        {
            cmd = new SqlCommand("Select * from Product WHERE ID = @productID", GetCon());
            cmd.Parameters.AddWithValue("@productID", ProductID);
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            Winkelwagen product = new Winkelwagen(ProductID);

            if (table.Rows.Count != 0)
            {
                product.Prod.id = Convert.ToInt32(table.Rows[0]["ID"]);
                product.Prod.productNaam = table.Rows[0][1].ToString();
                product.Prod.prijs = Convert.ToDouble(table.Rows[0][2]);
                product.Prod.omschrijving = table.Rows[0][3].ToString();
                product.Prod.tag = table.Rows[0][4].ToString();
            }
            return product;
        }
    }
}
