using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food2U_TudorB
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
           
            RegisterResulLabel.Text = "Hello " + firstNametxtbx.Text + " " + surnameTxtbx.Text + "you have been registered succesfully, you can login now";
            }
    }
}