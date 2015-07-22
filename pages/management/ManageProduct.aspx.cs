using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_management_ManageProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetImages();
            //determine new or existing product
            //check if url has an id parapeter
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                //retrieve the product and fill in the fields
                FillPage(id);
            }
        }
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        //get the productModle.cs function
        ProductModel pm = new ProductModel();
        //call the createProduct() method
        Product product = createProduct();
        //add new product
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            //display the resultmessage and call the InSetProduct method from pm which is the productModle.cs
            productMessageLabel.Text = pm.InSetProduct(product);

        }
        //modify existing model update
        else
        {
            //get the existing product id
            int id = Convert.ToInt32(Request.QueryString["id"]);
            //use update method
            productMessageLabel.Text = pm.UpdateProduct(id, product);
        }



    }
    // createProduct() method
    private Product createProduct()
    {
        //access productType db
        Product p = new Product();
        p.Name = nameTextBox.Text;
        p.Type = Convert.ToInt32(typeDropDownList.SelectedValue);
        p.Description = descriptionTextBox.Text;
        p.Price = Convert.ToInt32(priceTextBox.Text);
        p.Image = imageDropDownList.SelectedValue;

        return p;
    }

    //load the images from images folder
    private void GetImages()
    {
        try
        {
            string[] images = Directory.GetFiles(Server.MapPath("~/images/Products"));
            List<string> imageList = new List<string>();
            foreach (string s in images)
            {
                string imageName = s.Substring(s.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }
            imageDropDownList.DataSource = imageList;
            imageDropDownList.AppendDataBoundItems = true;
            imageDropDownList.DataBind();
        }
        catch (Exception e)
        {
            productMessageLabel.Text = e.Message;
        }

    }
    //FillPage() method 
    private void FillPage(int id)
    {
        ProductModel pModel = new ProductModel();
        Product product = pModel.GetProduct(id);
        descriptionTextBox.Text = product.Description;
        nameTextBox.Text = product.Name;
        priceTextBox.Text = product.Price.ToString();
        imageDropDownList.SelectedValue = product.Image;
        typeDropDownList.SelectedValue = product.Type.ToString();
    }
}