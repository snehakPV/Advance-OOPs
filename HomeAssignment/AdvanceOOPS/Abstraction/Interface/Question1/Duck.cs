using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Duck:IAnimal
    {
        private string _name;
       public string Name {get{return _name;}set{_name=value;}} 
       private string _habitat;
       public string Habitat {get{return _habitat;}set{_habitat=value;}}
       private string _eatingHabit;
       public string EatingHabit{get{return _eatingHabit;}set{_eatingHabit=value;}}
       public string DisplayName()
       {
        _name=Name;
        return _name;
       }
       public string DisplayInfo()
       {
         _name=Name;
        _habitat=Habitat;
        _eatingHabit=EatingHabit;
        return _name+" "+_habitat+" "+_eatingHabit;
       }
    }
}