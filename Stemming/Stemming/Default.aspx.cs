using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stemming
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string value = TextBox2.Text;
            ServiceReference1.IstemClient service = new ServiceReference1.IstemClient();
            string result = service.stemming(value);
            TextBox1.Text = result;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}