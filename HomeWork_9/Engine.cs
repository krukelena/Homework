using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{   /// <summary>
    /// Создать иерархию наследования для двигателей (абстрактный, дизельный, бензиновый, електро). 
    /// </summary>
    public abstract class Engine
    {
        public abstract string GetEngineType();
    }
}
