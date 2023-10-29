using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawnPosition : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPositionsList;
    private Queue<Transform> _spawnPositions = new();

    private void Awake()
    {
        foreach (Transform position in _spawnPositionsList)
        {
            _spawnPositions.Enqueue(position);
        }
    }

    public Transform GetPosition()
    {
        Transform position = _spawnPositions.Dequeue();
        _spawnPositions.Enqueue(position);
        return position;
    }
}
