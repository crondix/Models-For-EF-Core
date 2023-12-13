using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MyModels.Models;
using System.Reflection;

namespace BlazorApp1.Components.Layout
{
    public partial class PrinterDetails
    {
      

        private void UpdatePrinter(Printers printer)
        {

            if (printer != null)
            {
                // Attach the object to the context
                DbContextPrinters.Attach(printer);

                // Mark the object as modified
                DbContextPrinters.Entry(printer).State = EntityState.Modified;

                // ...
                DbContextPrinters.SaveChanges();
            }
        }

        private void Cancel()
        {
            
                DbContextPrinters.Entry(Printer).Reload();
                
                // StateHasChanged();
               
            
        }
    }
}
