using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField] private EnemiesSpawnPosition _spawnPosition;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _spawnDelay;
    private PoolSystem<GameObject> _poolSystem;

    private void Start()
    {
        _poolSystem = new PoolSystem<GameObject>(_enemyPrefab, 10, transform);
        InvokeRepeating(nameof(SpawnEnemy), 0, _spawnDelay);
    }

    private void SpawnEnemy()
    {
        GameObject enemy = _poolSystem.Get();
        enemy.transform.position = _spawnPosition.GetPosition().position;
    }
}
