using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public QualityUpdater qualityUpdater =  new QualityUpdater();
        public IList<Item> Items;
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");
        }


        public void UpdateQuality(){
            foreach(Item item in Items){
                if(item.Name == "Sulfuras, Hand of Ragnaros") continue;
                item.Quality = qualityUpdater.Update(item);
                item.SellIn--;
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
