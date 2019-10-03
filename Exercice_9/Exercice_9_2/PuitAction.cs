using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_2
{
    public class PuitAction : BaseAction, IActionComparateur
    {
        public PuitAction()
        {
            ActionDefinition = Action.Puit;
        }

        public bool Gagne(Action action)
        {
            return action == Action.Pierre || action == Action.Ciseaux;
        }
    }
}
