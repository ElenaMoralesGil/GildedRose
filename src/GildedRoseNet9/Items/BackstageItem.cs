namespace GildedRose.Console.Items;

public class BackstageItem : InventoryUpdater{

    public BackstageItem(Item item): base(item){ }

    public override void Update(){
        if(item.SellIn <= 0)item.Quality = 0 ;

        if(item.Quality  <50  && item.SellIn > 0){
            item.Quality++;
            if (item.SellIn < 11 ) item.Quality++;

            if (item.SellIn < 6 )item.Quality++;
        }
         item.SellIn--;
    }
}