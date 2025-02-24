namespace GildedRose.Console;
public abstract class  InventoryItem{

    public Item item;
    public int NotLegendaryItemsMaxQuality = 50;
    public int NotLegendaryItemsMinQuality, MinDaysForQualityChangeFaster = 0;

    public InventoryItem(Item item) {
        this.item = item;
    }

    public void Update()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    public abstract void UpdateQuality();

    public virtual void UpdateSellIn()
    {
        item.SellIn--;
    }

}
