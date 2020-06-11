using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Container
{
    public class WinkelwagenContainer
    {
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
                newProduct.Prod.id = winkelwagen.Prod.id;
                newProduct.Prod.productNaam = winkelwagen.Prod.productNaam;
                newProduct.hoeveelheid = winkelwagen.hoeveelheid;
                newProduct.Prod.prijs = winkelwagen.Prod.prijs;
                winkelwagenList.Add(newProduct);
            }
        }

        //Hoeveheid bepalen
        public void SetProductQuantity(Product product, Winkelwagen winkelwagen)
        {
            // als de hoevelheid nul is verwijder de product.
            if (winkelwagen.hoeveelheid == 0)
            {
                RevomeProduct(winkelwagen);
                return;
            }

            Winkelwagen updatedProduct = new Winkelwagen(product.id);
            var winkelwagenList = GetList();

            // update de hoeveelheid van een product in de list
            foreach (Winkelwagen products in winkelwagenList)
            {
                if (products.Equals(updatedProduct))
                {
                    products.hoeveelheid = winkelwagen.hoeveelheid;
                    return;
                }
            }
        }

        // product verwijderen.
        public void RevomeProduct(Winkelwagen product)
        {
            Product product1 = new Product();
            Winkelwagen removedProduct = new Winkelwagen(product1.id);
            var winkelwagenList = GetList();

            winkelwagenList.Remove(removedProduct);
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
