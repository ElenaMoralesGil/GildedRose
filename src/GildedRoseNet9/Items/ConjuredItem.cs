namespace GildedRose.Console.Items;

public class ConjuredItem : InventoryUpdater{

    public ConjuredItem(Item item): base(item){}

    public override void Update(){
        int maxDecreasedIteration = item.SellIn >= 0 ? 2 : 4;
        for(int i = 0; i < maxDecreasedIteration; i++) {
            if(item.Quality > 0) item.Quality--;
            else break;
        }
         item.SellIn--;
    }
}