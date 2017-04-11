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
    public class GuardianController
    {
        //get list of guardians
        public List<Guardian> Guardian_List()
        {

            using (var context = new FSISContext())
            {
                return context.Guardians.ToList();
            }
        }

        //find a single guardian based on guardian ID
        public Guardian Guardian_Find(int guardianid)
        {
            using (var context = new FSISContext())
            {
                return context.Guardians.Find(guardianid);
            }
        }



    }
}
