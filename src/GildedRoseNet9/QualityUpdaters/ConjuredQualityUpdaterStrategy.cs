
using GildedRose.Console;

public class ConjuredQualityUpdaterStrategy :  UpdateStrategy{
    public int Update(Item item){
        if(item.Quality > 0){
	        item.Quality  = item.Quality - 2;
        }
        return item.Quality;
    }
}