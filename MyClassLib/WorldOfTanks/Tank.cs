using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        public string Name { get; set; }
        public int Weapon { get; set; }
        public int ArmourLevel { get; set; }
        public int Manoeuvrability { get; set; }

        #region Конструкторы
        public Tank() {}
        public Tank(string name, int weapon, int armourLevel, int manoeuvrability)
        {
            Name = name;
            Weapon = weapon; ArmourLevel = armourLevel; Manoeuvrability = manoeuvrability;
        }
        #endregion

        #region Вывод на консоль
        public static void Show(Tank tank_1, Tank tank_2)
        {
            Console.WriteLine("Название танка:\t\t\t" + tank_1.Name + "\t\t" + tank_2.Name +
                "\nУровень боекомплекта:\t\t" + tank_1.Weapon + "\t\t" + tank_2.Weapon +
                "\nУровень брони:\t\t\t" + tank_1.ArmourLevel + "\t\t" + tank_2.ArmourLevel +
                "\nУровень маневренности:\t\t" + tank_1.Manoeuvrability + "\t\t" + tank_2.Manoeuvrability);
        }
        #endregion

        #region Перегрузка оператора
        public static bool operator ^(Tank tank_1, Tank tank_2)
        {
            int targetRatio = 2;
            int supremacyRatio = 0, identicalRatio = 0;

            if (tank_1.Weapon > tank_2.Weapon) supremacyRatio++;
            else if (tank_1.Weapon == tank_2.Weapon) identicalRatio++;
            if (tank_1.ArmourLevel > tank_2.ArmourLevel) supremacyRatio++;
            else if (tank_1.ArmourLevel == tank_2.ArmourLevel) identicalRatio++;
            if (tank_1.Manoeuvrability > tank_2.Manoeuvrability) supremacyRatio++;
            else if (tank_1.Manoeuvrability == tank_2.Manoeuvrability) identicalRatio++;

            if (identicalRatio >= targetRatio || (identicalRatio == targetRatio - 1 && supremacyRatio == targetRatio - 1))
                throw new Exception("Победитель сражения: Неизвестен\n");

            return supremacyRatio >= targetRatio;
        }
        #endregion
    }
}
