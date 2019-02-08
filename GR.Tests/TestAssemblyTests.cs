using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class TestAssemblyTests
    {
        private readonly Program _app;

        public TestAssemblyTests()
        {
            _app = new Program
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 1},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item
                    {
                        Name = "Backstage passes to a D498FJ9FJ2N concert",
                        SellIn = 10,
                        Quality = 30
                    },
                    new Item
                    {
                        Name = "Backstage passes to a FH38F39DJ39 concert",
                        SellIn = 5,
                        Quality = 33
                    },
                    new Item
                    {
                        Name = "Backstage passes to a I293JD92J44 concert",
                        SellIn = 6,
                        Quality = 27
                    },
                    new Item
                    {
                        Name = "Backstage passes to a O2848394820 concert",
                        SellIn = 1,
                        Quality = 13
                    },
                    new Item
                    {
                        Name = "Backstage passes to a DEEEADMEEET concert",
                        SellIn = 0,
                        Quality = 25
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };

            _app.UpdateInventory();
        }

        // Dexterity Vest tests
        [Fact]
        public void DexterityVest_SellIn_ShouldDecreaseByOne()
        {
            Assert.Equal(9, _app.Items.First(x => x.Name == "+5 Dexterity Vest").SellIn);
        }

        [Fact]
        public void DexterityVest_Quality_ShouldDecreaseByOne()
        {
            Assert.Equal(19, _app.Items.First(x => x.Name == "+5 Dexterity Vest").Quality);
        }

        // Elixir Of the Mongoose tests
        [Fact]
        public void ElixirOfMongoose_SellIn_ShouldDecreaseByOne()
        {
            Assert.Equal(4, _app.Items.First(x => x.Name == "Elixir of the Mongoose").SellIn);
        }

        [Fact]
        public void ElixirOfMongoose_Quality_ShouldDecreaseByOne()
        {
            Assert.Equal(6, _app.Items.First(x => x.Name == "Elixir of the Mongoose").Quality);
        }

        // Sulfuras tests
        [Fact]
        public void Sulfuras_Quality_ShouldRemainSame()
        {
            Assert.Equal(80, _app.Items.First(x => x.Name == "Sulfuras, Hand of Ragnaros").Quality);
        }

        [Fact]
        public void Sulfuras_SellIn_ShouldRemainSame()
        {
            Assert.Equal(0, _app.Items.First(x => x.Name == "Sulfuras, Hand of Ragnaros").SellIn);
        }

        // Aged Brie tests
        [Fact]
        public void AgedBrie_Quality_ShouldIncrease()
        {
            Assert.Equal(2, _app.Items.First(x => x.Name == "Aged Brie").Quality);
        }

        [Fact]
        public void AgedBrie_SellIn_ShouldDecrease()
        {
            Assert.Equal(1, _app.Items.First(x => x.Name == "Aged Brie").SellIn);
        }


        // Backstage Passes Test Suite
        // testing SellIn for one, but testing quality for each backstage pass

        [Fact]
        public void BackstageTAFKAL80ETC_SellIn_ShouldDecreaseByOne()
        {
            Assert.Equal(14, _app.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").SellIn);
        }

        [Fact]
        public void BackstageTAFKAL80ETC_Quality_ShouldIncreaseByOne()
        {
            Assert.Equal(21, _app.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void BackstageD498FJ9FJ2N_Quality_ShouldIncreaseByTwo()
        {
            Assert.Equal(32, _app.Items.First(x => x.Name == "Backstage passes to a D498FJ9FJ2N concert").Quality);
        }

        [Fact]
        public void BackstageFH38F39DJ39_Quality_ShouldIncreaseByThree()
        {
            Assert.Equal(36, _app.Items.First(x => x.Name == "Backstage passes to a FH38F39DJ39 concert").Quality);
        }

        [Fact]
        public void BackstageI293JD92J44_Quality_ShouldIncreaseByTwo()
        {
            Assert.Equal(29, _app.Items.First(x => x.Name == "Backstage passes to a I293JD92J44 concert").Quality);
        }

        [Fact]
        public void BackstageO2848394820_Quality_ShouldIncreaseByThree()
        {
            Assert.Equal(16, _app.Items.First(x => x.Name == "Backstage passes to a O2848394820 concert").Quality);
        }

        [Fact]
        public void BackstageDEEEADMEEET_Quality_ShouldGoToZero()
        {
            Assert.Equal(0, _app.Items.First(x => x.Name == "Backstage passes to a DEEEADMEEET concert").Quality);
        }


        // Conjured Test Suite - New Feature

        // Conjured Mana Cake
        [Fact]
        public void ConjuredManaCake_SellIn_ShouldDecreaseByOne()
        {
            Assert.Equal(2, _app.Items.First(x => x.Name == "Conjured Mana Cake").SellIn);
        }

        [Fact]
        public void ConjuredManaCake_Quality_ShouldDecreaseByTwo()
        {
            Assert.Equal(4, _app.Items.First(x => x.Name == "Conjured Mana Cake").Quality);
        }
    }
}