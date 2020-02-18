using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedList_Generic.Models;


namespace LinkedList_Generic.Double_LinkedList.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }

        public LinkedList<StandarPlayerModel> playerList = new LinkedList<StandarPlayerModel>();
        
    }
}