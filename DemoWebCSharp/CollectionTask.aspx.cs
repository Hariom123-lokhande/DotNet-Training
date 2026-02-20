using System;
using DemoWebCSharp.Utility;

namespace DemoWebCSharp
{
    public partial class CollectionTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnArray_Click(object sender, EventArgs e)
        {
            CollectionDemo demo = new CollectionDemo();
            int index;
            if (int.TryParse(txtArray.Text, out index))
                lblArrayResult.Text = demo.GetArrayValue(index);
            else
                lblArrayResult.Text = "Invalid Input";
        }
        protected void btnArrayList_Click(object sender, EventArgs e)
        {
            CollectionDemo demo = new CollectionDemo();
            int index;

            if (int.TryParse(txtArrayList.Text, out index))
                lblArrayListResult.Text = demo.GetArrayListValue(index);
            else
                lblArrayListResult.Text = "Invalid Input";
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            CollectionDemo demo = new CollectionDemo();
            int index;

            if (int.TryParse(txtList.Text, out index))
                lblListResult.Text = demo.GetListValue(index);
            else
                lblListResult.Text = "Invalid Input";
        }

        protected void btnDictionary_Click(object sender, EventArgs e)
        {
            CollectionDemo demo = new CollectionDemo();
            int key;

            if (int.TryParse(txtDictionary.Text, out key))
                lblDictionaryResult.Text = demo.GetDictionaryValue(key);
            else
                lblDictionaryResult.Text = "Invalid Input";
        }
    }
}