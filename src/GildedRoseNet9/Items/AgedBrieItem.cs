namespace GildedRose.Console.Items;

public class AgedBrieItem : InventoryUpdater{


    public AgedBrieItem(Item item): base(item){
    }

    public override void Update(){
    
        if (item.Quality < 50) item.Quality++;

        if (item.SellIn <= 0 && item.Quality < 50 ) item.Quality++;
        item.SellIn--;
    }
}