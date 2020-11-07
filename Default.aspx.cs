using System;
using ZamówieniaKlientaTableAdapters;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        PobierzDaneZamowienia(DropDownList1.SelectedItem.Text);
    }

    protected void PobierzDaneZamowienia(string idKlienta)
    {
        ZamówieniaKlienta mojZbiorDanych = new ZamówieniaKlienta();
        CustomersTableAdapter klientDA = new CustomersTableAdapter();
        OrdersTableAdapter zamowienieDA = new OrdersTableAdapter();

        klientDA.Fill(mojZbiorDanych.Customers, idKlienta);
        zamowienieDA.Fill(mojZbiorDanych.Orders, idKlienta);

        GridView1.DataSource = mojZbiorDanych.Tables["Customers"];
        GridView1.DataBind();

        GridView2.DataSource = mojZbiorDanych.Tables["Orders"];
        GridView2.DataBind();
    }
}