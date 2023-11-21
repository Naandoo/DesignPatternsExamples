using UnityEngine;

namespace AbstractFactory
{
    public interface ISushi
    {
        void Eat();
        float SatietyAmount { get; }
        AbstractFactory Factory { get; set; }
    }
}