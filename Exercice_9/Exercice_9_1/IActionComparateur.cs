using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_1
{
    public interface IActionComparateur
    {
        Action ActionDefinition { get; }

        bool Gagne(Action action);
    }
}
