namespace GildedRose.Console.Items;

public class NormalItem : InventoryUpdater{

    public NormalItem(Item item) : base(item){}

    public override void Update(){

        if (item.Quality > 0 ) item.Quality--;
        
        if (item.SellIn <= 0) item.Quality--;
        item.SellIn--;
    }

}