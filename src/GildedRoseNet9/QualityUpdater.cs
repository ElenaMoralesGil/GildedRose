namespace GildedRose.Console;
using GildedRose.Console.QualityUpdaters;
public class QualityUpdater{
    
    UpdateStrategy strategy;

    public int Update(Item item){
        strategy = GetStrategy(item);
        return strategy.Update(item);
    }

    public UpdateStrategy GetStrategy(Item item){

        switch(item.Name) {
            case "Aged Brie":
                return new AgedBrieQualityUpdater();     
            case "Backstage passes to a TAFKAL80ETC concert":
                return new BackstageQualityUpdater();
            default:
                return new NormalQualityUpdater();
        }

    }

}