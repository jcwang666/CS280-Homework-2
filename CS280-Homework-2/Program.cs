using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Homework_1._2;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            Console.WriteLine("請輸入一隻Pokemon:");

            //=========NationalNo
            Console.Write("NationalNo:");
            try
            {
                pokemon.NationalNo = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("NationalNo輸入錯誤");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            //=========Name
            Console.Write("Name:");
            try
            {
                pokemon.Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Name輸入錯誤");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            //=========Height
            Console.Write("Height:");
            try
            {
                pokemon.Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Height輸入錯誤");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            //=========Weight
            Console.Write("Weight:");
            try
            {
                pokemon.Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Weight輸入錯誤");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            //=========Category
            Console.Write("Category:");
            try
            {
                pokemon.Category = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Category輸入錯誤");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            //=========Abilities
            Console.Write("Abilities:");
            try
            {
                pokemon.Abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Abilities輸入錯誤");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            //=========Gender
            Console.Write("Gender:");
            try
            {
                pokemon.Gender = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gender輸入錯誤");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            Console.WriteLine("Height:");
            Console.WriteLine("Weight:");
            Console.WriteLine("Category:");
            Console.WriteLine("Abilities:");
            Console.WriteLine("Gender:");

            //pokemon.Height = 2.0f;
            //pokemon.Weight = 12.7f;
            //pokemon.Category = "Lizard";
            //pokemon.Abilities = "Blaze";
            //pokemon.Gender = "M";

            Console.WriteLine("以下為輸入的Pokemon資訊：\n編號：{0}\n名稱：{1}\n高度：{2}\n重量：{3}\n能力：{4}\n分類：{5}\n性別：{6}", pokemon.NationalNo, pokemon.Name, pokemon.Height, pokemon.Weight, pokemon.Abilities, pokemon.Category, pokemon.Gender);
        }
    }
}