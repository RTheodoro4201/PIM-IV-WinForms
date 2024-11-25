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

        builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
        builder.RegisterType<FuncionarioRepository>().As<IRepository<Funcionario>>();
        builder.RegisterType<FornecedorRepository>().As<IFornecedorRepository>();
        builder.RegisterType<CulturaRepository>().As<IRepository<Cultura>>();
        builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();
        builder.RegisterType<InsumoRepository>().As<IInsumoRepository>();
        builder.RegisterType<CompraRepository>().As<IRepository<Compra>>();
        builder.RegisterType<VendaRepository>().As<IRepository<Venda>>();
        builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();

        builder.RegisterType<ClienteController>();
        builder.RegisterType<FuncionarioController>();
        builder.RegisterType<FornecedorController>();
        builder.RegisterType<CulturaController>();
        builder.RegisterType<ProdutoController>();
        builder.RegisterType<InsumoController>();
        builder.RegisterType<CompraController>();
        builder.RegisterType<VendaController>();
        builder.RegisterType<UsuarioController>();
        builder.RegisterType<LoginForm>();

        var container = builder.Build();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        using var scope = container.BeginLifetimeScope();
        var form = scope.Resolve<LoginForm>();
        Application.Run(form);
    }
}