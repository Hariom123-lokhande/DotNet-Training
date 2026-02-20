<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CollectionTask.aspx.cs" Inherits="DemoWebCSharp.CollectionTask" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Collection Task</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <div class="card shadow p-4">
                        <h3 class="text-center text-primary mb-4">Collection Operation</h3>

                        <!-- ===== Array Section ===== -->
                        <h5>Array</h5>
                        <div class="mb-3">
                            <asp:TextBox ID="txtArray" runat="server" CssClass="form-control" placeholder="Enter Index"></asp:TextBox>
                            <asp:Button ID="btnArray" runat="server"
                                Text="Get Array Value"
                                CssClass="btn btn-primary mt-2"
                                OnClick="btnArray_Click" />
                            <asp:Label ID="lblArrayResult" runat="server"
                                CssClass="d-block mt-2 text-primary fw-bold"></asp:Label>
                        </div>
                        <!-- ===== ArrayList Section ===== -->
                        <h5>ArrayList</h5>
                        <div class="mb-3">
                            <asp:TextBox ID="txtArrayList" runat="server" CssClass="form-control" placeholder="Enter Index"></asp:TextBox>
                            <asp:Button ID="btnArrayList" runat="server"
                                Text="Get ArrayList Value"
                                CssClass="btn btn-warning mt-2"
                                OnClick="btnArrayList_Click" />
                            <asp:Label ID="lblArrayListResult" runat="server"
                                CssClass="d-block mt-2 text-warning fw-bold"></asp:Label>
                        </div>
                        <!-- ===== List Section ===== -->
                        <h5>List</h5>
                        <div class="mb-3">
                            <asp:TextBox ID="txtList" runat="server" CssClass="form-control" placeholder="Enter Index"></asp:TextBox>
                            <asp:Button ID="btnList" runat="server"
                                Text="Get List Value"
                                CssClass="btn btn-info mt-2"
                                OnClick="btnList_Click" />
                            <asp:Label ID="lblListResult" runat="server"
                                CssClass="d-block mt-2 text-info fw-bold"></asp:Label>
                        </div>
                        <!-- ===== Dictionary Section ===== -->
                        <h5>Dictionary</h5>
                        <div class="mb-3">
                            <asp:TextBox ID="txtDictionary" runat="server" CssClass="form-control" placeholder="Enter Key"></asp:TextBox>
                            <asp:Button ID="btnDictionary" runat="server"
                                Text="Get Dictionary Value"
                                CssClass="btn btn-success mt-2"
                                OnClick="btnDictionary_Click" />
                            <asp:Label ID="lblDictionaryResult" runat="server"
                                CssClass="d-block mt-2 text-success fw-bold"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>tml>