using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSISSystem.SLain.Data
{
    [Table("Player")]
    public class Player
    {

        public string _Gender { get; set; }

        [Key]
        public int PlayerID { get; set; }
        public int GuardianID { get; set; }
        public int TeamID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender
        {
            get
            {
                return _Gender.ToUpper();
            }
        }

        

        public string MedicalAlertDetails
        {
            get
            {
                return MedicalAlertDetails;
            }

            set
            {
                if (MedicalAlertDetails.IsNullOrEmpty())
                {
                     null;
                }
                else
                {
                    return MedicalAlertDetails;
                }
            }
        }

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + ", " + LastName;
            }
        }

    }
}
