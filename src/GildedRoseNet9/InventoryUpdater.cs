namespace GildedRose.Console;
public abstract class  InventoryUpdater{

    public Item item;
    public InventoryUpdater(Item item) {
        this.item = item;
    }
    public abstract void Update();
}
