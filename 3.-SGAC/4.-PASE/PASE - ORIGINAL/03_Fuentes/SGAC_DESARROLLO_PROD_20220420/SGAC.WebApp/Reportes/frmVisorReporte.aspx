﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVisorReporte.aspx.cs" Inherits="SGAC.WebApp.Reportes.frmVisorReporte" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>

    <rsweb:ReportViewer ID="rpsProtocolar" runat="server" Height="431px"
        Width="700px" DocumentMapWidth="100%" BorderStyle="None" SizeToReportContent="true"
        ZoomMode="PageWidth" DocumentMapCollapsed="true"
        PromptAreaCollapsed="true" ViewStateMode="Enabled">

    </rsweb:ReportViewer>
    </form>
</body>
</html>

