using Autofac;
using Casino.ConsoleClient.IoCConfig;
using Casino.Engine;

namespace Casino.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacConfig());
            var container = builder.Build();

            var engine = container.Resolve<IEngine>();
            engine.Start();
        }
    }
}
