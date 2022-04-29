﻿using Eagles.LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eagles.LMS.BLL
{
    public class UnitOfWork
    {


        private readonly EmcNewsContext ctx = new EmcNewsContext();
        public UserManager UserManager { get { return new UserManager(ctx); } }

        public UserForLoginReposatory UserForLoginReposatory { get { return new UserForLoginReposatory(ctx); } }

        public GroupsManager GroupsManager { get { return new GroupsManager(ctx); } }


        public GroupPriviageManager GroupPriviageManager { get { return new GroupPriviageManager(ctx); } }


        public PrivilageManager PrivilageManager { get { return new PrivilageManager(ctx); } }
        public PrivilageRouteManager PrivilageRouteManager { get { return new PrivilageRouteManager(ctx); } }








    }
}