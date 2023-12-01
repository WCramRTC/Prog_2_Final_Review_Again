using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Prog_2_Final_Review_Again
{
    public class Gift
    {

        string _shape;
        string _giftwrap;
        string _bow;
        object _package;

        public Gift(string shape, string giftwrap, string bow, object package)
        {
            _shape = shape;
            _giftwrap = giftwrap;
            _bow = bow;
            _package = package;
        }

        public string Shape { get => _shape; set => _shape = value; }
        public string Giftwrap { get => _giftwrap; set => _giftwrap = value; }
        public string Bow { get => _bow; set => _bow = value; }
        public object Package { get => _package; set => _package = value; }

        // Highlight your fields
        // Alt + Enter
        // Generate Constructor
        // Encapsulate Fields ( but use fields )



        //// Constructor
        //public Gift(object package)
        //{
        //    _package = package;
        //}

        //public Gift(string shape)
        //{
        //    _shape = shape;
        //}

        //// Properties
        //public object Package
        //{
        //    // get
        //    get
        //    {
        //        return _package;
        //    }
        //    set
        //    {
        //        _package = value;
        //    }

        //    // set
        //}

    }
}
