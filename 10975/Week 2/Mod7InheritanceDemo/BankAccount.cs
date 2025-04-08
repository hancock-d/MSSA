using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7InheritanceDemo
{
    //CREATING PARENT CLASS
    internal class BankAccount
    {
        public int AccountNumber { get; set; } //a property
        public string HolderName { get; set; } //public/private/protected are Access modifiers
        public double Balance { get; set; }
        protected double minBalance; //acting like a private variable, cannot see in client code. Will be available in class heierarchy
                                     //setting minBalance by myself, client cannot set it, can only see it
                                     //it is inherited in derived classes but hidden from client code
        public double MinBalance { get { return this.minBalance; } } //setting minBalance by myself, client cannot set it, can only see it
                                                                     //should be returning this minBalance that you're trying to set
                                                                     //when associating public property with private property, must create relationship (that's what return this.minBalance...)
                                                                     //return the data minBalance from "this.Instance"
       //public void SetBalance() //Job of SetBalance sets ,
        //{
        //}
    }
    //CREATING A NEW CHILD CLASS
    class SavingsAccount : BankAccount  //--> class NewChildClassName:ParentClassName make sure outside the scope of the BankAccount class
    {
        //writing the constructor //helps to initialize variables, but not passing any arguments
        //Required to change specifics of the child class
        public SavingsAccount()
        {
            this.minBalance = 300; //"this." is required because minBalance is protected, setting min balance at 300 for the SAvingsAccount class
        }
    }
    //CREATING NEW CHILD CLASS
    class CheckingAccount : BankAccount
    {
        //CREATING CONSTRUCTOR TO HOLD FIELDS/PROPERTIES
        public CheckingAccount()
        {
            this.minBalance = 50;
        }
    }
}
