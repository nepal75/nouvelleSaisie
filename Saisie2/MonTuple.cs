//POUR MANIPULER DES TUPLES DANS UNE LISTVIEW, ON EST OBLIGÉ DE CRÉER NOTRE PROPRE TYPE DE TUPLE

using System;

namespace Saisie2
{
    public class MonTuple<T,U>
    {
        //CONSTRUCTEURS
        public MonTuple(){}

        public MonTuple(T first, U second){
            this.First = first;
            this.Second = second;
        }

        //ATTRIBUTS
        public T First { get; set; }
        public U Second { get; set; }
    }
}
