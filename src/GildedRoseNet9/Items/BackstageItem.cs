namespace GildedRose.Console.Items;

public class BackstageItem : InventoryUpdater{

    public Item Item { get;}

    public BackstageItem(Item item){
        this.Item = item;
    }

    public override void Update(){
        if(Item.SellIn <= 0)Item.Quality = 0 ;

        if(Item.Quality  <50  && Item.SellIn > 0){
            Item.Quality++;
            if (Item.SellIn < 11 ) Item.Quality++;

            if (Item.SellIn < 6 )Item.Quality++;
        }
         Item.SellIn--;
    }
}