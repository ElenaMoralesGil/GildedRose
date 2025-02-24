namespace GildedRose.Console.Items;

public class AgedBrieItem(Item item) : InventoryItem(item){
   
    public override void UpdateQuality()
    {
        if (ItemHasNotReachedMaxQuality()) item.Quality++;

        if (ItemHasExpired() && ItemHasNotReachedMaxQuality()) item.Quality++;
    }
}