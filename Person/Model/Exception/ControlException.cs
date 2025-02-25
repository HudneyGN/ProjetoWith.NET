using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person.Model.Exception
{
    public class ControlException : ApplicationException
    {
        public ControlException(string message) : base(message)
        {
        }
    }
}
