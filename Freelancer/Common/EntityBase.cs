using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Common
{
    internal class EntityBase<Tkey>
    {
        public Tkey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

    }
}
