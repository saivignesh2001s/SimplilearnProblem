using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustInfoLogMethods
    {
        simplilearnprojectEntities context = null;
        public CustInfoLogMethods()
        {
            context = new simplilearnprojectEntities();
        }
        public List<CustLogInfo> GetCustLogInfos()
        {
            return context.CustLogInfoes.ToList();
        }
        public bool SaveCustLog(CustLogInfo t)
        {
            try
            {
                context.CustLogInfoes.Add(t);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
    public class UserInfomethods
    {
        simplilearnprojectEntities user = null;
        public UserInfomethods()
        {
            user = new simplilearnprojectEntities();
        }
        public UserInfo Checklogin(int kp,string p)
        {
            UserInfo k = null;
            foreach(var item in user.UserInfoes.ToList())
            {
                if( kp== item.UserId && p== item.Password_)
                {
                    k = item;
                }
            }
            return k;
        }
    }
}
