namespace GildedRose.Console.Items;

public class BackstageItem(Item item) : InventoryItem(item){

    public int FirstMinDaysForTicketsQualityIncrease = 6;
    public int SecondMinDaysForTicketsQualityIncrease = 11;
    

    public override void UpdateQuality()
    {
        if(item.SellIn <= MinDaysUntilItemExpires) {
            item.Quality = ItemsMinQuality;
            return;
        }

        if(item.Quality > ItemsMaxQuality) return;

        item.Quality++;

        if (item.SellIn < FirstMinDaysForTicketsQualityIncrease && item.Quality < ItemsMaxQuality) item.Quality++;

        if (item.SellIn < SecondMinDaysForTicketsQualityIncrease && item.Quality < ItemsMaxQuality) item.Quality++;
    }
}