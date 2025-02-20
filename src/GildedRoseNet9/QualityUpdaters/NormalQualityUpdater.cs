namespace GildedRose.Console.QualityUpdaters; 

public class NormalQualityUpdater : UpdateStrategy{

    public int Update(Item item){
        if (item.Quality > 0 ) item.Quality--;
        
            if (item.SellIn <= 0) item.Quality--;
    
            return item.Quality;
    }
}