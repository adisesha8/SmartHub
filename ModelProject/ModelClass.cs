using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class ModelClass
    {
        [DisplayName("Salutation")]
        public string Prefix { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Suffix")]
        public string Suffix { get; set; }

        [DisplayName("Gender")]
        public string Sex { get; set; }

        [DisplayName("Date Of Birth")]
        public DateTime DOB { get; set; }

        [DisplayName("Age")]
        public string Age { get; set; }

        [DisplayName("Locality")]
        public string Locale { get; set; }

        [DisplayName("Marital Status")]
        public string MaritalStatus { get; set; }
    }
}
