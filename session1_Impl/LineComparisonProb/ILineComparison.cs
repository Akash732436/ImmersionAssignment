using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl.LineComparisonProb
{
    public interface ILineComparison
    {
        Double LengthOfLine();
        bool CheckIfEqual();
        int CompareLines();
    }
}
