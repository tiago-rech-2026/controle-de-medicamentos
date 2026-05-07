using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloPacientes;

namespace ControleDeMedicamentos.ConsoleApp.Utilidades;

public class TelaPrincipal
{
  private readonly IRepositorio<Paciente> repositorioPaciente;

  public TelaPrincipal(IRepositorio<Paciente> repositorioPaciente)
  {
    this.repositorioPaciente = repositorioPaciente;
  }

  public ITelaOpcoes? ApresentarMenuOpcoesPrincipal()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Controle de Medicamentos");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Gerenciar Pacientes");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

        if (opcaoMenuPrincipal == "1")
            return new TelaPaciente(repositorioPaciente);              

        return null;
    }
}