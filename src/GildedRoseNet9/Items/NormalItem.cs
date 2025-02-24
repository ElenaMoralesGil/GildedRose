namespace GildedRose.Console.Items;

public class NormalItem(Item item) : InventoryItem(item){
   

    public override void UpdateQuality(){

        if (item.Quality > NotLegendaryItemsMinQuality ) item.Quality--;
        
        if (item.SellIn <= MinDaysForQualityChangeFaster) item.Quality--;
        
    }

    public override void UpdateSellIn()
    {
        item.SellIn--;
    }
}