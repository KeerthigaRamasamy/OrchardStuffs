using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using namespace_second;

namespace access_specifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            access_modifiers obj1 = new access_modifiers();
            derived_class obj2 = new derived_class();
            a obj3 = new a();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Using derived class object accessing the members of base class");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            obj2.derived_fun();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Using different namespace object accessing the members of base class");
            Console.WriteLine("---------------------------------------------------------------");
            obj3.namespace2_fun();
        }
    }
     class access_modifiers
    {
        //public 
        public int public_varilable;

        //private
        private int private_varilable;

        //protected
        protected int protected_varilable;

        //internal
        internal int internal_varilable;

        //protected internal
        protected internal int protected_internal_varilable;

        //public access_modifiers()
        //{
        //    public_varilable = 1;
        //    private_varilable = 2;
        //    protected_varilable = 3;
        //    internal_varilable = 4;
        //    protected_internal_varilable =5;
        //}

            //public
        public void public_fun()
        {
            Console.WriteLine("Public function accessed");
        }
        //private

        private void private_fun()
        {
            Console.WriteLine("private function accessed");
        }

        //protected

        protected void protected_fun()
        {
            Console.WriteLine("Protected function accessed");
        }

        //internal

        internal void internal_fun()
        {
            Console.WriteLine("internal function accessed");
        }

        //protected internal
        protected internal void protected_internal_fun()
        {
            Console.WriteLine("protected internal function accessed");
        }
    }

    //derived class

     class derived_class : access_modifiers
    {
        access_modifiers object_base = new access_modifiers();

        public void derived_fun()
        {
            //acccessing protected ,public,internal,protected internal variables in the derived class

            protected_internal_varilable = 6;
            public_varilable = 7;
            internal_varilable = 9;
            protected_varilable = 5;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Public  variable accessed in the derived class, value=" + public_varilable);
            Console.WriteLine("Protected variable accessed in the derived class, value=" + protected_varilable);
            Console.WriteLine("Protected internal variable accessed in the derived class, value=" + protected_internal_varilable);
            Console.WriteLine("internal variable accessed in the derived class, value=" + internal_varilable);
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();

            //acccessing protected ,public,internal,protected internal functions in the derived class

            Console.WriteLine("---------------------------------------------------------------");
            protected_fun();
            public_fun();
            internal_fun();
            protected_internal_fun();
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}



namespace namespace_second
{
    using access_specifiers;

    //derived class from the base class of another namespace
     class a:access_modifiers
    {
        public void namespace2_fun()
        {
            //accessing public,protected internal variable

            public_varilable = 2;
            protected_internal_varilable = 3;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("public variable accessed from another namespace" + public_varilable);
            Console.WriteLine("protected internal variable accessed from another namespace" + protected_internal_varilable);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            //public,protected internal function accessed from another namespace
            Console.WriteLine("---------------------------------------------------------------");
            public_fun();
            protected_internal_fun();
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}