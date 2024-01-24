// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Persona juan = new Persona("Juan");
juan.Calularsalario();

class Persona
{
    string nombre
    { get; set; }
    int edad;
    float salario;

    public Persona(string nom) 
    {
        nombre = nom;
        salario = 1000;
    }

    public void Calularsalario()
    {
        Console.WriteLine($"el salario de {nombre} es: {salario}");
    }
}