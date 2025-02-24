namespace GildedRose.Console.Items;

public class NormalItem(Item item) : InventoryItem(item){
   

    public override void UpdateQuality(){

        if (item.Quality > ItemsMinQuality ) item.Quality--;
        
        if (item.SellIn <= MinDaysUntilItemExpires) item.Quality--;
        
    }
}