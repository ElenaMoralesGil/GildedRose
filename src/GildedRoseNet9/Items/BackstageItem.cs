namespace GildedRose.Console.Items;

public class BackstageItem(Item item) : InventoryItem(item){
    public override void Update()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    public override void UpdateQuality()
    {
        if(item.SellIn <= 0) {
            item.Quality = NotLegendaryItemsMinQuality;
            return;
        }

        if(item.Quality > NotLegendaryItemsMaxQuality) return;

        item.Quality++;

        if (item.SellIn < 11 && item.Quality < NotLegendaryItemsMaxQuality) item.Quality++;

        if (item.SellIn < 6 && item.Quality < NotLegendaryItemsMaxQuality) item.Quality++;
    }

    public override void UpdateSellIn() {
        item.SellIn--;
    }
}