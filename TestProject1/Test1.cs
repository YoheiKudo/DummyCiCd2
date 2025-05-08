namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var form = new DummyCiCd2.Form1();
            int a = 5;
            int b = 10;
            int expected = 15;
            // Act
            int result = form.Add(a, b);
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
