namespace GildedRose.Console.Items;

public class ConjuredItem(Item item) : InventoryItem(item){
    public override void Update()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    public override void UpdateQuality(){
        int maxDecreasedIteration = item.SellIn >= 0 ? 2 : 4;
        for(int i = 0; i < maxDecreasedIteration; i++) {
            if(item.Quality > 0) item.Quality--;
            else break;
        }
    }


    public override void UpdateSellIn()
    {
        item.SellIn--;
    }
}