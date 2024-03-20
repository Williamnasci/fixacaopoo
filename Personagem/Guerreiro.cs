using System;
using Herois.Interfaces; // Importa o namespace onde estão as interfaces utilizadas

namespace Herois.Personagens
{
    // Classe Guerreiro é uma subclasse que herda de Personagem e implementa a interface IClasseFisica
    class Guerreiro : Personagem, IClasseFisica
    {
        // Método UsarHabilidade() sobrescrito da classe Personagem
        // Este método é chamado quando um objeto Guerreiro usa sua habilidade
        public override void UsarHabilidade()
        {
            AtaqueFisico(); // Chamada ao método específico de Guerreiro para realizar um ataque físico
        }

        // Método específico de Guerreiro para realizar um ataque físico
        public void AtaqueFisico()
        {
            Console.WriteLine("Realizando ataque físico.");
        }
    }
}
