using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public interface IOrderState
    {
        void OnEnterState();
        void Handle();
    }
}
