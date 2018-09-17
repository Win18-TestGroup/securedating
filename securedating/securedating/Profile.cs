using System;
using System.Collections.Generic;
using System.Text;

namespace securedating
{
    class Profile //ska ärva från user
    {

        public string profile { get; set ; }
        
       
        public void CreateProfile()
        {
            profile = ""; //flush
            profile = Console.ReadLine();
        }
        public void EditProfile()
        {
            profile = Console.ReadLine();
        }
        public void RemoveProfile()
        {
            profile = "";
        }

    }
}
