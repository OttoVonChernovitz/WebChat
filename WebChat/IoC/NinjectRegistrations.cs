﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebChat.Interfaces;
using WebChat.Models;
using WebChat.Repositories;
using Ninject.Modules;

namespace WebChat.IoC
{
    public class NinjectRegistrations : NinjectModule
    {

        public override void Load()
        {
            Bind<IUnitOfWork>()
                .To<UnitOfWork>()
                .InSingletonScope();
            Bind(typeof(IBaseRepository<>))
                .To(typeof(BaseRepository<>));
            Bind<ApplicationDbContext>()
                .To<ApplicationDbContext>();
        }
    }
}