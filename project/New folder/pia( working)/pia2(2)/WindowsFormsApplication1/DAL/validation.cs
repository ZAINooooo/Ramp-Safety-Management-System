using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace piac_project
{
   public class validation
    {

       public static string chekName(string Name)
       {
           string _name = string.Empty;

           try
           {
              if (Name == "")
               {
                   throw new Exception("Name is reqired");
                   frmPersonalInfo f2 = new frmPersonalInfo();
                   f2.ShowDialog();
                   //_name = "Name is reqired";
               }
                  
               else
               {
                   _name = Name;
               }
           }
           catch (Exception exException)
           {
               MessageBox.Show(exException.Message);
           }
           return _name;
       }
      
       public static string chekpnr(string Pnr)
       {
           string Pr = string.Empty;
           try
           {
               if (Pnr == "")
               {
                   throw new Exception("P.N.R no is required");
               }

               else if (Pnr.Length < 5 && Pnr.Length > 0)
               {
                   throw new Exception("P.N.R no must contain 5 no");
               }
               else
               {
                   Pr = Pnr;
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
           return Pr;
       }

       public static string cheknic(string Nic)
       {
           string NIC = string.Empty;
           try
           {
               if (Nic == "")
               {
                   throw new Exception("N.I.C no is required");
               }


               else if (Nic.Length < 13 && Nic.Length > 0)
               {
                   throw new Exception("nic no must contain 13 no");
               }
               else
               {
                   NIC = Nic;
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }

           return NIC;
       }
   }
}
