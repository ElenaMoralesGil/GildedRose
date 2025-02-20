namespace GildedRose.Console;
using GildedRose.Console.QualityUpdaters;
public class QualityUpdater{
    
    UpdateStrategy strategy;

    public int Update(Item item){
        strategy = GetStrategy(item);
        return strategy.Update(item);
    }

        public UpdateStrategy GetStrategy(Item item) {

            return item.Name switch

            {
                var name when name.Contains("Conjured") => new ConjuredQualityUpdaterStrategy(),
                "Aged Brie" => new AgedBrieQualityUpdaterStrategy(),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstageQualityUpdaterStrategy(),
                _ => new NormalQualityUpdaterStrategy()
            };
        }
    }