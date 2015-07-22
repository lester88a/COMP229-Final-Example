using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_management_ManageProductType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
             //check if url has an id parapeter
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                //retrieve the product and fill in the fields
                FillPage(id);
            }
        }
    }
    //FillPage() method 
    private void FillPage(int id)
    {
        ProductTypeModel ptModel = new ProductTypeModel();
        ProductType productType = ptModel.GetProduct(id);
        TextBoxProductDesc.Text = productType.TypeDescreption;
    }
    //add function to the submit button
    protected void submitButton_Click(object sender, EventArgs e)
    {
        //get the ProductTypeModel.cs function
        ProductTypeModel ptModel = new ProductTypeModel();
        //call the createProductType() method
        ProductType productType = createProductType();
        //add new ProductType
        if (String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            //display the resultmessage and call the InSetProductType method from pm which is the productModle.cs
            TextBoxProductDesc.Text = ptModel.InSetProductType(productType);

        }
        //modify existing model update
        else
        {
            //get the existing ProductType id
            int id = Convert.ToInt32(Request.QueryString["id"]);
            //use update method
            TextBoxProductDesc.Text = ptModel.UpdateProductType(id, productType);
        }

    }

    private ProductType createProductType()
    {
        //access productType db
        ProductType p = new ProductType();
        p.TypeDescreption = TextBoxProductDesc.Text;
        return p;
    }
}