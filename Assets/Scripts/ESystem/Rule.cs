using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyLogic
{
    public class Rule
    {
        protected List<Clause> mAntecedents = new List<Clause>();
        protected Clause mConsequent = null;
        string mName;

        public Rule(string name)
        {
            mName = name;
        }

        public Clause Consequent
        {
            set
            {
                mConsequent = value;
            }
            get
            {
                return mConsequent;
            }
        }

        public void AddAntecedent(Clause antecedent)
        {
            mAntecedents.Add(antecedent);
        }

        public Clause getAntecedent(int index)
        {
            return mAntecedents[index];
        }

        public int AntecedentCount
        {
            get
            {
                return mAntecedents.Count;
            }
        }

    }
}
