﻿using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePix;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//new ByteBankAtendimento().AtendimentoCliente();

#region Nivel de Visibilidade
//public class Estagiario : Funcionario
//{
//    public Estagiario(double salario, string cpf) : base(salario, cpf)
//    {
//    }

//    public override void AumentarSalario()
//    {
//        throw new NotImplementedException();
//    }

//    protected override double getBonificacao()
//    {
//        throw new NotImplementedException();
//    }
//}
#endregion

Console.WriteLine("Gera uma Chave PIX:");
Console.WriteLine(GeradorPix.GetChavePix());

Console.WriteLine("\nGera uma Listagem de Chaves PIX:");
var listaDeChaves = GeradorPix.GetChavesPix(10);
foreach (var chave in listaDeChaves)
{
    Console.WriteLine(chave);
}
