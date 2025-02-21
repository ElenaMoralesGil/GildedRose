namespace GildedRose.Console.Items;

public class AgedBrieItem(Item item) : InventoryItem(item){
    public override void Update(){
        UpdateQuality();
        UpdateSellIn();
    }

    public override void UpdateQuality()
    {
        if (item.Quality < NotLegendaryItemsMaxQuality) item.Quality++;

        if (item.SellIn <= 0 && item.Quality < NotLegendaryItemsMaxQuality ) item.Quality++;
    }

    public override void UpdateSellIn()
    {
        item.SellIn--;
    }
}