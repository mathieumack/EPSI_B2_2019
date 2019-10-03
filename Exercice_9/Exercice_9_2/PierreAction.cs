using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_2
{
    public class PierreAction : BaseAction, IActionComparateur
    {
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
