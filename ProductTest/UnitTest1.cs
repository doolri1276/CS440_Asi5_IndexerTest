using IndexerTest;
using NUnit.Framework;

namespace ProductTest
{
    public class ProductTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            OnlineStore store = new OnlineStore();

            Product[] pList = store[100, ProductPropertyType.PRODUCT_ID];
            Assert.AreEqual(1, pList.Length, "Search by Product ID is wrong");
            Assert.AreEqual("Base Ball", pList[0].ProductName, "Search by Product_ID result is wrong");

            pList = store[(int)CategoryType.SPORTS, ProductPropertyType.PRODUCT_CATEGORY];
            Assert.AreEqual(3, pList.Length, "Search by Category is wrong");
            Assert.AreEqual(pList[0].Description, "Ball with a instrument Base drawing on.", "Search by Category is wrong");

            pList = store["Parry Hotter", ProductPropertyType.PRODUCT_NAME];
            Assert.AreEqual(3, pList.Length, "Search by Product Name is wrong");
            Assert.AreEqual(209, pList[0].ProductId, "Search by Product Name is wrong");

            pList = store["a", ProductPropertyType.PRODUCT_DESCRIPTION];
            Assert.AreEqual(7, pList.Length, "Search by Product Description is wrong");


        }
    }
}