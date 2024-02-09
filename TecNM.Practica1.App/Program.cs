using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;

public static class Program{
    public static void Main(string[] args) {
        float weight = 0;

        System.Console.WriteLine("Por favor, introduce tu peso");
        Single.TryParse(System.Console.ReadLine(), out weight);

        var person = new Person{Weigth = weight};

        var service = new MarteServices();
        var manager =  new MarteManager(service);

        Marte marte = manager.GetMarte(person);

         System.Console.WriteLine($"Tu peso de:  {weight}kg en la tierra es equivalente a: {marte.PesoMarte}kg en marte");
    }
}
