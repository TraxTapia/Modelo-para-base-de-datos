using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.REMESASECE.Iss
{
    public partial class ctxtt : DbContext
    {
        public ctxtt()
            : base("name=ctxtt")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
