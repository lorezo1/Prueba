using Library;
namespace LibraryTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      //Arrange

        Suma prueba = new Suma();  

        int expected = 30;  

    //Act

        int sum (int op1) {

        int x = 5; 
        int y = 10;
        int z = 15;
         op1 = (x + y + z);

        int result = prueba.(); 

    //Assert

        Assert.That(expected.Equals(result)); 
        



    }
}