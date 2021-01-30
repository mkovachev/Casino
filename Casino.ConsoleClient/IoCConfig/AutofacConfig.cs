using Autofac;
using Casino.Commands;
using Casino.Commands.Helpers;
using Casino.Commands.Helpers.Interfaces;
using Casino.Engine;
using Casino.Factories;
using System.Reflection;

namespace Casino.ConsoleClient.IoCConfig
{
    public sealed class AutofacConfig : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var currentAssembly = Assembly.Load("Casino");

            builder.RegisterAssemblyTypes(currentAssembly)
                   .AsImplementedInterfaces();

            builder.RegisterType<SlotFactory>().As<ISlotFactory>().SingleInstance();
            builder.RegisterType<SymbolFactory>().As<ISymbolFactory>().SingleInstance();

            builder.RegisterType<PlaySlotCommand>().As<IPlaySlotCommand>();

            builder.RegisterType<CommandManager>().As<ICommandManager>().SingleInstance();
            builder.RegisterType<BalanceManager>().As<IBalanceManager>().SingleInstance();
            builder.RegisterType<SymbolManager>().As<ISymbolManager>().SingleInstance();

            builder.RegisterType<CasinoEngine>().As<IEngine>().SingleInstance();

        }
    }
}
