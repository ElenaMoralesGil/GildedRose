namespace GildedRose.Console.Items;

public class ConjuredItem(Item item) : InventoryItem(item){
   

    public override void UpdateQuality(){
        if(ItemHasReachedMinQuality() ) return;

        if(ItemHasExpired() is false) item.Quality -= 2;

        if(ItemHasExpired()) item.Quality -= 4;

        if(ItemHasReachedMinQuality()) item.Quality = ItemsMinQuality;
    }
}