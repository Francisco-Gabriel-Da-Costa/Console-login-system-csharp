using System.Formats.Tar;
using System.Reflection.Metadata.Ecma335;
using System.Security.Authentication;

class Program
{
    static void Main()
    {
        string usuarioFinal = CriarNomeDeUsuario();
        
        Console.WriteLine(usuarioFinal);
        
        int idadeDoUsuario = ValidarIdade();
        
        Console.WriteLine(idadeDoUsuario);
        
        int senhaDoUsuario = criarSenha();
        
        Console.WriteLine(senhaDoUsuario);
        
        fazerLoginDoUsuario(usuarioFinal);

        fazerLoginDaSenha(senhaDoUsuario);
    }
    static string CriarNomeDeUsuario()
    {
        Console.WriteLine("Crie um nome de usuario ");
        string usuario = Console.ReadLine();
        if(string.IsNullOrWhiteSpace (usuario))
        {
            Console.WriteLine("Nome de usuario não foi criado por Caracter invalido ou Nome já existente");
            return "USUARIO_INVALIDO";
        }
        else
        {
            Console.WriteLine("Nome de usuario criado com sucesso!");
            return usuario;
        }

    }
    static int ValidarIdade()
    {
        int idade;
        Console.WriteLine("Qual é a sua idade?");
        int.TryParse(Console.ReadLine(), out idade);
        if( idade >= 18)
        {
            Console.WriteLine("Ok, Vamos avançar!");
            return idade;
        }
        else
        {
            Console.WriteLine($"{idade}não é o suficiente para prosseguir");
            return 0;
        }
    }
    static int criarSenha()
    {
        int senha;
        Console.WriteLine("Crie uma senha");
        if(int.TryParse(Console.ReadLine(),out senha))
        {
            Console.WriteLine("Senha criada com sucesso!");
            return senha;
        }
        else
        {
            Console.WriteLine("Caracter invalido, Senha não criada");
            return 0;
        }
    }
    static bool fazerLoginDoUsuario (string usuarioFinal)
    {
        int tentativasUsuarios = 3;
        Console.WriteLine("faça login do usuario agora");
        Console.WriteLine("usuario:");
        while(tentativasUsuarios >0)
        {
            string usuarioDigitado = Console.ReadLine();
            if(usuarioDigitado == usuarioFinal)
            {
               return true;
            }
            else
            {
                
                tentativasUsuarios --;
                Console.WriteLine($"voce tem mais {tentativasUsuarios} ");
            }
            }
            if (tentativasUsuarios == 0)
            {
                Console.WriteLine("SITEMA BLOQUEADO!");
            }
        return false;
    }
    static bool fazerLoginDaSenha (int senhaDoUsuario)
    {
        Console.WriteLine("Sennha:");
        int senhaDigitada;
        int tentativasSenha = 3;
        while(tentativasSenha > 0)
        {
            if(int.TryParse(Console.ReadLine(), out senhaDigitada))
            {
             Console.WriteLine("");   
            }
            if( senhaDoUsuario == senhaDigitada)
            {
                Console.WriteLine("Permitido, Seja bem vindo!");
                return true;
            }
            else
            {
                tentativasSenha --;
                Console.WriteLine("Erro");
                Console.WriteLine($"Você tem apenas { tentativasSenha} ");
            }
        }
        if (tentativasSenha == 0)
        {
            Console.WriteLine("SISTEMA BLOQUEADO!");
        }
        return false;
    } 
}