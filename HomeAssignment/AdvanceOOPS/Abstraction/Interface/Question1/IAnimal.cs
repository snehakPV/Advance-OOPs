using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public interface IAnimal
    {
        string Name{get;set;}
        string Habitat {get;set;}
        string EatingHabit {get;set;}
        string DisplayName();
    }
}