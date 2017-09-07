using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities.Model
{
    class Base64Image
    {
        public Guid Id { get; set; }
        public String Base64EncodedImage { get; set; }
    }
}
