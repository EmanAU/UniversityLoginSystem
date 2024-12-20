using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidbasedproject.Classes
{
    //*************This is for ADMIN SEALED CLASS****************//

    public sealed class Admin : loginAChangeStudentDetails
    {
        loginAAddOrRemoveStudent addOrRemove = new loginAAddOrRemoveStudent();
        loginAChangeUsernameAndPassword userAndPass = new loginAChangeUsernameAndPassword();

        public void addStudent()
        {
            addOrRemove.addStudent();
        }

        public void removeStudent()
        {
            addOrRemove.removeStudent();
        }

        public void changeUsername()
        {
            userAndPass.changeUsername();
        }


        public void changePassword()
        {
            userAndPass.changePassword();
        }


    }
}
