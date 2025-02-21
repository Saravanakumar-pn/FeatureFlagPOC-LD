using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeatureFlagPOC_LD
{
	public partial class Login : System.Web.UI.Page
	{
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text.Trim();

            if (string.IsNullOrEmpty(userId))
            {
                lblMessage.Text = "Please enter your User ID.";
                return;
            }

            // Store the user ID in session (you can expand to include other attributes as needed).
            Session["UserId"] = userId;

            // Redirect to the default page.
            Response.Redirect("Default.aspx");
        }
    }
}