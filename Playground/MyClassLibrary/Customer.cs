using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public abstract class Person // "abstract class" allows us to inherit from the class, but prevents us from instantiating with the class --> var customer = new MyLibrary.Person()
    {
        public string Name { get; set; }

        public virtual void UpdateName(string newName)
        {
            Name = newName;
        }
    }

    public class Customer : Person // customer inherits the stuff inside of Person, that way we don't have to include it everywhere else
    {
        internal int CustomerId { get; set; }

        public override void UpdateName(string newName)
        {
            base.UpdateName(newName);
            Name = "some other value";
        }
    }

    public class Supplier : Person
    {
        public int SupplierId { get; set; }
    }

    public class otherclass
    {
        public void dosomething()
        {
            Customer customer = new Customer();
            //customer.CustomerId;
        }
    }
}