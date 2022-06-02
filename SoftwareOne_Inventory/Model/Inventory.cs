using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SoftwareOne_Inventory.Model
{
    public class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> AllProducts = new BindingList<Product>();


        #region// Test Data Setup
        public static void InventoryManagementSystemData()
        {
            Part temporaryPart1 = new InHouse(1, "Part 1", 12, 21.00M, 10, 6, 1001);
            Part temporaryPart2 = new InHouse(2, "Part 2", 4, 50.00M, 14, 2, 1002);
            Part temporaryPart3 = new Outsourced(3, "Part 3", 9, 100.00M, 14, 4, "Local");
            Part temporaryPart4 = new Outsourced(4, "Part 4", 12, 39.00M, 29, 23, "Jeek");

            AllParts.Add(temporaryPart1);
            AllParts.Add(temporaryPart2);
            AllParts.Add(temporaryPart3);
            AllParts.Add(temporaryPart4);

            Product temporaryProduct1 = new Product(1, "Product 1", 5, 10.00M, 17, 2);
            Product temporaryProduct2 = new Product(2, "Product 2", 34, 19.00M, 39, 21);
            Product temporaryProduct3 = new Product(3, "Product 3", 20, 23.00M, 25, 15);
            Product temporaryProduct4 = new Product(4, "Product 4", 18, 13.00M, 21, 8);

            AllProducts.Add(temporaryProduct1);
            AllProducts.Add(temporaryProduct2);
            AllProducts.Add(temporaryProduct3);
            AllProducts.Add(temporaryProduct4);

            temporaryProduct1.AssociatedParts.Add(temporaryPart1);
            temporaryProduct2.AssociatedParts.Add(temporaryPart2);
            temporaryProduct3.AssociatedParts.Add(temporaryPart3);
            temporaryProduct4.AssociatedParts.Add(temporaryPart4);
        }
        #endregion


        #region // Helper Methods
        public static void AddProduct(Product product)
        {
            AllProducts.Add(product);
        }

        public static bool RemoveProduct(int productId)
        {
            bool isRemoved = false;

            foreach (Product product in AllProducts)
            {
                if (productId == product.ProductID)
                {
                    AllProducts.Remove(product);
                    return isRemoved = true;
                }
                else
                {
                    MessageBox.Show("Error! Failed to remove product");
                    return false;
                }
            }

            return isRemoved;
        }

        public static Product LookupProduct(int productId)
        {
            foreach (Product product in AllProducts)
            {
                if (product.ProductID == productId)
                {
                    return product;
                }
            }

            Product voidProduct = new Product();
            return voidProduct;
        }

        public static void UpdateProduct(int productId, Product modifiedProduct)
        {
            foreach (Product selectedProduct in AllProducts)
            {
                if (selectedProduct.ProductID.Equals(productId))
                {
                    selectedProduct.Name = modifiedProduct.Name;
                    selectedProduct.InStock = modifiedProduct.InStock;
                    selectedProduct.Price = modifiedProduct.Price;
                    selectedProduct.Max = modifiedProduct.Max;
                    selectedProduct.Min = modifiedProduct.Min;
                    selectedProduct.AssociatedParts = modifiedProduct.AssociatedParts;
                    return;
                }
            }
        }

        public static void AddPart(int index, Part part)
        {
            AllParts.Insert(index - 1, part);
        }

        public static bool DeletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public static Part LookupPart(int partId)
        {
            foreach (Part part in AllParts)
            {
                if (part.ID == partId)
                {
                    return part;
                }
            }
            Part voidPart = new Outsourced();
            return voidPart;
        }

        public static void UpdatePart(int selectedPartId, Part updatedpart)
        {
            foreach (Part part in AllParts)
            {
                Part modifiedPart = (Part)part;

                if (modifiedPart.ID == selectedPartId)
                {
                    Inventory.AllParts.Remove(modifiedPart);
                    Inventory.AddPart(selectedPartId, updatedpart);
                    break;
                }
            }
        }
        #endregion
    }
}
