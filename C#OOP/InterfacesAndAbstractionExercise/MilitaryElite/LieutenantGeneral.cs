﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> privates;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => privates.AsReadOnly();

        public void AddPrivate(IPrivate @private)
        {
            privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($"Privates:");

            foreach (var soldier in Privates)
            {
                sb.AppendLine(soldier.ToString());
            }

            return sb.ToString();
        }
    }
}
