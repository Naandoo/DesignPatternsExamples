using System;
using System.Collections.Generic;
using UnityEngine;

public class AirportSpotsHandler : MonoBehaviour
{
    #region Private Variables
    [SerializeField] private List<AvailableSpot<Bus>> _busSpots;
    [SerializeField] private List<AvailableSpot<Car>> _carSpots;
    [SerializeField] private List<AvailableSpot<Airplane>> _airplaneSpots;
    #endregion

    #region Public Variables
    public List<AvailableSpot<Bus>> BusSpots { get => _busSpots; set => _busSpots = value; }
    public List<AvailableSpot<Car>> CarSpots { get => _carSpots; set => _carSpots = value; }
    public List<AvailableSpot<Airplane>> AirplaneSpots { get => _airplaneSpots; set => _airplaneSpots = value; }
    #endregion

    public Vector3 GetAvailablePosition(Transport transport)
    {
        return transport switch
        {
            Bus _ => CheckForAvailableSpot(BusSpots),
            Car _ => CheckForAvailableSpot(CarSpots),
            Airplane _ => CheckForAvailableSpot(AirplaneSpots),
            _ => throw new ArgumentOutOfRangeException(nameof(transport), transport, null),
        };
    }

    public Vector3 CheckForAvailableSpot<T>(List<AvailableSpot<T>> spots) where T : Transport
    {
        GameObject availableSpot = spots[0].Spot;

        return availableSpot.transform.position;
    }


}

[Serializable]
public class AvailableSpot<T> where T : Transport
{
    public T Transport { get; set; }
    public GameObject Spot;
}


