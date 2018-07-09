using NUnit.Framework;
using System;

namespace Shaurma.Tests
{
    [TestFixture]
    public class ShaurmaTest
    {
        [Test]
        public void constructor_empty_void()
        {
            Shaurma shaurma = new Shaurma();
            Assert.That(shaurma.price(1), Is.EqualTo("10$"));
        }
        [Test]
        public void constructor_cost10_void()
        {
            Shaurma shaurma = new Shaurma(10);
            Assert.That(shaurma.price(1), Is.EqualTo("10$"));
        }
        [Test]
        public void constructor_cost999_void()
        {
            Shaurma shaurma = new Shaurma(999);
            Assert.That(shaurma.price(1), Is.EqualTo("999$"));
        }
        [Test]
        public void constructor_costNegative_exception()
        {
            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("You are crazy, cost cannot be less than 0!"),
               delegate
               {
                   new Shaurma(-1);
               });
        }
        [Test]
        public void constructor_cost0_exception()
        {
            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("I'm quitting!"),
               delegate
               {
                   new Shaurma(0);
               });
        }
        [Test]
        public void constructor_cost9_exception()
        {
            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("I'm quitting!"),
               delegate
               {
                   new Shaurma(9);
               });
        }
        [Test]
        public void constructor_cost1000_exception()
        {
            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("I'm quitting!"),
               delegate
               {
                   new Shaurma(1000);
               });
        }
        [Test]
        public void call_string()
        {
            Assert.That(new Shaurma().call(), Is.EqualTo("Sweet shaurma, come up!!!"));
        }
        [Test]
        public void setPrice_cost10_void()
        {
            Shaurma shaurma = new Shaurma();
            shaurma.setPrice(10);
            Assert.That(shaurma.price(1), Is.EqualTo("10$"));
        }
        [Test]
        public void setPrice_cost999_void()
        {
            Shaurma shaurma = new Shaurma();
            shaurma.setPrice(999);
            Assert.That(shaurma.price(1), Is.EqualTo("999$"));
        }
        [Test]
        public void setPrice_costNegative_exception()
        {
            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("You are crazy, cost cannot be less than 0!"),
               delegate
               {
                   new Shaurma().setPrice(-1);
               });
        }
        [Test]
        public void setPrice_cost0_exception()
        {
            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("I'm quitting!"),
               delegate
               {
                   new Shaurma().setPrice(0);
               });
        }
        [Test]
        public void setPrice_cost9_exception()
        {
            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("I'm quitting!"),
               delegate
               {
                   new Shaurma().setPrice(9);
               });
        }
        [Test]
        public void setPrice_cost1000_exception()
        {
            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("I'm quitting!"),
               delegate
               {
                   new Shaurma().setPrice(1000);
               });
        }
        [Test]
        public void price_number1costdefault_10()
        {
            Assert.That(new Shaurma().price(1), Is.EqualTo("10$"));
        }
        [Test]
        public void price_number4cost99_396()
        {
            Assert.That(new Shaurma(99).price(4), Is.EqualTo("396$"));
        }
        [Test]
        public void price_numberNegativecostdefault_message()
        {
            Assert.That(new Shaurma().price(-1), Is.EqualTo("Are you kidding me?"));
        }
        [Test]
        public void price_number0costdefault_message()
        {
            Assert.That(new Shaurma().price(0), Is.EqualTo("Are you kidding me?"));
        }
    }
}