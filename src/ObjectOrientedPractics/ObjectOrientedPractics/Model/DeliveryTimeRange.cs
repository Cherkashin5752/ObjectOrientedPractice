namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит массив допустимых значений для времени доставки.
    /// </summary>
    internal static class DeliveryTimeRange
    {
        /// <summary>
        /// Массив всех предоставляемых времён для доставки
        /// </summary>
        public static readonly string[] Values ={
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00" 
        };
    }
}