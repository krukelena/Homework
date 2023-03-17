using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task4;

internal class Truck : Auto
{
    private bool _isThereTrailer;
    public bool IsThereTrailer
    {
        get => _isThereTrailer;
        set
        {
            _isThereTrailer = value;
            DefineLoadCapacity(LoadCapacity);
        }
    }
    public Truck(string marka, string name, int speed, int loadCapacity, bool isTherTrailer) : base(marka, name, speed)
    {
        IsThereTrailer = isTherTrailer;
        DefineLoadCapacity(LoadCapacity);
    }
    protected override void DefineLoadCapacity(int loadCapacity) =>
    LoadCapacity = IsThereTrailer ? 2 * loadCapacity : loadCapacity;

    public override void PrintInformation()
    {
        Console.WriteLine("Грузовой автомобиль: ");
        base.PrintInformation();
        Console.WriteLine($"Наличие прицепа: {IsThereTrailer}\n");
    }
}
