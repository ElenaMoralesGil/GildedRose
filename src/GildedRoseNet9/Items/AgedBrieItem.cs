namespace GildedRose.Console.Items;

public class AgedBrieItem(Item item) : InventoryItem(item){
    public override void Update(){
        UpdateQuality();
        UpdateSellIn();
    }

    public override void UpdateQuality()
    {
        if (item.Quality < 50) item.Quality++;

        if (item.SellIn <= 0 && item.Quality < 50 ) item.Quality++;
    }

    public override void UpdateSellIn()
    {
        item.SellIn--;
    }
}