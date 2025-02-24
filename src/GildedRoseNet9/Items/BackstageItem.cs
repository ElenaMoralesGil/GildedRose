namespace GildedRose.Console.Items;

public class BackstageItem(Item item) : InventoryItem(item){

    public int FirstMinDaysForTicketsQualityIncrease = 6;
    public int SecondMinDaysForTicketsQualityIncrease = 11;
    

    public override void UpdateQuality()
    {
        if(item.SellIn <= MinDaysForQualityChangeFaster) {
            item.Quality = NotLegendaryItemsMinQuality;
            return;
        }

        if(item.Quality > NotLegendaryItemsMaxQuality) return;

        item.Quality++;

        if (item.SellIn < FirstMinDaysForTicketsQualityIncrease && item.Quality < NotLegendaryItemsMaxQuality) item.Quality++;

        if (item.SellIn < SecondMinDaysForTicketsQualityIncrease && item.Quality < NotLegendaryItemsMaxQuality) item.Quality++;
    }
}