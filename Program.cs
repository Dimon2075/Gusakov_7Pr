using System;
using System.Collections.Generic;

namespace ConsoleApp_FirstApp
{
    /// <summary>
    /// Основная программа, которая запускается при запуске приложения.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный входной метод программы.
        /// </summary>
        /// <param name="args">Массив строковых аргументов командной строки.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Galaxy News!");
            IterateThroughList();
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для итерации по списку галактик и вывода информации о них.
        /// </summary>
        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name="Tadpole", MegaLightYears=400, GalaxyType=new GType('S')},
                new Galaxy() { Name="Pinwheel", MegaLightYears=25, GalaxyType=new GType('S')},
                new Galaxy() { Name="Cartwheel", MegaLightYears=500, GalaxyType=new GType('L')},
                new Galaxy() { Name="Small Magellanic Cloud", MegaLightYears=.2, GalaxyType=new GType('I')},
                new Galaxy() { Name="Andromeda", MegaLightYears=3, GalaxyType=new GType('S')},
                new Galaxy() { Name="Maffei 1", MegaLightYears=11, GalaxyType=new GType('E')}
            };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType.MyGType);
            }

            // Ожидаемый вывод:
            //  Tadpole  400,  Spiral
            //  Pinwheel  25,  Spiral
            //  Cartwheel, 500,  Lenticular
            //  Small Magellanic Cloud .2,  Irregular
            //  Andromeda  3,  Spiral
            //  Maffei 1,  11,  Elliptical
        }
    }

    /// <summary>
    /// Класс, представляющий галактику.
    /// </summary>
    public class Galaxy
    {
        /// <summary>
        /// Название галактики.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Расстояние до галактики в миллионах световых лет.
        /// </summary>
        public double MegaLightYears { get; set; }

        /// <summary>
        /// Тип галактики.
        /// </summary>
        public GType GalaxyType { get; set; }
    }

    /// <summary>
    /// Класс, представляющий тип галактики.
    /// </summary>
    public class GType
    {
        /// <summary>
        /// Создает новый тип галактики на основе символьного кода.
        /// </summary>
        /// <param name="type">Символьный код типа: 'S' (спираль), 'E' (эллиптическая), 'I' (неправильная), 'L' (ланцетная).</param>
        public GType(char type)
        {
            switch (type)
            {
                case 'S':
                    MyGType = Type.Spiral;
                    break;
                case 'E':
                    MyGType = Type.Elliptical;
                    break;
                case 'I':
                    MyGType = Type.Irregular;
                    break;
                case 'L':
                    MyGType = Type.Lenticular;
                    break;
                default:
                    throw new ArgumentException("Неверный код типа галактики");
            }
        }

        /// <summary>
        /// Свойство, хранящее тип галактики.
        /// </summary>
        public object MyGType { get; set; }

        /// <summary>
        /// Перечисление, определяющее возможные типы галактик.
        /// </summary>
        private enum Type { Spiral, Elliptical, Irregular, Lenticular }
    }
}