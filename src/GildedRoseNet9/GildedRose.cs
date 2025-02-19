﻿using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
                          {
                              Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

                          };

            app.UpdateQuality();

            System.Console.ReadKey();

        }

        public int UpdateBackStageQuality(Item item){
            if (item.SellIn < 11 )
            {
                item.Quality = item.Quality + 1;                      
            }

            if (item.SellIn < 6 )
            {
                item.Quality = item.Quality + 1;
            }
            
            return item.Quality;
        }

        public int UpdateNormalQuality(Item item){
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
            return item.Quality;
        }

        public int UpdateAgedBrieQuality(Item item){
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
            return item.Quality;
        }
        
        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {   
                if(item.Name == "Sulfuras, Hand of Ragnaros") continue;
                
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    item.Quality = UpdateNormalQuality(item);
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            item.Quality = UpdateBackStageQuality(item);
                        }
                    }
                }

                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            item.Quality = UpdateNormalQuality(item);
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        item.Quality = UpdateAgedBrieQuality(item);
                    }
                }
            }
        }

        //   public void UpdateQuality()
        // {
        //     foreach(Item item in Items)
        //     {
        //         if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
        //         {
        //             if (item.Quality > 0)
        //             {
        //                 if (item.Name != "Sulfuras, Hand of Ragnaros")
        //                 {
        //                     item.Quality = item.Quality - 1;
        //                 }
        //             }
        //         }
        //         else
        //         {
        //             if (item.Quality < 50)
        //             {
        //                 item.Quality = item.Quality + 1;

        //                 if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
        //                 {
        //                     if (item.SellIn < 11)
        //                     {
        //                         if (item.Quality < 50)
        //                         {
        //                             item.Quality = item.Quality + 1;
        //                         }
        //                     }

        //                     if (item.SellIn < 6)
        //                     {
        //                         if (item.Quality < 50)
        //                         {
        //                             item.Quality = item.Quality + 1;
        //                         }
        //                     }
        //                 }
        //             }
        //         }

        //         if (item.Name != "Sulfuras, Hand of Ragnaros")
        //         {
        //             item.SellIn = item.SellIn - 1;
        //         }

        //         if (item.SellIn < 0)
        //         {
        //             if (item.Name != "Aged Brie")
        //             {
        //                 if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
        //                 {
        //                     if (item.Quality > 0)
        //                     {
        //                         if (item.Name != "Sulfuras, Hand of Ragnaros")
        //                         {
        //                             item.Quality = item.Quality - 1;
        //                         }
        //                     }
        //                 }
        //                 else
        //                 {
        //                     item.Quality = item.Quality - item.Quality;
        //                 }
        //             }
        //             else
        //             {
        //                 if (item.Quality < 50)
        //                 {
        //                     item.Quality = item.Quality + 1;
        //                 }
        //             }
        //         }
        //     }
        // }

    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

}
