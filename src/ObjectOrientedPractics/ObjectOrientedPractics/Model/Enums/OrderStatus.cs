namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Перечисление статуса заказа
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly, 
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
