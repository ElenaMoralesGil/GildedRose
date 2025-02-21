namespace GildedRose.Console.Items;

public class SulfurasItem(Item item) : InventoryItem(item){
    public override void Update()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    public override void UpdateQuality()
    {
    }

    public override void UpdateSellIn()
    {
    }
}