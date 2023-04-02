using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task4;
internal class Motorcycle : Auto
{

    private bool _isThereSidecar;
    public bool IsThereSidecar
    {
        get => _isThereSidecar;
        set
        {
            _isThereSidecar = value;
            DefineLoadCapacity(LoadCapacity);
        }
    }
    public Motorcycle(string marka, string number, int speed, int loadCapacity, bool isThereSidecar) :
       base(marka, number, speed)
    {
        _isThereSidecar = isThereSidecar;
        DefineLoadCapacity(loadCapacity);
    }

    protected override void DefineLoadCapacity(int loadCapacity) =>
        LoadCapacity = IsThereSidecar ? loadCapacity : 0;

    public override void PrintInformation()
    {
        Console.WriteLine("Грузовой автомобиль: ");
        base.PrintInformation();
        Console.WriteLine($"Наличие прицепа: {IsThereSidecar}\n");
    }
}

