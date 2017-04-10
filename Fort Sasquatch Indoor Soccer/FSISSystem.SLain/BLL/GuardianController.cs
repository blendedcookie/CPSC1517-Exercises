using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FSISSystem.SLain.Data;
using FSISSystem.SLain.DAL;
using System.Data.SqlClient;

namespace FSISSystem.SLain.BLL
{
    class GuardianController
    {

        public List<Guardian> Guardian_List()
        {

            using (var context = new FSISContext())
            {
                return context.Guardians.ToList();
            }



        
        } 
    }
}
