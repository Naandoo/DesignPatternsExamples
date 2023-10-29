using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPositionsList;
    private Queue<Transform> _spawnPositions = new();

    public List<Transform> positionsList { get => _spawnPositionsList; }

    private void Awake()
    {
        foreach (Transform position in _spawnPositionsList)
        {
            _spawnPositions.Enqueue(position);
        }
    }

    public Transform GetSpot()
    {
        Transform position = _spawnPositions.Dequeue();
        _spawnPositions.Enqueue(position);
        return position;
    }
}
