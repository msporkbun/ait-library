using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerLocal;

namespace BusinessLogicLocal
{
    public class PairModel
    {
        //shortcut to make attribute+property combo = type propfull, hit tab twice, fill in the blanks

        private int pairID; //attribute

        public int PairID //property to manage attribute
        {
            get { return pairID; }
            set { pairID = value; }
        }

        private string pairName;

        public string PairName
        {
            get { return pairName; }
            set { pairName = value; }
        }

        public static PairModel Parse(BookDS.TabCategoryRow categoryRow)
        {
            if (categoryRow == null)
                return null;

            PairModel pair = new PairModel();
            pair.PairID = categoryRow.CID;
            pair.PairName = categoryRow.CategoryName;

            return pair;
        }
        public static PairModel Parse(BookDS.TabLanguageRow langRow)
        {
            if (langRow == null)
                return null;
            PairModel pair = new PairModel();
            pair.PairID = langRow.LID;
            pair.PairName = langRow.LanguageName;

            return pair;

        }
        public static PairModel Parse(BookDS.TabAuthorRow authorRow)
        {
            if (authorRow == null)
                return null;
            PairModel pair = new PairModel();
            pair.PairID = authorRow.AID;
            pair.PairName = authorRow.AuthorName;

            return pair;

        }

    }
}
