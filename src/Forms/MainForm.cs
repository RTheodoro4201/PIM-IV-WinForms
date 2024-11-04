﻿using System;
using System.Windows.Forms;
using PIM_IV_Forms.Controllers;
using PIM_IV_Forms.Forms.Clientes_Fisicos;
using PIM_IV_Forms.Forms.Fornecedores;
using PIM_IV_Forms.Forms.Funcionarios;

namespace PIM_IV_Forms.Forms;

public partial class MainForm : Form
{
    private readonly ClienteFisicoController _clienteFisicoController;
    private readonly FuncionarioController _funcionarioController;
    private readonly FornecedorController _fornecedorController;

    public MainForm(ClienteFisicoController clienteFisicoController, FuncionarioController funcionarioController, FornecedorController fornecedorController)
    {
        InitializeComponent();
        _clienteFisicoController = clienteFisicoController;
        _funcionarioController = funcionarioController;
        _fornecedorController = fornecedorController;
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void btnClienteFisico_Click(object sender, EventArgs e)
    {
        if (_clienteFisicoController != null)
        {
            var clienteFisicoForm = new ClienteFisicoForm(_clienteFisicoController);
            clienteFisicoForm.Show();
        }
    }

    private void btnFuncionario_Click(object sender, EventArgs e)
    {
        if (_funcionarioController != null)
        {
            var funcionarioForm = new FuncionarioForm(_funcionarioController);
            funcionarioForm.Show();
        }
    }

    /*
    private void btnFornecedor_Click(object sender, EventArgs e)
    {
        if (_fornecedorController != null)
        {
            var fornecedorForm = new FornecedorForm(_fornecedorController);
            fornecedorForm.Show();
        }
    }
    */

    private void btnFornecedorFisico_Click(object sender, EventArgs e)
    {
        if (_fornecedorController != null)
        {
            var fornecedorForm = new FornecedorForm(_fornecedorController, "Físico");
            fornecedorForm.Show();
        }
    }

    private void btnFornecedorJurídico_Click(object sender, EventArgs e)
    {
        if (_fornecedorController != null)
        {
            var fornecedorForm = new FornecedorForm(_fornecedorController, "Jurídico");
            fornecedorForm.Show();
        }
    }

    private void btnFornecedor_Click(object sender, EventArgs e)
    {
        if (_fornecedorController != null)
        {
            var fornecedorForm = new FornecedorForm(_fornecedorController, "Geral");
            fornecedorForm.Show();
        }
    }
}