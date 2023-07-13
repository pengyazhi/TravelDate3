using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate.Models
{
    public class FavoriteCheck
    {
        public static TraveldateEntities dbContext = new TraveldateEntities();

        public static bool CheckFavo(Button btn, int PID)
        {
            //判斷如果已經在最愛 btnfavo為粉紅色 未加最愛為灰色
            var qfavo = (from fav in dbContext.Favorites
                    where (fav.MemberID == Login.MemberID) &&
                    (fav.ProductID == PID)
                    select fav).Any();
            try
            {
                if (qfavo)
                {
                    btn.Image = Properties.Resources.heart;
                }
                else
                {
                    btn.Image = Properties.Resources.heart_g;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                qfavo = false;
            }
            return qfavo;
        }

        public static void AddRemoveFavo(bool favo, int PID)
        {
            try
            {
                if (favo)
                {
                    var d = (from fav in dbContext.Favorites
                             where (fav.MemberID == Login.MemberID) &&
                             (fav.ProductID == PID)
                             select fav).FirstOrDefault();
                    if (d == null) return;
                    dbContext.Favorites.Remove(d);
                    dbContext.SaveChanges();
                }
                else
                {
                    Favorite fav = new Favorite { MemberID = Login.MemberID, ProductID = PID };
                    dbContext.Favorites.Add(fav);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
