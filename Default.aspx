<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FeatureFlagPOC_LD.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LaunchDarkly Feature Flags Demo</title>
    <style>
        .chart-placeholder {
            width: 400px;
            height: 300px;
            background-color: #f5f5f5;
            border: 1px solid #ccc;
            text-align: center;
            line-height: 300px;
            font-size: 24px;
            color: #666;
        }
        .logout-btn {
            float: right;
            margin: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="logout-btn" OnClick="btnLogout_Click" />
        <div>
            <!-- Panel for Table (FeatureX) -->
            <asp:Panel ID="pnlTable" runat="server" Visible="false">
                <asp:Literal ID="litTable" runat="server"></asp:Literal>
            </asp:Panel>
            <!-- Panel for Chart (FeatureY) -->
            <asp:Panel ID="pnlChart" runat="server" Visible="false">
                <div class="chart-placeholder">Chart Placeholder</div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>