using System.Collections.Generic;
using System.Linq;

namespace TestEnvironment.CompanyChallenges.VerkadaChallenges
{
  /// <assignment>
  /// You work at an electronics shop, and you've just received a shipment containing new models of Verkada security
  /// cameras. With these new items, you'll need to make some updates to your product database.
  /// Each product in your database has a unique SKU (id) and a product name (name), and the system accepts several
  /// different commands:
  /// The methods that should be supported are listed below:
  /// createProduct(id, name) - creates a record for a new product. Returns false if a product with the specified
  /// id already exists, and true otherwise;
  /// updateProduct(id, name) - updates the product with the provided info. Returns false if the product with such
  /// id does not exist, and true otherwise.
  /// deleteProduct(id) - deletes the provided product. Returns false if the product with this id does not exist,
  /// and true otherwise.
  /// findProductById(id) - finds a product by id. Returns the product (in the form of a JSON) if the product with
  /// this id exists, and null otherwise.
  /// findProductByTitle(title) - find a product by title. Returns the product (in the form of a JSON) if the product
  /// with this title exists, and null otherwise.
  /// For each command of the first three types, return its result - "true" or "false" and for the last two commands
  /// return the product - its result as a stringified JSON (or "null" if no product was found).
  /// </assignment>
  public static class VerkadaProductManagement
  {
    public struct Product
    {
      public int Id;
      public string Title;

      public bool IsNull()
      {
        return Equals(default(Product));
      }
    }

    public static List<Product> Products = new List<Product>();

    private static bool CreateProduct(int id, string title)
    {
      if (!Products.FirstOrDefault(p => p.Id == id).IsNull()) return false;
      
      Product newProduct;
      newProduct.Id = id;
      newProduct.Title = title;
      Products.Add(newProduct);
      return true;
    }

    private static bool UpdateProduct(int id, string title)
    {
      if (Products.FirstOrDefault(p => p.Id == id).IsNull()) return false;
      
      Product curProduct = FindProductById(id);
      Products.Remove(curProduct);
      
      curProduct.Title = title;
      Products.Add(curProduct);
      return true;
    }

    private static bool DeleteProduct(int id)
    {
      if (Products.FirstOrDefault(p => p.Id == id).IsNull()) return false;
      
      if (id < Products.Count)
      {
        Products.RemoveAt(id);
      }

      return true;
    }

    private static Product FindProductById(int id)
    {
      return Products.Find(product => product.Id == id);
    }

    private static Product FindProductByTitle(string title)
    {
      return Products.Find(product => product.Title == title);
    }
    
    public static string[] ProductManagement(string[][] operations)
    {
      // Calls corresponding methods of productManager based on the input
      string[] answer = new string[operations.Length];
      for (int i = 0; i < operations.Length; i++)
      {
        if (operations[i][0] == "createProduct")
        {
          int id = int.Parse(operations[i][1]);
          bool result = CreateProduct(id, operations[i][2]);
          if (result)
          {
            answer[i] = "true";
          }
          else
          {
            answer[i] = "false";
          }
        }

        if (operations[i][0] == "updateProduct")
        {
          int id = int.Parse(operations[i][1]);
          bool result = UpdateProduct(id, operations[i][2]);
          if (result)
          {
            answer[i] = "true";
          }
          else
          {
            answer[i] = "false";
          }
        }

        if (operations[i][0] == "deleteProduct")
        {
          int id = int.Parse(operations[i][1]);
          bool result = DeleteProduct(id);
          if (result)
          {
            answer[i] = "true";
          }
          else
          {
            answer[i] = "false";
          }
        }

        if (operations[i][0] == "findProductById")
        {
          int id = int.Parse(operations[i][1]);
          Product result = FindProductById(id);
          if (result.IsNull())
          {
            answer[i] = "null";
          }
          else
          {
            answer[i] = "{\"id\":\"" + result.Id.ToString() + "\",\"title\":\"" + result.Title + "\"}";
          }
        }

        if (operations[i][0] == "findProductByTitle")
        {
          string title = operations[i][1];
          Product result = FindProductByTitle(title);
          if (result.IsNull())
          {
            answer[i] = "null";
          }
          else
          {
            answer[i] = "{\"id\":\"" + result.Id.ToString() + "\",\"title\":\"" + result.Title + "\"}";
          }
        }
      }

      return answer;
    }
  }
}