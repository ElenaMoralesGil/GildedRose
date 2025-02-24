using Shouldly;
using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using GildedRose.Console;
using NUnit.Framework.Constraints;
namespace GildedRose.Tests;

[UseReporter(typeof(DiffReporter))]
public class GildedRoseShould
{
    [SetUp]
    public void Setup()
    {
    }

    
    [Test]
    public void GoldenMaster()
    {
         var app = new Program() {
            Items = new List<Item> {
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item{Name = "Aged Brie", SellIn = -2, Quality = 3 },
                new Item{Name = "Aged Brie", SellIn = -1, Quality = 51},
                new Item{Name = "Aged Brie", SellIn = 3, Quality = 51},
                new Item{Name = "Aged Brie", SellIn = 4, Quality = -1},

                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 50},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -10, Quality = 50},
                
                new Item{Name = "Cool elixir", SellIn = -2, Quality = 3 },
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = -1},  
                new Item {Name = "Elixir of the Mongoose", SellIn = -2, Quality = 5}, 
                new Item {Name = "Elixir of the Mongoose", SellIn = 0, Quality = 5},
                new Item {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 60},
                new Item {Name = "Elixir of the Mongoose", SellIn = -1, Quality = 60},
                new Item{Name= "Elixir of the Mongoose", SellIn = 4, Quality = 0},

                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 2, Quality = 10 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -2, Quality = 3 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -2, Quality = 60 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -2, Quality = -1 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 49 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 60 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 30 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 30 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 30 },
            }

        };

        app.UpdateQuality();
        string CurrentStatus = "";
        foreach(var item in app.Items){
            CurrentStatus +=  $"Name {item.Name} SellIn { item.SellIn} Quality { item.Quality}\n";

        }

        Approvals.Verify(CurrentStatus);
    }


    [Test]
    public void return_conjured_item_with_zero_quality_when_quality_is_two(){
    
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =2, Quality = 2};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =1, Quality = 0};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();

        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }

    [Test]
    public void return_conjured_item_with_zero_quality_when_quality_is_zero(){
        
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =2, Quality = 0};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =1, Quality = 0};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();
        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }

    [Test]
    public void return_conjured_item_with_zero_quality_when_quality_is_one(){
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =2, Quality = 1};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =1, Quality = 0};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();
        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }

    [Test]
    public void return_conjured_item_with_zero_quality_when_quality_is_one_but_sellIn_is_negative(){
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-2, Quality = 1};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-3, Quality = 0};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();
        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }


    [Test]
    public void return_conjured_item_with_zero_quality_when_quality_is_four_but_sellIn_is_negative(){
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-2, Quality = 4};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-3, Quality = 0};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();
        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }

    [Test]
    public void return_conjured_item_with_zero_quality_when_quality_is_three_but_sellIn_is_negative(){
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-2, Quality = 3};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-3, Quality = 0};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();
        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }

    [Test]
    public void return_conjured_item_quality_when_quality_is_negative(){
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-2, Quality = -3};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-3, Quality = -3};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();
        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }

    [Test]
    public void return_conjured_item_quality_decreased_normally_when_sellIn_is_zero(){
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =0, Quality = 10};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =-1, Quality = 6};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();
        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }

    [Test]
    public void return_conjured_item_quality_decreased_normally_when_sellIn_is_positive(){
        Item conjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =3, Quality = 16};
        Item expectedConjuredItem =  new Item{Name = "Conjured Mana Cake", SellIn =2, Quality = 14};
        var app = new Program(){
             Items = new List<Item> { conjuredItem}
        };

        app.UpdateQuality();
        app.Items[0].Quality.ShouldBe(expectedConjuredItem.Quality);
        app.Items[0].SellIn.ShouldBe(expectedConjuredItem.SellIn);
    }
}
