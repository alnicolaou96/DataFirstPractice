using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhateverYouWantDB.Startup))]
namespace WhateverYouWantDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
