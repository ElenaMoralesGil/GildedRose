namespace GildedRose.Console;
public abstract class  InventoryItem{

    public Item item;
    public int NotLegendaryItemsMaxQuality = 50;
    public int NotLegendaryItemsMinQuality, MinDaysForQualityChangeFaster = 0;

    public InventoryItem(Item item) {
        this.item = item;
    }

    public abstract void Update();
    public abstract void UpdateQuality();

    public abstract void UpdateSellIn();

}
