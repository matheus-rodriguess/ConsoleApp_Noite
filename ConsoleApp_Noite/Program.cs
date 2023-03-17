// See https://aka.ms/new-console-template for more information
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

Console.WriteLine(speed.ExibirDados());
Console.WriteLine(gol.ExibirDados());

 

//Faça uma ação chamada ExibirDados e mostre as informações na tela pelo Console.Writeline




