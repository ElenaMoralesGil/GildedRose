
using GildedRose.Console;

public class ConjuredQualityUpdaterStrategy :  UpdateStrategy{
    public int Update(Item item) {
        
        int maxDecreasedIteration = item.SellIn > 0 ? 2 : 4;
        for(int i = 0; i < maxDecreasedIteration; i++) {
            if(item.Quality > 0) item.Quality--;
            else break;
        }
        
        return item.Quality;
    }
}