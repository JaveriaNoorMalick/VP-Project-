using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_PROJECT
{
    class Utilities
    {
        public static bool applyAssociation = false;

        public static void setAssociation(bool AssociationStatus)
        {
            applyAssociation = AssociationStatus;
        }

        public static bool getAssociation()
        {
            return applyAssociation;
        }

        public static void showErrors(String errMessage, Label lblErr)
        {
            lblErr.Text = errMessage;
            lblErr.ForeColor = Color.Red;
        }
        public static int count = 0;
        public static string[] names = new string[100];
        public static bool dupFound = false;
        public static string getNotation;

        public static void AddClassName(string name)
        {
            names[count] = name;
            count++;
        }



        public static void WhichNotation(string txt)
        {
            if (txt == "Structure")
            {
                getNotation = "struct";
            }
            else if (txt == "Class")
            {
                getNotation = "class";
            }
            else if (getNotation == "Interface")
            { getNotation = "interface"; }
            else if (txt == "Enumeration")
            {
                getNotation = "enum";
            }
        }
        public static string ReturnNotation()
        {
            return getNotation;
        }

        public static string[] ChangeClassName(string NewName, string OldName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == OldName)
                {
                    names[i] = NewName;
                }
            }
            return names;
        }

        public static bool RemoveDuplicates(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    if ((names[i] != null) && (names[j] != null))
                    {
                        if (i != j)
                        {
                            if (names[i] == names[j])
                            {
                                //names[i] = names[j];
                                dupFound = true;
                                return dupFound;
                            }
                        }
                    }
                }

            }
            return dupFound;
        }
        public static bool DuppExists()
        {
            return dupFound;
        }

        public static void isNameExist()
        {

        }

        public static string[] getClassNames()
        {
            return names;
        }
        public static Point loc = new Point();
        public static void setLocationOfChildForm(Point location)
        {
            loc = location;
        }
        public static Point getLocationOfArrw()
        {
            return loc;
        }
    }
}
