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
        IProductDAL productDAL;

        public void AllProducts()
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

        public void FilterBeefBurgers()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Beefburgers'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterBeefBurgersMenu()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Beefmenu'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterBuckets()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Buckets'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterChickenBurger()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Chickenburgers'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterChickenBurgerMenu()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Chickenmenu'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterDrinks()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Drinks'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterSaus()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Saus'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterFriet()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Friet'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterIcecream()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Icecream'", GetCon());
            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            AddTable();
            adapt.Fill(table);

            CloseConnectionToDB();

            cmd = new SqlCommand();

            SaveProductsInList();
        }

        public void FilterPortie()
        {
            cmd = new SqlCommand("Select * from Product Where tag = 'Portie'", GetCon());
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
                ProductContainer productcontainer = new ProductContainer(productDAL);
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
                        Tag = dr["Tag"].ToString()
                    };
                    productslist.Add(product);
                }
                ClearTable();
            }
        }
    }
}
