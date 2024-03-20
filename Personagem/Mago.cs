using System;
using Herois.Interfaces; // Importa o namespace onde estão as interfaces utilizadas

namespace Herois.Personagens
{
    // Classe Mago é uma subclasse que herda de Personagem e implementa a interface IClasseMagica
    class Mago : Personagem, IClasseMagica
    {
        // Método UsarHabilidade() sobrescrito da classe Personagem
        // Este método é chamado quando um objeto Mago usa sua habilidade
        public override void UsarHabilidade()
        {
            LancarMagia(); // Chamada ao método específico de Mago para lançar uma magia
        }

        // Método específico de Mago para lançar uma magia
        public void LancarMagia()
        {
            Console.WriteLine("Lançando magia.");
        }
    }
}
