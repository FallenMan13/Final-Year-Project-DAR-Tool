using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_DAR_Tool
{
    class SubCriteria
    {
        //Code written by Ross Craig B00705624
        //Private Variables
        private int weighting;
        private String mainCriteria;
        private String criteria;

        //Properties
        public int Weighting
        {
            get
            {
                return weighting;
            }
            set
            {
                weighting = value;
            }
        }

        public String MainCriteria
        {
            get
            {
                return mainCriteria;
            }
            set
            {
                mainCriteria = value;
            }
        }

        public String Criteria
        {
            get
            {
                return criteria;
            }
            set
            {
                criteria = value;
            }
        }

        //Overloaded Constructor
        public SubCriteria(int newWeighting, String newMainCriteria, String newCriteria)
        {
            Weighting = newWeighting;
            MainCriteria = newMainCriteria;
            Criteria = newCriteria;
        }
    }
}
