using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Container
{
    public class WinkelwagenContainer
    {
        public List<Winkelwagen> WinkelwagenList { get; set; } = new List<Winkelwagen>();

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
        public void AddProductToCart(int productID)
        {
            var winkelwagenList = GetList();
            Winkelwagen newProduct = new Winkelwagen(productID);

            //check als product al in de winkewagen zit wordt de hoeveelheid opgeteld.
            if (winkelwagenList.Contains(newProduct))
            {
                foreach (Winkelwagen product in winkelwagenList)
                {
                    if (product.Equals(newProduct))
                    {
                        product.hoeveelheid++;
                        return;
                    }
                }
            }
            else
            {
                newProduct.hoeveelheid = 1;
                winkelwagenList.Add(newProduct);
            }
        }

        //Hoeveheid bepalen
        public void SetProductQuantity(int productID, int Quantity)
        {
            // als de hoevelheid nu is verwijder de product.
            if(Quantity == 0)
            {
                RevomeProduct(productID);
                return;
            }

            Winkelwagen updatedProduct = new Winkelwagen(productID);
            var winkelwagenList = GetList();

            // update de hoeveelheid van een product un de list
            foreach (Winkelwagen product in winkelwagenList)
            {
                if (product.Equals(updatedProduct))
                {
                    product.hoeveelheid = Quantity;
                    return;
                }
            }
        }

        // product verwijderen.
        public void RevomeProduct(int productID)
        {
            Winkelwagen removedProduct = new Winkelwagen(productID);
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
