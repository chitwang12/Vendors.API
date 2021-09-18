using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendors.API.Data;
using Vendors.API.Models;

namespace Vendors.API.Repository
{
   public interface IVendorRespository<T>
    { 
         public IEnumerable<Vendor> GetAll();
         public  IEnumerable<Vendor> GetVendor(int id);

         public void PostStock(VendorStock vs);
    }
}
