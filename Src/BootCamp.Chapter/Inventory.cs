namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;
        public Item[] GetItems()
        {
            return _items;
        }

        public Inventory()
        {
            _items = new Item[0];
        }

        public Item[] GetItems(string name)
        {
            Item[] itemslist = new Item[0];
            int index = 0;
            foreach (Item item in _items)
            {
                if(name == item.GetName())
                {
                    itemslist[index++] = item;
                }
            }
            return itemslist;
        }

        public void AddItem(Item item)
        {
            _items[_items.Length] = item;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            for (int i=0 ; i<_items.Length; i++)
            {
                if(_items[i].GetName() == item.GetName())
                {
                        while(i<_items.Length-1)
                        {
                            _items[i] = _items[i=1];
                        }
                }
            }
        }
    }
}
