
using GildedRose.Console.Items;
namespace GildedRose.Console;
public static class ItemFactory{
    public static InventoryUpdater Create(Item item){
        return item.Name switch

            {
                var name when name.Contains("Conjured") => new ConjuredItem(item),
                "Aged Brie" => new AgedBrieItem(item),
                "Sulfuras, Hand of Ragnaros" => new SulfurasItem(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstageItem(item),
                _ => new NormalItem(item)
            };
    }
}