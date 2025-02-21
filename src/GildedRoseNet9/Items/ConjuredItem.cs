namespace GildedRose.Console.Items;

public class ConjuredItem(Item item) : InventoryItem(item){
    public override void Update()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    public override void UpdateQuality(){
        if(item.Quality < 0 ) return;

        if(item.SellIn >= 0) item.Quality -= 2;
        
        if(item.SellIn < 0) item.Quality -= 4;

        if(item.Quality < 0) item.Quality = 0;
    }

    public override void UpdateSellIn()
    {
        item.SellIn--;
    }
}