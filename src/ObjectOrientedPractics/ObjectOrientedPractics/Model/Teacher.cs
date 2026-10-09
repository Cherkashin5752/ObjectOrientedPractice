using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит имя и опыт преподавателя
    /// </summary>
    internal class Teacher
    {
        /// <summary>
        /// Возвращает и задаёт имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт опыт
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Teacher">
        /// </summary>
        /// <param name="name">Имя преподавателя</param>
        /// <param name="experience">Опыт преподавателя</param>
        public Teacher(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }
    }
}
