﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentAPI.Startup))]
namespace StudentAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
