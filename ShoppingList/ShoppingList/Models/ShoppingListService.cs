using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    /// <summary>
    /// This class handles manipulation of a shopping cart (Getting items, Adding items, etc.)
    /// </summary>
    public class ShoppingListService
    {
        #region Class Instance Variables

        private IList<Customer> _customerShoppingList;

        #endregion

        #region Constructors

        public ShoppingListService()
        {
            _customerShoppingList = new List<Customer>();
            CreateShoppingList();
        }
        #endregion

        #region Class Instance Methods
        public IList<Customer> GetItems()
        {
            return _customerShoppingList;
        }

        private void CreateShoppingList()
        {
            _customerShoppingList.Add(new Customer
            {
                FirstName = "Nick",
                LastName = "Brittain",
                Products = new List<Product>
                {
                    new Product { Name = "Peanut Butter", Price = 3.99m },
                    new Product { Name = "Marker", Price = 1.99m },
                    new Product { Name = "Lunch", Price = 10.95m }
                }
            });

            _customerShoppingList.Add(new Customer
            {
                FirstName = "Joe",
                LastName = "Bob",
                Products = new List<Product>
                {
                    new Product { Name = "Jelly", Price = 33.21m },
                    new Product { Name = "Speakers", Price = 323.99m },
                    new Product { Name = "Stuff", Price = 13.55m }
                }
            });
        }

        #endregion
    }
}