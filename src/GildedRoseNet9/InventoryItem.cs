namespace GildedRose.Console;
public abstract class  InventoryItem{

    public Item item;
    public InventoryItem(Item item) {
        this.item = item;
    }

    public abstract void Update();
    public abstract void UpdateQuality();

    public abstract void UpdateSellIn();

}
