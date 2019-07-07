using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.DataModel
{
    public interface IShowOnPanel
    {
        Patient MainPatient { get; set; }
    }
}
