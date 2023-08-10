// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random numAleatorio = new Random();

int valorInteiro = numAleatorio.Next(1,10);

int numeroSugeridoPeloUsuario = Convert.ToInt32(Console.ReadLine());
if (valorInteiro==numeroSugeridoPeloUsuario){
    Console.WriteLine("Parabéns, você acertou o número");
}
else if (numeroSugeridoPeloUsuario >10){
    Console.WriteLine("Perdeu! Os números só vão até 10");
}
     /* Console.WriteLine("Você errou!, Eu pensei no número:" + valorInteiro); */