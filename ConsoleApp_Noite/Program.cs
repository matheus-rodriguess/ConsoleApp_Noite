﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp_Noite;
using ConsoleApp_Noite.Heranca;

Produto p1 = new Produto(1,10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litrão");

Console.WriteLine(p1.getDescricao() + " " + p1.getId() + " " + p1.getValor());

Endereco endereco = new Endereco(
    "Rua Mario Miziara",
    "91",
    "Sobral",
    "15906304",
    "Taquaritinga",
    "SP");

Cliente c1 = new Cliente(1, "Gabriele", "991340447", endereco);
Cliente c2 = new Cliente(2, "Gabriela", "991340447", endereco);
Cliente c3 = new Cliente(3, "Ryan", "991340447", endereco);
Cliente c4 = new Cliente(4, "Fernanda", "991340447", endereco);
Cliente c5 = new Cliente(5, "Giovanni", "991340447", endereco);

Console.WriteLine(c2.getEndereco().getRua()+" "+c2.getEndereco().getNumero());

c2.getEndereco().setNumero("135");

Console.WriteLine(c2.getEndereco().getNumero());

Endereco endereco2 = new Endereco(
    "Rua João Gurtler",
    "45",
    "Monte Belo",
    "14840000",
    "Guariba-SP",
    "SP");
Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());
c2.setEndereco(endereco2);
Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());


Carro gol = new Carro();

gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssentos = 5;


Bike caloi = new Bike();
caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;

gol.fabricante = "VW";
gol.cintoSegurança = true;
gol.arCondicionado = false;

Carro Saveiro = new Carro();
Carro Palio = new Carro();
Carro Uno = new Carro();

Saveiro.fabricante = "VW";
Palio.fabricante = "Fiat";
Uno.fabricante = "Fiat";


Bike speed = new Bike();
speed.temMotor = false;
speed.numeroPortas = 0;

//Faça uma ação chamada ExibirDados e mostre as informações na tela pelo Console.Writeline
Console.WriteLine(speed.ExibirDados());
Console.WriteLine(gol.ExibirDados());

List<Carro> listaCarros = new List<Carro>();
listaCarros.Add(gol);
listaCarros.Add(Palio);
listaCarros.Add(Uno);
listaCarros.Add(Saveiro);

Console.WriteLine(listaCarros[0].fabricante);
listaCarros.Remove(Palio);

for(int i = 0; i < listaCarros.Count; i++)
{
    Console.WriteLine(listaCarros[i].ExibirDados());
}
foreach(var item in listaCarros)
{
    Console.WriteLine(item.ExibirMarca());
}

//Imprima na tela todos os clientes desse contexto;
//Dica crie uma lista para eles
//Crie uma lista com 560 produtos e imprima na tela
//Crie uma lista que aceite qualquer tipo de veiculo e imprima na tela

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);
listaCliente.Add(c5);
    

for(int i = 0;i < listaCliente.Count; i++)
{
    Console.WriteLine(listaCliente[i].DadosCliente());
}

List<Produto> listaProduto = new List<Produto>();
for(int i = 1; i <= 10; i++)
{
    Produto p = new Produto(i, i * 2 + 2, "Descrição Produto: " + i);
    listaProduto.Add(p);
    
        
}





