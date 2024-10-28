using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Autofac;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Forms;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;

namespace PIM_IV_Forms
{
    static class Program
    {
        private const string ConnectionString = @"Server=RTHEODORO\LOCALHOST;Database=PIM_IV;user='user';password='174201';TrustServerCertificate=True;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.Register( _ => new SqlConnection(ConnectionString))
                .As<IDbConnection>().InstancePerLifetimeScope();
            builder.RegisterType<ClienteFisicoRepository>().As<IRepository<ClienteFisico>>();
            builder.RegisterType<FuncionarioRepository>().As<IRepository<Funcionario>>();
            builder.RegisterType<ClienteFisicoController>();
            builder.RegisterType<FuncionarioController>();
            builder.RegisterType<MainForm>();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var scope = container.BeginLifetimeScope())
            {
                var form = scope.Resolve<MainForm>();
                Application.Run(form);
            }
        }
    }
}