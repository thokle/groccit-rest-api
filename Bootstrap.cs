using Nancy;
using Nancy.Bootstrapper;
using Nancy.Configuration;
using Nancy.Conventions;
using Nancy.TinyIoc;

namespace groccit
{
    
    public class Bootstrap: DefaultNancyBootstrapper
    {
        public override void Configure(INancyEnvironment environment)
        {
            base.Configure(environment);
            environment.Tracing(enabled: true, displayErrorTraces: true);
        }
        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            //  pipelines.BeforeRequest += (c) => { c.Request.Headers("",""); };
            //CORS Enable
            pipelines.AfterRequest += (ctx) =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                    .WithHeader("Access-Control-Allow-Methods", "POST, GET, DELETE, PUT, OPTIONS, PATCH")
                    .WithHeader("Access-Control-Allow-Headers",
                        "Origin, X-Requested-With, Content-Type, Accept, Authorization,ejerforhold, username, password ")
                    .WithHeader("Access-Control-Max-Age", "3600");
            };



            base.ApplicationStartup(container, pipelines);

        }




    }
}
