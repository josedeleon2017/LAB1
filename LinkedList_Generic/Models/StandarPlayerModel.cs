using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedList_Generic.Double_LinkedList.Helpers;

namespace LinkedList_Generic.Models
{
    public class StandarPlayerModel : IComparable
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Club { get; set; }
        public int Salary { get; set; }
        public bool Save()
        {
            try
            {
                Storage.Instance.playerList.AddLast(this);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string name)
        {
            
            return true;
        }

        public int CompareTo(object obj)
        {
            var comparer = (StandarPlayerModel)obj;

            return Name.CompareTo(comparer.Name);
        }

        public static Comparison<StandarPlayerModel> Ordenar = delegate (StandarPlayerModel player1, StandarPlayerModel player2)
        {
            return player1.CompareTo(player2);
        };
    }
}