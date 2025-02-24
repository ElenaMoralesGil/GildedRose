namespace GildedRose.Console.Items;

public class ConjuredItem(Item item) : InventoryItem(item){
   

    public override void UpdateQuality(){
        if(item.Quality < NotLegendaryItemsMinQuality ) return;

        if(item.SellIn >= MinDaysForQualityChangeFaster) item.Quality -= 2;

        if(item.SellIn < MinDaysForQualityChangeFaster) item.Quality -= 4;

        if(item.Quality < NotLegendaryItemsMinQuality) item.Quality = NotLegendaryItemsMinQuality;
    }

    public override void UpdateSellIn()
    {
        item.SellIn--;
    }
}