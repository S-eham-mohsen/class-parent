using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace class_parents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            parent parent = new parent();
            parent.print();
        }
    }
    


    class parent
    {
        // attributes
       public string name;
       public string gender;
       public double salary;
       public string jop;
       public double number_of_kids;
       public string[] kids_name;
       public double number_of_timejop;
        double id;
        // --------------------------------------------------------------------------------------------------
        // constructors
        public parent()
        {

        }
        public parent(string name, string gender, double salary, string jop, double number_of_kids, string[] kids_name, double number_of_timejop, double id)
        {
            this.name = name;
            this.gender = gender;
            this.salary = salary;
            this.jop = jop;
            this.number_of_kids = number_of_kids;
            this.kids_name = kids_name;
            this.number_of_timejop = number_of_timejop;
            this.id = id;
        }
        public parent(double id)
        {
            this.id = id;
        }
        public parent (parent parent)
        {
            this.name = parent.name;
            this.gender = parent. gender;
            this.salary = parent.salary;
            this.jop = parent.jop;
            this.number_of_kids = parent.number_of_kids;
            this.kids_name = parent.kids_name;
            this.number_of_timejop = parent.number_of_timejop;
        }
        public parent(string name , string gender)
        {
            this.name=name;
            this.gender = gender;
        }
        //------------------------------------------------------------------------------------------------------
        //methods 

        public void print()
        {
            Console.WriteLine($"parent name : {name} \nparent gender : {gender} \nparent salary : {salary} \nparent jop : {jop} \nparent number of kids :{number_of_kids} \nkids_name : {kids_name} \nparent number of time jop : {number_of_timejop}");
        }
        public double net_salary (double tax,double sal )
       
        {
            int tax_rasio =int.Parse(Console.ReadLine());
            tax = tax_rasio * sal;
            return  sal-tax_rasio;
        }
        

    }
}
