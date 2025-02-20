namespace GildedRose.Console.Items;

public class ConjuredItem : InventoryUpdater{

    public Item Item { get;}

    public ConjuredItem(Item item){
        this.Item = item;
    }

    public override void Update(){
        int maxDecreasedIteration = Item.SellIn >= 0 ? 2 : 4;
        for(int i = 0; i < maxDecreasedIteration; i++) {
            if(Item.Quality > 0) Item.Quality--;
            else break;
        }
         Item.SellIn--;
    }
}