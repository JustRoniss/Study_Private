// See https://aka.ms/new-console-template for more information


/*
Herança é a capacidade de um objeto herdar comportamentos e atributos de outro objeto
		
Encapsulamento tem como premissa proteger atributos/propriedades de uma classe fazendo com que as alterações sejam feitas apenas por métodos definidos na própria classes

Abstração define um contrato que pode não possuir nenhum tipo de inteligência, porém se a classe que implementa o contrato tem o dever de implementar o que deve ser feito

Polimorfismo fornece a capacidade de herdar métodos da classe pai, e sobreescrever seu comportamento
	
	
*/

//namespace Cadastro;

using System.Reflection;
using System.Security.AccessControl;
using Cadastro;
using ClasseAbstrata;
using Heranca;

// Aqui temos um exemplo de encapsulamento, afinal as propriedades ID e Descricao são privadas, e somente a própria classe tem um metodo que pode alterar estes valores. Sendo assim, estamos usando modificadores de acesso para gaarantir a integridade das propriedades ID e Descricao 
namespace Cadastro
{
	public class Produto
	{
		public Produto(int estoque) // Aqui criamos o construtor da classe Produto, que recebe como parametro um valor inteiro, que é justamente o valor que será setado na propriedade da classe readonly
		{
			Estoque = estoque;
		}
		private int Id = 1;
		private string Descricao { get; set; }

		public readonly int Estoque;  //temos essa propriedade somente leitura, sendo assim, somente o construtor da classe tem permissão de altera-la

		public void SetDescricao(string descricao)
		{
			Descricao = descricao;
		}

		public void SetId(int id)
		{
			Id = id;
		}

		public int GetId()
		{
			return Id;
		}

		public string GetDescricao()
		{
			return Descricao;
		}
	}
}


namespace Heranca
{
	public class Pessoa
	{
		public string PrimeiroNome { get; set; }
		public string SegundoNome { get; set; }
		public string CPF { get; set; }
	}

	public class PessoaDeficiente : Pessoa
	{
		public string DescricaoDoenca { get; set; }
	}
}


namespace ClasseSelada
{
	public sealed class Configuracao //utilizando a palavra reservada sealed, estamos criando uma classe que não permite ser herdada. Ou seja, eu não posso criar uma outra classe herdando da classe Configuracao
	{
		public string cmd = "ipconfig";
	}
	
	// public class TesteSealed : Configuracao  - Isto não é permitido, afinal, Configuracao é uma classe selada
}

namespace ClasseAbstrata
{
	public abstract class Carro // Uma classe abstrata não pode ser instanciada. Ela serve para ser a classe "pai" de outras classes, por meio da Herança ou Interfaces;
	{
		public string Modelo { get; set; }
		public int Ano { get; set; }

		public abstract int GetQuantidadesDePortas(); // Estamos criando um metodo abstrato dentro da classe abstrata Carro. Ao fazer isto, estamos forçando que as classes que pretendem herdar da classe Carro, implementem o metodo GetQuantidadeDePortas
	}

	public class CarroEletrico : Carro
	{
		public int ConsumoEletrico { get; set; }

		public override int GetQuantidadesDePortas() // Aqui estamos utilizando a palavra reservada override, pois precisamos sobreescrever o metodo GetQuantidadeDePortas, que é um metodo abstrato incompleto, sendo assim, somos forçados a implementar esse metodo nas classes que herdam da classe abstrata Carro
		{
			return 4;
		}
	}

	public class CarroMotorConvencional : Carro
	{
		public int ConsumoCombustivel { get; set; }

		public override int GetQuantidadesDePortas()
		{
			return 2;
		}
	}
}



namespace OrientacaoObjeto
{
	public class Program
	{
		static void Main(string[] args)
		{
			var produto = new Cadastro.Produto(2);  //aqui estamos chamando um outro namespace, por isto usamos Cadastro.Produto
			produto.SetId(1);
			produto.SetDescricao("Computador montado");
			Console.WriteLine("Id do produto: " + produto.GetId() + " Descrição: " + produto.GetDescricao());


			var produto2 = new Cadastro.Produto(5);
			produto2.SetId(2);
			produto2.SetDescricao("Mouse");
			var estoque_produto2 = produto2.Estoque;
			
			Console.WriteLine("Id do produto: " + produto2.GetId() + " Descrição: " + produto2.GetDescricao()+ " Estoque: " + estoque_produto2);
			
			//------------------------------------------------------------------------------------------------------------------------------------------------------

			var pessoa1 = new Pessoa();
			pessoa1.PrimeiroNome = "Ronaldo";
			pessoa1.SegundoNome = "Luiz";
			pessoa1.CPF = "01010101";
			
			Console.WriteLine($"Pessoa. Nome: {pessoa1.PrimeiroNome} {pessoa1.SegundoNome}. CPF = {pessoa1.CPF}");

			var pessoa2 = new PessoaDeficiente();

			pessoa2.PrimeiroNome = "Rodrigo";
			pessoa2.SegundoNome = "Santos";
			pessoa2.CPF = "02020202";
			pessoa2.DescricaoDoenca = "Cadeirante";
			
			Console.WriteLine($"Pessoa. Nome: {pessoa2.PrimeiroNome} {pessoa2.SegundoNome}. CPF = {pessoa2.CPF}. Descrição deficiencia = {pessoa2.DescricaoDoenca}");

			// var carro1 = new Carro(); - Não podemos instanciar um novo carro a partir da classe Carro, porque Carro é uma classe abstrata. Classes abstratas não podem ser instanciadas pois servem para ser um tipo de "modelo" a ser herdado por outras classes;

			var carro1 = new CarroEletrico();
			carro1.Modelo = "Tesla";
			carro1.Ano = 2022;
			Console.WriteLine($"Carro - Modelo: {carro1.Modelo} Ano: {carro1.Ano}. Quantidade de portas: {carro1.GetQuantidadesDePortas()}");



		}
	}
}