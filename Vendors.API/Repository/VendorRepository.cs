using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Vendors.API.Data;
using Vendors.API.Models;

namespace Vendors.API.Repository
{
    public class VendorRepository :IVendorRespository<Vendor>
    {
        VendorContext _context;
        public VendorRepository(VendorContext context)
        {
            _context = context;
        }

        //GET Method
        public IEnumerable<Vendor> GetAll()
        {
            return _context.Vendor.ToList();
        }

        //
        public IEnumerable<Vendor> GetVendor(int id)
        {
            try
            {
                IEnumerable<VendorStock> vs = _context.VendorStock.Include(v => v.Vendor).
                    Where(v => v.ProductId == id && v.HandInStocks > 0);
                return vs.Select(v => v.Vendor);
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Post Method 
        public void PostStock(VendorStock vs)
        {
            vs.ReplinshmentDate = Convert.ToDateTime(vs.ReplinshmentDate);
            _context.VendorStock.Add(vs);  
            _context.SaveChanges();
            

        }


    }
}
