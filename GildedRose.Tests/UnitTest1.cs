using Shouldly;
using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using GildedRose.Console;
using NUnit.Framework.Constraints;
namespace GildedRose.Tests;

[UseReporter(typeof(DiffReporter))]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    
    [Test]
    public void Test1()
    {
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
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
                                              new Item { Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 2, Quality =10},
                                              new Item{Name = "Cool elixir", SellIn = -2, Quality = 3 }
                                        
                                          }

                          };

            app.UpdateQuality();
            string CurrentStatus = "";
            foreach(var item in app.Items){
                CurrentStatus +=  $"Name {item.Name} SellIn { item.SellIn} Quality { item.Quality}\n";

            }

        Approvals.Verify(CurrentStatus);
    }
}
