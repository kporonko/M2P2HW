using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;
using SafariPark.Interfaces.Animals;
using SafariPark.Models.Animals;

namespace SafariPark
{
    internal class AnimalToStringService
    {
        /// <summary>
        /// Method that writes data about animal in the stringbuilder. Always is used with for loop.
        /// </summary>
        /// <param name="animals">Array that contains current animal.</param>
        /// <param name="i">Current iteration.</param>
        /// <param name="sb">Stringbuilder.</param>
        public static void AnimalToString(IAnimal[] animals, int i, ref StringBuilder sb)
        {
            if (animals[i] is Dog)
            {
                var dog = animals[i] as Dog;
                sb.Append($"Animal {i + 1}: Dog\nBreed: {dog.GetType().Name}\nNickname: {dog.NickName}\nAge: {dog.Age}\nDangerous? {dog.IsDangerous}\nMale? {dog.IsMale}\nWeight:{dog.Weight}\nHeight:{dog.Height}\n\n");
            }

            if (animals[i] is IFish)
            {
                var fish = animals[i] as Fish;
                sb.Append($"Animal {i + 1}: Fish\nBreed: {fish.GetType().Name}\nNickname: {fish.NickName}\nAge: {fish.Age}\nDangerous? {fish.IsDangerous}\nMale? {fish.IsMale}\nWeight:{fish.Weight}\nHeight:{fish.Height}\nPredator? {fish.IsPredator}\n\n");
            }

            if (animals[i] is IBird)
            {
                var bird = animals[i] as Bird;
                sb.Append($"Animal {i + 1}: Bird\nBreed: {bird.GetType().Name}\nNickname: {bird.NickName}\nAge: {bird.Age}\nDangerous? {bird.IsDangerous}\nMale? {bird.IsMale}\nWeight:{bird.Weight}\nHeight:{bird.Height}\n\n");
            }
        }
    }
}
