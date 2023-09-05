using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusModificacionGasto
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model119")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
