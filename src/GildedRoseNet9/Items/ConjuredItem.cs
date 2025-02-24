namespace GildedRose.Console.Items;

public class ConjuredItem(Item item) : InventoryItem(item){
   

    public override void UpdateQuality(){
        if(item.Quality < ItemsMinQuality ) return;

        if(item.SellIn >= MinDaysUntilItemExpires) item.Quality -= 2;

        if(item.SellIn < MinDaysUntilItemExpires) item.Quality -= 4;

        if(item.Quality < ItemsMinQuality) item.Quality = ItemsMinQuality;
    }
}