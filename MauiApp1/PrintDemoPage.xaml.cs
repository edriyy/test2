using System;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.Maui.Controls;


namespace MauiApp1;

public partial class PrintDemoPage : ContentPage
{
    private PrintDocument printDocument;

    public PrintDemoPage()
    {
        InitializeComponent();

        printDocument = new PrintDocument();
        printDocument.PrintPage += OnPrintPage;

    }

    private void OnPrintPage(object sender, PrintPageEventArgs e)
    {
        // Customize the printing content here
        using (System.Drawing.Font font = new System.Drawing.Font("Arial", 12))
        {
            e.Graphics.DrawString("Hello, Thermal Printer!", font, Brushes.Black, 10, 10);
        }
    }

    private void OnPrintButtonClicked(object sender, EventArgs e)
    {
        PrintController printController = new StandardPrintController();
        printDocument.PrintController = printController;

        try
        {
            printDocument.Print();
        }
        catch (Exception ex)
        {
            // Handle printing exception
            Console.WriteLine($"Printing error: {ex.Message}");
        }
    }
}

