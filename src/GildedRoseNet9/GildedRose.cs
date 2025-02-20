using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");
        }

        public void UpdateQuality(){
            foreach (Item item in Items){
                var InventoryUpdater = ItemFactory.Create(item);
                InventoryUpdater.Update();
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

    }

}
