namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;
        public decimal GetMoney()
        {
            return _money;
        }

        private Inventory _inventory;

        public Shop()
        {

        }

        public Shop(decimal money)
        {
            _money = money;
        }

        public Item[] GetItems(string name)
        {
            return _inventory.GetItems();
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            if(GetItems(item.GetName()).Length == 0)
            {
                _inventory.AddItem(item);
            }



        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            Item[] itemslist = _inventory.GetItems(name);
            
            if(itemslist.Length > 0)
            {
                
                _inventory.RemoveItem(itemslist[0]);
            }
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            _inventory.AddItem(item);
            _money -= item.GetPrice();
        }

        /// <summary>
        /// Sell item from a shop.
        /// Shop increases it's money.
        /// No money is increased if item does not exist.
        /// </summary>
        /// <returns>
        /// Item sold.
        /// Null, if no item is sold.
        /// </returns>
        public Item Sell(string item)
        {
            Item[] itemslist = _inventory.GetItems(item);
            
            if(itemslist.Length > 0)
            {
                
                _money += itemslist[0].GetPrice();
            }

            return itemslist[0];
        }
    }
}