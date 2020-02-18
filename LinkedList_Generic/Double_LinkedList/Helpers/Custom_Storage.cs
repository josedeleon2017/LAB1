using System;
using System.Linq;
using System.Web;
using CustomGenerics.Structures;
using LinkedList_Generic.Models;

namespace LinkedList_Generic.Double_LinkedList.Helpers
{
    public class Custom_Storage
    {
        private static Custom_Storage _instance = null;

        public static Custom_Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Custom_Storage();
                return _instance;
            }
        }

        public Double_LinkedList<CustomPlayerModel> playerList2 = new Double_LinkedList<CustomPlayerModel>();

    }
}