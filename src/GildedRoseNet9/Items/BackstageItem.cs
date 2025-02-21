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
            item.Quality = 0;
            return;
        }

        if(item.Quality > 50) return;

        item.Quality++;

        if (item.SellIn < 11 && item.Quality < 50) item.Quality++;

        if (item.SellIn < 6 && item.Quality < 50) item.Quality++;

        // if(item.Quality  <50  && item.SellIn > 0){
        //     item.Quality++;
        //     if (item.SellIn < 11 ) item.Quality++;

        //     if (item.SellIn < 6 )item.Quality++;
        // }
    }

    public override void UpdateSellIn() {
        item.SellIn--;
    }
}