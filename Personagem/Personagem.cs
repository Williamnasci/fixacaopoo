using System;

namespace Herois.Personagens
{
    // Classe Personagem é uma classe base para outros tipos de personagens
    class Personagem
    {
        // Método virtual UsarHabilidade()
        // Este método é chamado quando um objeto Personagem usa sua habilidade
        // Por padrão, imprime uma mensagem genérica, mas pode ser sobrescrito por subclasses
        public virtual void UsarHabilidade()
        {
            Console.WriteLine("Usando habilidade genérica.");
        }
    }
}
