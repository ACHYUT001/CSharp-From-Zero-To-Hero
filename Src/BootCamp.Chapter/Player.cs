using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Task: simulate a player who has an inventory.
    /// Player can add or remove items from inventory.
    ///
    /// Extra task: player has equipement and maximum weight he/she can carry.
    /// Player should not be able to take items if already at maximum weight.
    /// Player should expose TotalAttack, TotalDefense stats.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int _baseCarryWeight = 30;

        private string _name;
        private int _hp;

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int _strength;

        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;
        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;

        private int  _maxweight;
        
        public Player()
        {
            _maxweight = _maxweight = _baseCarryWeight + (_strength*10); 
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        public Item[] GetItems()
        {
            return new Item[0];
        }

        /// <summary>
        /// Adds item to player's inventory
        /// </summary>
        public void AddItem(Item item)
        {
            _inventory.AddItem(item);
        }

        public void Remove(Item item)
        {
            Item[] itemslist = _inventory.GetItems(item.GetName());
            
            if(itemslist.Length > 0)
            {
                
                _inventory.RemoveItem(itemslist[0]);
            }
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public Item[] GetItems(string name)
        {
            return _inventory.GetItems(name);
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        public void Equip(Headpiece head)
        {
            if(_equipment.GetTotalWeight() + head.GetWeight() > _maxweight)
            {
                System.Console.WriteLine("cannot equip");

            }

            else
            {
                _equipment.SetHead(head);
            }
        }

        public void Equip(Chestpiece head)
        {

        }

        public void Equip(Shoulderpiece head, bool isLeft)
        {

        }

        public void Equip(Legspiece head)
        {

        }

        public void Equip(Armpiece head, bool isLeft)
        {

        }

        public void Equip(Gloves head)
        {

        }
        #endregion
    }
}
