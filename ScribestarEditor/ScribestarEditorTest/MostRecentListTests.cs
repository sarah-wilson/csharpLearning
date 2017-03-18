using System.Linq;
using NUnit.Framework;
using ScribestarEditor;

/** Add new items OF ANY TYPE to a list. Store most recently accessed item at the top. limit list size
**/
namespace ScribestarEditorTest
{
    [TestFixture]
    public class MostRecentListTests
    {
        [Test]
        public void ANewListIsEmpty()
        {
            var list = new MostRecentlyUsedList(5);
            Assert.That(list.IsEmpty, Is.True, "list should be empty");
        }

        [Test]
        public void ListNotEmptyAfterAddingItem()
        {
            var list = new MostRecentlyUsedList(5);
            list.AddOne(1);
            Assert.That(list.IsEmpty, Is.False, "list should not be empty");
        }

        [Test]
        public void ReturnListItem()
        {
            var list = new MostRecentlyUsedList(5);
            list.AddOne(1);

            Assert.That(list.Accessor.First(), Is.EqualTo(1));
        }

        [Test]
        public void ReturnAnotherListItem()
        {
            var list = new MostRecentlyUsedList(5);
            list.AddOne(2);

            Assert.That(list.Accessor.First(), Is.EqualTo(2));
        }

        [Test]
        public void ReturnTwoListItems()
        {
            var list = new MostRecentlyUsedList(5);
            list.AddOne(1);
            list.AddOne(2);

            Assert.That(list.Accessor, Is.Ordered.Descending);
        }

        [Test]
        public void LimitListSize()
        {
            var list = new MostRecentlyUsedList(2);
            list.AddOne(1);
            list.AddOne(2);
            list.AddOne(4);
            Assert.That(list.Size, Is.EqualTo(2));
            Assert.That(list.Accessor.ElementAt(0), Is.EqualTo(4));
            Assert.That(list.Accessor.ElementAt(1), Is.EqualTo(2));
        }
            

    }
}