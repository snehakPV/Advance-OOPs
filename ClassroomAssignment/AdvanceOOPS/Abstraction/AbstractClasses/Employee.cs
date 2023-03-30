using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Employee
    {
        protected string _name;  //normal field
        public abstract string Name { get;set; }   //Abstract property declaration
        public double Amount { get;set; }  //normal property
        public string Display(){return _name;}  //normal method
        public abstract double Salary (int dates);  //Abstract method - only declaration
        //Abstract class - partial abstraction
        //can have both abstract declaration and normal declaration
        //can only used with inherited class
        //no objects or constructor created for this class
        //not used for multiple inheritance

    }
}