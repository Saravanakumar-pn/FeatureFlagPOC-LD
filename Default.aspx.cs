using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Server;

namespace FeatureFlagPOC_LD
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve the logged-in user's ID from the session.
                string userId = Session["UserId"] as string;
                if (string.IsNullOrEmpty(userId))
                {
                    Response.Redirect("Login.aspx");
                    return;
                }

                // Create a LaunchDarkly user with the given userId.
                // You can add additional attributes (like email) if needed.
                var ldUser = LaunchDarkly.Sdk.Context.Builder(userId).Build();            

                // Evaluate feature flags using the LaunchDarkly client.
                // Note: The feature flag keys should match those configured in your LaunchDarkly project.
                bool isFeatureXEnabled = LdClientProvider.Client.BoolVariation("FeatureX", ldUser, false);
                bool isFeatureYEnabled = LdClientProvider.Client.BoolVariation("FeatureY", ldUser, false);

                // Display the table if FeatureX is enabled.
                pnlTable.Visible = isFeatureXEnabled;
                if (isFeatureXEnabled)
                {
                    litTable.Text = @"
                        <table border='1' style='width:400px;'>
                            <tr>
                                <th>Name</th>
                                <th>Value</th>
                            </tr>
                            <tr>
                                <td>Item 1</td>
                                <td>Value 1</td>
                            </tr>
                            <tr>
                                <td>Item 2</td>
                                <td>Value 2</td>
                            </tr>
                        </table>";
                }

                // Display the chart placeholder if FeatureY is enabled.
                pnlChart.Visible = isFeatureYEnabled;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear the session and redirect to the login page.
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}