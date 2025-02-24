namespace GildedRose.Console.Items;

public class NormalItem(Item item) : InventoryItem(item){
   

    public override void UpdateQuality(){

        if (ItemHasReachedMinQuality() is false) item.Quality--;
        
        if (ItemHasExpired()) item.Quality--;
        
    }
}