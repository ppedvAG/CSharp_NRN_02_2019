using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public interface IMilchEinfüllbar
    {
        void FülleMilchEin(float menge);

        float Milchmenge { get; }
    }
}
