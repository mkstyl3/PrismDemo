using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismDemo
{
    public class Bootstrapper: UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //container.registertype(typeof(object), typeof(viewa), "viewa");
            //container.registertype(typeof(object), typeof(viewb), "viewb");

            Container.RegisterTypeForNavigation<ViewA>("ViewA");
            Container.RegisterTypeForNavigation<ViewB>("ViewB");

            // Maybe we need to write the class, but seems like we are just fine atm
            //
            //public static class UnityExtensions
            //{
            //    public static void RegisterTypeForNavigation<T>(this IUnityContainer container, string name)
            //    {
            //        container.RegisterType(typeof(object), typeof(T), name);
            //    }
            //}
        }
    }
}
