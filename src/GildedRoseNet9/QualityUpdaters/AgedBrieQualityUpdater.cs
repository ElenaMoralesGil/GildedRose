
namespace GildedRose.Console.QualityUpdaters; 

public class AgedBrieQualityUpdater : UpdateStrategy{


    public int Update(Item item){
        if(item.Quality >=50) return item.Quality;

        if (item.Quality < 50) item.Quality++;

        if (item.SellIn <= 0) item.Quality++;

        return item.Quality;
    }
}