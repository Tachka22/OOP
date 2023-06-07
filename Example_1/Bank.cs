
namespace Example_1;
internal class Bank
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="allMoney">кол-во средств в банке</param>
    public Bank(decimal allMoney)
    {
        if (allMoney <= 0) throw new Exception("Сумма не должна быть отрицательна!");
        else AllMoney = allMoney;
    }

    /// <summary>
    /// Всего денег в банке
    /// </summary>
    public decimal AllMoney { get; private set; }

    /// <summary>
    /// Получить деньги из банка
    /// </summary>
    /// <param name="money">нужная сумма</param>
    /// <returns>сумма</returns>
    public decimal GetMyMoney(decimal money)
    {
        if (money < AllMoney)
        {
            AllMoney -= money;
            return money;
        }
        else return 0;
    }
    
}