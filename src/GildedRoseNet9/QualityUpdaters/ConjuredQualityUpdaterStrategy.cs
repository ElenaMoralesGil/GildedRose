
using GildedRose.Console;

public class ConjuredQualityUpdaterStrategy :  UpdateStrategy{
    public int Update(Item item){
	        return item.Quality  = item.Quality - 2;
    }
}