using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductTypeModel
/// </summary>
public class ProductTypeModel
{
	public ProductTypeModel()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    //insert product type method
    public string InSetProductType(ProductType productType)
    {
        try
        {

            FinalEntities db = new FinalEntities();
            db.ProductTypes.Add(productType);
            db.SaveChanges();//commit
            return productType.TypeDescreption + " was successfully inserted.";
        }
        catch (Exception e)
        {

            return e.Message;
        }
    }
    //update product type by the id
    public string UpdateProductType(int id, ProductType productType)
    {
        try
        {
            //get the database
            FinalEntities db = new FinalEntities();
            //get the table from db
            ProductType pt = db.ProductTypes.Find(id);
            //use the pt id to get the TypeDescreption from db
            pt.TypeDescreption = productType.TypeDescreption;
            //commit it save it
            db.SaveChanges();
            //return the got TypeDescreption for the lable which is resultLabel
            return productType.TypeDescreption + "was successfully updated.";
        }
        catch (Exception e)
        {

            return e.Message;
        }
    }
    //delete a productType by the id
    public string DeleteProductType(int id)
    {
        try
        {
            //get the database
            FinalEntities db = new FinalEntities();
            //get the table from db
            ProductType pt = db.ProductTypes.Find(id);
            //attach() method Attaches a disconnected or "detached" entity to a new DataContext when original values are required for optimistic concurrency checks.
            db.ProductTypes.Attach(pt);
            //remove the product type by the id
            db.ProductTypes.Remove(pt);
            //save it
            db.SaveChanges();
            //return the got TypeDescreption for the lable which is resultLabel
            return pt.TypeDescreption + "was successfully deleted.";
        }
        catch (Exception e)
        {
            
            return e.Message;
        }
    }
}