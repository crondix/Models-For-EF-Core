using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyModels.Models;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            DbContextPrinters.ChangeTracker.Clear();
            Printer = DbContextPrinters.Printers.FirstOrDefault(p => p.Id == 1);
            
            //DbContextPrinters.Entry(Printer).Reload();
            //Printer=
            //       Printer.DeviceFunctions = DbContextPrinters.Entry(Printer)
            //.Collection(b => b.DeviceFunctions)
            //.Query()
            //.ToList(); ;


            //StateHasChanged();


        }
    }
}
