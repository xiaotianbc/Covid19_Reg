﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Covid19_Reg.Models;
namespace Covid19_Reg.Services
{
    class DailyCheckinService
    {
        public static void Create(DailyCheckin dailyCheckin)
        {
            using (var db=new Covid19_RegContext())
            {
                db.DailyCheckins.Add(dailyCheckin);
                db.SaveChanges();
            }
        }
    }
}