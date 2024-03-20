using System;
using Herois.Interfaces;

namespace Herois.Personagens
{
    class Estranho : Personagem, IClasseFisica, IClasseMagica
    {
        // Classe Estranho é uma subclasse que herda de Personagem e implementa as interfaces IClasseFisica e IClasseMagica

        public override void UsarHabilidade()
        {
            // Método UsarHabilidade() sobrescrito da classe Personagem
            // Este método é chamado quando um objeto Estranho usa sua habilidade

            AtaqueFisico(); // Chamada ao método específico de Estranho para realizar um ataque físico
            LancarMagia(); // Chamada ao método específico de Estranho para lançar uma magia
        }

        public void AtaqueFisico()
        {
            // Método específico de Estranho para realizar um ataque físico
            Console.WriteLine("Realizando ataque físico.");
        }

        public void LancarMagia()
        {
            // Método específico de Estranho para lançar uma magia
            Console.WriteLine("Lançando magia.");
        }
    }
}
