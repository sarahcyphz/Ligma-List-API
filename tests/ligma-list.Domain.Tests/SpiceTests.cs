namespace ligma_list.Domain.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Can_Add_New_Item()
    {
        var item = new Item("name");

        Assert.AreEqual("name", item.Name);
    }
}