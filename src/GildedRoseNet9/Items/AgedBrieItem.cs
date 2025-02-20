namespace GildedRose.Console.Items;

public class AgedBrieItem : InventoryUpdater{

    public Item Item { get;}

    public AgedBrieItem(Item item){
        this.Item = item;
    }

    public override void Update(){
    
        if (Item.Quality < 50) Item.Quality++;

        if (Item.SellIn <= 0 && Item.Quality < 50 ) Item.Quality++;
        Item.SellIn--;
    }
}