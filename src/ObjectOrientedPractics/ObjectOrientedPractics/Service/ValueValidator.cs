namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Сервисный класс для осуществления валидации.
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Проверяет на то, не больше ли строка некоторого количества символов
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLength">Вверхняя граница</param>
        /// <param name="propertyName">Вызываемое свойство</param>
        /// <returns>Возвращает true, если строка короче maxLength</returns>
        /// <exception cref="ArgumentException">Ошибка, если строка длинее maxLength</exception>
        public static bool AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Length != 0 && value.Length <= maxLength)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException($"{propertyName} должен быть не больше {maxLength} символов");
                }
            }
            else
            {
                throw new NullReferenceException($"{propertyName} не должен быть пустым");
            }
        }

        /// <summary>
        /// Проверяет, что целочисленное число является положительным
        /// </summary>
        /// <param name="value">Проверяемое число</param>
        /// <param name="propetryName">Вызываемое свойство</param>
        /// <returns>Возвращает true, если число положительное</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не положительное</exception>
        public static bool ValueIsPositive(int value, string propertyName)
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"{propertyName} должен быть положительным");
            }
        }

        /// <summary>
        /// Проверяет, что целочисленное число находится в диапазоне от min до max
        /// </summary>
        /// <param name="value">Проверяемое число</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="propetryName">Вызываемое свойство</param>
        /// <returns>Возвращает true, если число находится в диапазоне</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не находится в диапазоне</exception>
        public static bool ValueInRange(double value, double min, double max, string propertyName)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"{propertyName} должен быть не меньше {min} и не больше {max}");
            }
        }
    }
}
