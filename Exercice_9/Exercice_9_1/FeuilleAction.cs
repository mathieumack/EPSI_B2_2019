using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_1
{
    public class FeuilleAction : IActionComparateur
    {
        public Action ActionDefinition { get; private set; }

        public FeuilleAction()
        {
            ActionDefinition = Action.Feuille;
        }

        public bool Gagne(Action action)
        {
            return action == Action.Pierre;
        }
    }
}
