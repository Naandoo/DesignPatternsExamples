using System;
using System.Collections.Generic;
using UnityEngine;

public class AirportSpotsHandler : MonoBehaviour
{
    [SerializeField] private List<AvailableSpot<Bus>> _busSpots;
    [SerializeField] private List<AvailableSpot<Car>> _carSpots;
    [SerializeField] private List<AvailableSpot<Helicopter>> _helicopterSpots;
    [SerializeField] private List<AvailableSpot<Airplane>> _airplaneSpots;
}

[Serializable]
public class AvailableSpot<T> where T : Transport
{
    public T Transport { get; set; }
    public GameObject Spot;
}


