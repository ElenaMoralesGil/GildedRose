namespace GildedRose.Console.QualityUpdaters; 

public class BackstageQualityUpdaterStrategy : UpdateStrategy{

    public int Update(Item item){
        if(item.SellIn <= 0) return 0;

        if(item.Quality  <50 ){
            item.Quality++;
            if (item.SellIn < 11 ) item.Quality++;

            if (item.SellIn < 6 )item.Quality++;
        }

        return item.Quality;
    }

}