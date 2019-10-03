using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_1
{
    public class PierreAction : IActionComparateur
    {
        public Action ActionDefinition { get; private set; }

        public PierreAction()
        {
            ActionDefinition = Action.Pierre;
        }

        public bool Gagne(Action action)
        {
            return action == Action.Ciseaux;
        }
    }
}
