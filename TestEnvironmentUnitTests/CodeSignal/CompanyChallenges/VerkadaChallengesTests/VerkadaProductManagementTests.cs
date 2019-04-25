using NUnit.Framework;
using TestEnvironment.CodeSignal.CompanyChallenges.VerkadaChallenges;

namespace TestEnvironmentUnitTests.CodeSignal.CompanyChallenges.VerkadaChallengesTests
{
  [TestFixture]
  [Timeout(3000)]
  public class VerkadaProductManagementTests
  {
    [SetUp]
    public void Clear()
    {
      VerkadaProductManagement.Products.Clear();
    }
    
    [Test]
    public void VerkadaProductManagementTest01()
    {
      // Arrange
      string[][] input = new string[8][];
      input[0] = new[] {"createProduct", "10", "Product_10"};
      input[1] = new[] {"createProduct", "10", "Product_10"};
      input[2] = new[] {"updateProduct", "10", "New_Product_10"};
      input[3] = new[] {"deleteProduct", "9"};
      input[4] = new[] {"findProductById", "9"};
      input[5] = new[] {"findProductById", "10"};
      input[6] = new[] {"findProductByTitle", "Product_10"};
      input[7] = new[] {"findProductByTitle", "New_Product_10"};

      string[] expectedOutput =
      {
        "true",
        "false",
        "true",
        "false",
        "null",
        "{\"id\":\"10\",\"title\":\"New_Product_10\"}",
        "null",
        "{\"id\":\"10\",\"title\":\"New_Product_10\"}"
      };

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert

      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest02()
    {
      // Arrange
      string[][] input = new string[1][];
      input[0] = new[] {"createProduct", "10", "Product 10"};

      string[] expectedOutput = {"true"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest03()
    {
      // Arrange
      string[][] input = new string[1][];
      input[0] = new[] {"updateProduct", "462", "Product 462"};

      string[] expectedOutput = {"false"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest04()
    {
      // Arrange
      string[][] input = new string[2][];
      input[0] = new[] {"createProduct", "733", "Product 733"};
      input[1] = new[] {"findProductById", "236"};


      string[] expectedOutput = {"true", "null"};
      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest05()
    {
      // Arrange
      string[][] input = new string[2][];
      input[0] = new[] {"createProduct", "733", "Product 733"};
      input[1] = new[] {"findProductById", "733"};

      string[] expectedOutput =
      {
        "true",
        "{\"id\":\"733\",\"title\":\"Product 733\"}"
      };

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest06()
    {
      // Arrange
      string[][] input = new string[3][];
      input[0] = new[] {"createProduct", "269", "Product 269"};
      input[1] = new[] {"updateProduct", "454", "Product 454"};
      input[2] = new[] {"findProductByTitle", "Product 269"};

      string[] expectedOutput =
      {
        "true",
        "false",
        "{\"id\":\"269\",\"title\":\"Product 269\"}"
      };
      
      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest07()
    {
      // Arrange
      string[][] input = new string[2][];
      input[0] = new[] {"createProduct", "269", "Product 269"};
      input[1] = new[] {"updateProduct", "454", "Product 454"};

      string[] expectedOutput = {"true", "false"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest08()
    {
      // Arrange
      string[][] input = new string[3][];
      input[0] = new[] {"createProduct", "109", "Product 109"};
      input[1] = new[] {"createProduct", "858", "Product 858"};
      input[2] = new[] {"createProduct", "115", "Product 115"};

      string[] expectedOutput = {"true", "true", "true"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest09()
    {
      // Arrange
      string[][] input = new string[1][];
      input[0] = new[] {"deleteProduct", "646"};

      string[] expectedOutput = {"false"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest10()
    {
      // Arrange
      string[][] input = new string[2][];
      input[0] = new[] {"deleteProduct", "129"};
      input[1] = new[] {"createProduct", "129", "Product 129"};

      string[] expectedOutput = {"false", "true"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest11()
    {
      // Arrange
      string[][] input = new string[2][];
      input[0] = new[] {"deleteProduct", "105"};
      input[1] = new[] {"updateProduct", "640", "Product 640"};

      string[] expectedOutput = {"false", "false"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest12()
    {
      // Arrange
      string[][] input = new string[3][];
      input[0] = new[] {"updateProduct", "562", "Product 562"};
      input[1] = new[] {"createProduct", "562", "Product 562"};
      input[2] = new[] {"createProduct", "742", "Product 742"};

      string[] expectedOutput = {"false", "true", "true"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }

    [Test]
    public void VerkadaProductManagementTest13()
    {
      // Arrange
      string[][] input = new string[4][];
      input[0] = new[] {"createProduct", "717", "Product 717"};
      input[1] = new[] {"createProduct", "494", "Product 494"};
      input[2] = new[] {"deleteProduct", "494"};
      input[3] = new[] {"updateProduct", "717", "Product 717"};

      string[] expectedOutput = {"true", "true", "true", "true"};

      // Act
      string[] productManagement = VerkadaProductManagement.ProductManagement(input);

      // Assert
      Assert.AreEqual(expectedOutput, productManagement);
    }
  }
}