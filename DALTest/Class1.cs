﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DALTest
{
    [TestFixture]
    public class Custinfologtest
    {
        simplilearnprojectEntities context = new simplilearnprojectEntities();
       
        [TestCase]
        public void GetallloginfoesTest()
        {
            bool k = true;
            List<CustLogInfo> m= context.CustLogInfoes.ToList();
            if (m != null)
            {
                k = true;
            }
            else
            {
                k = false;

            }
            Assert.IsTrue(k);
        }
        [TestCase]
        public void SaveCustLogInfoTest()
        {
            bool k = true;
            try
            {
                
                context.SaveChanges();
                k=true;

            }
            catch
            {
                k=false;
            }
            Assert.IsTrue(k);
        }

    }
    [TestFixture]
    public class Userinfologtest
    {
        simplilearnprojectEntities context = null;
        public Userinfologtest()
        {
            context = new simplilearnprojectEntities();
        }
        [TestCase(2,"stuart@123",ExpectedResult =true)]
        public bool Logintest(object ans1,object ans2)
        {
            bool k = false;
            foreach(var item in context.UserInfoes.ToList())
            {
                if(item.UserId==(int)ans1 && item.Password_ == ans2.ToString())
                {
                    k = true;
                }
            }
            return k;
        }
    }
}
