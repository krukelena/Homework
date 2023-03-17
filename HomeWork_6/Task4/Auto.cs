using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task4;

internal abstract class Auto
{
    private protected int _loadCapacity;
    public string Marka { get; set; }
    public string Number { get; set; }
    public int Speed { get; set; }
    public int LoadCapacity { get; set; }

    protected Auto(string marka, string number, int speed)
    {
        Marka= marka;
        Number= number;
        Speed= speed;
    }
    public virtual void PrintInformation() => Console.WriteLine($"Марка: {Marka}\nНомер: {Number}\nСкорость: {Speed}\nГрузоподьемность: {LoadCapacity}");
    protected virtual void DefineLoadCapacity(int loadCapacity) =>LoadCapacity= loadCapacity;

}
