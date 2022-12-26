// See https://aka.ms/new-console-template for more information


/*
Herança é a capacidade de um objeto herdar comportamentos e atributos de outro objeto
		
Encapsulamento tem como premissa proteger atributos/propriedades de uma classe fazendo com que as alterações sejam feitas apenas por métodos definidos na própria classes

Abstração define um contrato que pode não possuir nenhum tipo de inteligência, porém se a classe que implementa o contrato tem o dever de implementar o que deve ser feito

Polimorfismo fornece a capacidade de herdar métodos da classe pai, e sobreescrever seu comportamento
	
	
*/

//namespace Cadastro;

using Cadastro;

// Aqui temos um exemplo de encapsulamento, afinal as propriedades ID e Descricao são privadas, é somente a própria classe tem um metodo que pode alterar estes valores. Sendo assim, estamos usando modificadores de acesso para gaarantir a integridade das propriedades ID e Descricao 
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


		}
	}
}