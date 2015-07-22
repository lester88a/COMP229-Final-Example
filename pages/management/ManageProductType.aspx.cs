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

    }
    //add function to the submit button
    protected void submitButton_Click(object sender, EventArgs e)
    {
        ProductTypeModel model = new ProductTypeModel();
        ProductType pt = createProductType();
        //change the lable text
        resultLabel.Text = model.InSetProductType(pt);

    }

    private ProductType createProductType()
    {
        //access productType db
        ProductType p = new ProductType();
        p.TypeDescreption = TextBoxProductDesc.Text;
        return p;
    }
}