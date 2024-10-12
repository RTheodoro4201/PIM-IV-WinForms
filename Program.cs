using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Forms;
using PIM_IV_Forms.Forms.Panels;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;

namespace PIM_IV_Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = @"Server=RTHEODORO\LOCALHOST;Database=PIM_IV;user='user';password='174201';TrustServerCertificate=True;";
            var builder = new ContainerBuilder();
            builder.Register( sp => new SqlConnection(connectionString))
                .As<IDbConnection>().InstancePerLifetimeScope();
            builder.RegisterType<ClienteRepository>().As<IRepository<Cliente>>();
            builder.RegisterType<FuncionarioRepository>().As<IRepository<Funcionario>>();
            builder.RegisterType<ClienteController>();
            builder.RegisterType<FuncionarioController>();
            builder.RegisterType<CadastroClienteFisicoForm>();
            builder.RegisterType<ListaClienteForm>();
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