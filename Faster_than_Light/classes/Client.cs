using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Faster_than_Light.classes
{
    public class Client
    {
        [Key] public int ClientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthdate { get; set; }
        public string SeriaNumberPassport { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<Package> PackageEntites { get; set; }
    }
}
