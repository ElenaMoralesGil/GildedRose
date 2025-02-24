namespace GildedRose.Console.Items;

public class BackstageItem(Item item) : InventoryItem(item){

    public int EventIsInminent= 6;
    public int EventIsClose = 11;
    

    public override void UpdateQuality()
    {
        if(EventHasPassed()) {
            item.Quality = ItemsMinQuality;
            return;
        }

        if(item.Quality > ItemsMaxQuality) return;

        item.Quality++;

        if (IsEventClose() && ItemHasNotReachedMaxQuality()) item.Quality++;

        if (IsEventInminent() && ItemHasNotReachedMaxQuality()) item.Quality++;
    }

    public bool  EventHasPassed(){
        return item.SellIn <= MinDaysUntilItemExpires;
    }

    public bool IsEventClose(){
        return item.SellIn < EventIsClose;
    }

    public bool IsEventInminent(){
        return item.SellIn < EventIsInminent;
    }
}