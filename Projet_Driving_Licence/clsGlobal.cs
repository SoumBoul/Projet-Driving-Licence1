using ClassBusinesLayerDrivingLicense;
using Projet_Driving_Licence;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
public   class clsGlobal
{
   static  public string name { get; set; }
    static  public string pass{ get; set; }
    static public  bool RemmemberMe { get; set; }
    static public int personId { get; set; }
    static public int userId { get; set; }
    static public void currentuser(Users user )
    {
        
            name = user.UserName;
            pass = user.PassWord;
            RemmemberMe = true;
            userId = user.UserID;
            personId = user.PersonID;
            


    }
   












}




