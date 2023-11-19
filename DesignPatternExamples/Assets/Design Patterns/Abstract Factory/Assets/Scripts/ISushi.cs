using UnityEngine;

namespace AbstractFactory
{
    public interface ISushi
    {
        void Eat();
        float SatietyAmount { get; }
        IAbstractFactory Factory { get; set; }
    }
}