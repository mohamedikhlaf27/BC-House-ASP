using BC_House_ASP.Container;
using BC_House_ASP.Interface;
using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Database
{
    public class ProductDAL : Databasehandler, IProductDAL
    {
        public void SelectAllProducts()
        {
            cmd = new SqlCommand("Select * from Product", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void SaveProductsInList()
        {
            if (table.Rows.Count > 0)
            {
                Product product;
                ProductContainer productcontainer = new ProductContainer(new ProductDAL());
                List<Product> productslist = productcontainer.GetList();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    var dr = table.Rows[i];
                    product = new Product()
                    {
                        id = Convert.ToInt32(dr["ID"]),
                        productNaam = dr["Name"].ToString(),
                        prijs = Convert.ToDouble(dr["Prize"]),
                        omschrijving = dr["Description"].ToString(),
                        tag = dr["Tag"].ToString()
                    };
                    productslist.Add(product);
                }
                ClearTable();
            }
        }
    }
}
