namespace GildedRose.Console;
public abstract class  InventoryItem{

    public Item item;
    public int ItemsMaxQuality = 50;
    public int ItemsMinQuality, MinDaysUntilItemExpires = 0;

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
