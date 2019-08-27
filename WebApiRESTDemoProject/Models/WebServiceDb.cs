using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiRESTDemoProject.Models {
    public class WebServiceDb : DbContext {


        public DbSet<Product> Products { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public WebServiceDb(DbContextOptions options) : base(options) 
            {

        }

        string c = @"Data Source=DESKTOP-8R894VL\SQLEXPRESS;Initial Catalog = WebAPIDemo; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    }
}
