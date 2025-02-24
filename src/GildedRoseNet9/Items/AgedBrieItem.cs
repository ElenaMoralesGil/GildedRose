namespace GildedRose.Console.Items;

public class AgedBrieItem(Item item) : InventoryItem(item){
   
    public override void UpdateQuality()
    {
        if (item.Quality < ItemsMaxQuality) item.Quality++;

        if (item.SellIn <= MinDaysUntilItemExpires && item.Quality < ItemsMaxQuality ) item.Quality++;
    }
}