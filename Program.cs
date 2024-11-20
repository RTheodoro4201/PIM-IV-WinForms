using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Autofac;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Forms;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;

namespace PIM_IV_Forms;

internal static class Program
{
    private const string ConnectionString =
        @"Server=RTHEODORO\LOCALHOST;Database=PIM_IV;user='user';password='174201';TrustServerCertificate=True;";

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        var builder = new ContainerBuilder();
        builder.Register(_ => new SqlConnection(ConnectionString))
            .As<IDbConnection>().InstancePerLifetimeScope();

        builder.RegisterType<ClienteFisicoRepository>().As<IRepository<ClienteFisico>>();
        builder.RegisterType<FuncionarioRepository>().As<IRepository<Funcionario>>();
        builder.RegisterType<FornecedorRepository>().As<IFornecedorRepository>();
        builder.RegisterType<CulturaRepository>().As<IRepository<Cultura>>();
        builder.RegisterType<ProdutoRepository>().As<IRepository<Produto>>();

        builder.RegisterType<ClienteFisicoController>();
        builder.RegisterType<FuncionarioController>();
        builder.RegisterType<FornecedorController>();
        builder.RegisterType<CulturaController>();
        builder.RegisterType<ProdutoController>();
        builder.RegisterType<MainForm>();

        var container = builder.Build();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        using var scope = container.BeginLifetimeScope();
        var form = scope.Resolve<MainForm>();
        Application.Run(form);
    }
}