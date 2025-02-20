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

        public int UpdateBackStageQuality(Item item){

            if(item.SellIn <= 0) return 0;

            if(item.Quality  <50 ){
                item.Quality++;
                if (item.SellIn < 11 ) item.Quality++;

                if (item.SellIn < 6 )item.Quality++;
            }

            return item.Quality;
        }

        public int UpdateNormalQuality(Item item){
            if (item.Quality > 0 ) item.Quality--;
        
            if (item.SellIn <= 0) item.Quality--;
    
            return item.Quality;
        }

        public int UpdateAgedBrieQuality(Item item){
            if(item.Quality >=50) return item.Quality;

            if (item.Quality < 50) item.Quality++;

            if (item.SellIn <= 0) item.Quality++;

            return item.Quality;
        }
        
        // public void UpdateQuality()
        // {
        //     foreach (Item item in Items)
        //     {   
        //         if(item.Name == "Sulfuras, Hand of Ragnaros") continue;

        //         switch(item.Name) {
        //             case "Aged Brie":
        //                 item.Quality = UpdateAgedBrieQuality(item);
        //                 break;
        //             case "Backstage passes to a TAFKAL80ETC concert":
        //                 item.Quality = UpdateBackStageQuality(item);
        //                 break;
        //             default:
        //                 item.Quality = UpdateNormalQuality(item);
        //                 break;
        //         }
        //         item.SellIn = item.SellIn - 1;
        //     }
        // }

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
