using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_2
{
    public class FeuilleAction : BaseAction, IActionComparateur
    {
        public FeuilleAction()
        {
            ActionDefinition = Action.Feuille;
        }

        public bool Gagne(Action action)
        {
            return action == Action.Pierre || action == Action.Puit;
        }
    }
}
