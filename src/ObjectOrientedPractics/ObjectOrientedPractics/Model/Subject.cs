using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит название, количество часов и преподавателя дисциплины
    /// </summary>
    internal class Subject
    {
        /// <summary>
        /// Возвращает и задаёт название дисциплины
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и щадаёт количество часов дисциплины
        /// </summary>
        public int FullHours { get; set; }

        /// <summary>
        /// Возвращает и задаёт преподпвателя ддисциплины
        /// </summary>
        public Teacher Teacher { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Subject">
        /// </summary>
        /// <param name="title"></param>
        /// <param name="fullHours"></param>
        /// <param name="teacher"></param>
        public Subject(string title, int fullHours, string name, int experience)
        {
            Title = title;
            FullHours = fullHours;
            Teacher = new Teacher(name, experience);
        }
    }
}