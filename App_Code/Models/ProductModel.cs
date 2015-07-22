using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
public class ProductModel
{
	public ProductModel()
	{
		//
		// TODO: Add constructor logic here
		
	}
    //insert a product method
    public string InSetProduct(Product product)
    {
        try
        {
            FinalEntities db = new FinalEntities();
            db.Products.Add(product);
            db.SaveChanges();//commit
            //return the got product.Name for the lable which is resultLabel to display
            return product.Name + " was successfully inserted.";
        }
        catch (Exception e)
        {
            
            return e.Message + "no idea";
        }
    }
    //update the product by the id
    public string UpdateProduct(int id, Product product)
    {
        try
        {
            //get the database
            FinalEntities db = new FinalEntities();
            //get the table from db
            Product pt = db.Products.Find(id);
            //use the pt id to get all the variables from db
            pt.Name = product.Name;
            pt.Image = product.Image;
            pt.Price = product.Price;
            pt.Type = product.Type;
            pt.Quantity = product.Quantity;
            pt.Description = product.Description;
            //commit it save it
            db.SaveChanges();
            //return the got Name for the lable which is resultLabel to display
            return product.Name + "was successfully updated.";
        }
        catch (Exception e)
        {

            return e.Message;
        }
    }
    //delete a product by the id
    public string DeleteProduct(int id)
    {
        try
        {
            //get the database
            FinalEntities db = new FinalEntities();
            //get the table from db
            Product pt = db.Products.Find(id);
            //attach() method Attaches a disconnected or "detached" entity to a new DataContext when original values are required for optimistic concurrency checks.
            db.Products.Attach(pt);
            //remove the product type by the id
            db.Products.Remove(pt);
            //save it
            db.SaveChanges();
            //return the got name for the lable which is resultLabel
            return pt.Name + "was successfully deleted.";
        }
        catch (Exception e)
        {

            return e.Message;
        }
    }

    //get product from db
    public Product GetProduct(int id)
    {
        try
        {
            //get the database
            FinalEntities db = new FinalEntities();
            //get the table from db
            Product pt = db.Products.Find(id);
            return pt;

        }
        catch (Exception e)
        {

            return null;
        }
    }
}