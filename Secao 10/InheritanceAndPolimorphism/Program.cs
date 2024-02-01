using System;

namespace InheritanceAndPolimorphism {
    internal class Program {
        static void Main(string[] args){

            BusinessAccount businessAccount = new BusinessAccount(123, "Bruno", 02.2, 5000);
            
            //Downcasting
            /*
                Downcasting means that we are going to instaciate a variable from superclass to subclass
                Downcasting: I had my methods/variables + subclass methods/variables and now I have just the subclass methods/variables
            */
            Account acc1 = businessAccount;

            //Upcasting
            /*
                This is a extremealy dangerous operation!!!!
                Basically means that we are going to create a variable from subclass to superclass
            */
            BusinessAccount b1 = (BusinessAccount) new Account(123, "Bruno", 02.2);
        }
    }
}