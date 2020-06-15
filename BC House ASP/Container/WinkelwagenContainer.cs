using BC_House_ASP.Interface;
using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Container
{
    public class WinkelwagenContainer
    {
        IWinkelwagen WinkelwagenDAL;

        public WinkelwagenContainer(IWinkelwagen winkelwagenDAL)
        {
            this.WinkelwagenDAL = winkelwagenDAL;
        }
        public static List<Winkelwagen> WinkelwagenList { get; set; } = new List<Winkelwagen>();

        public List<Winkelwagen> GetList()
        {
            return WinkelwagenList;
        }

        public void ClearList()
        {
            WinkelwagenList = new List<Winkelwagen>();
            WinkelwagenList.Clear();
        }

        //product toevoegen aan winkelwagen.
        public void AddProductToCart(Product product, Winkelwagen winkelwagen)
        {
            var winkelwagenList = GetList();
            Winkelwagen newProduct = new Winkelwagen(product.id);
            
            //check als product al in de winkewagen zit wordt de hoeveelheid opgeteld.
            if (winkelwagenList.Contains(newProduct))
            {
                foreach (Winkelwagen products in winkelwagenList)
                {
                    if (products.Equals(newProduct))
                    {
                        products.hoeveelheid++;
                        return;
                    }
                }
            }
            else
            {
                var Productdetails = WinkelwagenDAL.Getproduct(winkelwagen.Prod.id);
                newProduct.Prod.id = Productdetails.Prod.id;
                newProduct.Prod.productNaam = Productdetails.Prod.productNaam;
                newProduct.Prod.omschrijving = Productdetails.Prod.omschrijving;
                newProduct.Prod.tag = Productdetails.Prod.tag;
                newProduct.Prod.prijs = Productdetails.Prod.prijs;

                newProduct.hoeveelheid = winkelwagen.hoeveelheid;

                winkelwagenList.Add(newProduct);
            }
        }

        //Hoeveheid bepalen
        public void SetProductQuantity(Product product, Winkelwagen winkelwagen)
        {
            // als de hoevelheid nul is verwijder de product.
            if (winkelwagen.hoeveelheid == 0)
            {
                RemoveProduct(winkelwagen);
                return;
            }

            Winkelwagen updatedProduct = new Winkelwagen(product.id);
            updatedProduct.hoeveelheid = winkelwagen.hoeveelheid;
            var winkelwagenList = GetList();

            // update de hoeveelheid van een product in de list
            foreach (Winkelwagen products in winkelwagenList)
            {
                if (products.hoeveelheid.Equals(updatedProduct.hoeveelheid))
                {
                    products.hoeveelheid = winkelwagen.hoeveelheid;
                    return;
                }
            }
        }

        // product verwijderen.
        public void RemoveProduct(Winkelwagen product)
        {

            var winkelwagenList = GetList();

            winkelwagenList.Remove(product);
        }

        // Totale Prijs
        public double TotalPrice()
        {
            var winkelwagenList = GetList();

            double subTotal = 0;

            foreach (Winkelwagen product in winkelwagenList)
            {
                subTotal += product.TotalPrice;
            }
            return subTotal;
        }
    }
}
