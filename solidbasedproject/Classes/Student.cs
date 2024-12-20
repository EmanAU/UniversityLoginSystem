using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidbasedproject.Classes
{
    //************************THIS IS SEALED CLASS FOR STUDENT LOGIN***********//
    public sealed class Student : loginBChangingUserAndPass
    {
        loginBViewingData view = new loginBViewingData();
        public void seeData()
        {
            view.seeData();
        }

    }
}
