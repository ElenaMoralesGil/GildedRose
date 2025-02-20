namespace GildedRose.Console.Items;

public class NormalItem : InventoryUpdater{

     public Item Item { get;}

    public NormalItem(Item item){
        this.Item = item;
    }

    public override void Update(){

        if (Item.Quality > 0 ) Item.Quality--;
        
        if (Item.SellIn <= 0) Item.Quality--;
        Item.SellIn--;
    }

}