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
}