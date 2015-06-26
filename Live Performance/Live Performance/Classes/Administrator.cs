using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    using System.Windows.Forms;

    class Administrator
    {
        DBBoot dbBoot = new DBBoot();
        DBMissie dbMissie = new DBMissie();
        DBMedewerker dbMedewerker = new DBMedewerker();
        DBLogin dbLogin = new DBLogin();
        DBWaarneming dbWaarneming = new DBWaarneming();

        public List<Boot> SelectAllBootsWithNoMission()
        {
            return dbBoot.SelectAllBoots();
        }

        public Boot Findclosestship(int X1, int Y1)
        {
            List<Boot> BootList = this.SelectAllBootsWithNoMission();
            double X2;
            double Y2;
            double distence;
            double closestDistence = -1;
            Boot ClosestBoot = null;


            if (BootList == null)
            {
                MessageBox.Show("Geen Boten gevonden");
            }
            else
            {
                foreach (Boot boot in BootList)
                {
                    X2 = Convert.ToDouble(boot.Location.X);
                    Y2 = Convert.ToDouble(boot.Location.Y);
                    distence = Math.Sqrt((Math.Pow((X2 - X1), 2.0)) + (Math.Pow((Y2 - Y1), 2.0)));

                    if (closestDistence == -1)
                    {
                        closestDistence = distence;
                        ClosestBoot = boot;
                    }
                    else
                    {
                        if (closestDistence >= distence)
                        {
                            closestDistence = distence;
                            ClosestBoot = boot;
                        }
                    }
                }
            }
            

            return ClosestBoot;
        }

        public List<Missie> SelectMissies()
        {
            return dbMissie.SelectAllMissies();
        }

        public bool AddMissie(Missie missie)
        {
            return dbMissie.AddMissie(missie);
        }
    }
}
