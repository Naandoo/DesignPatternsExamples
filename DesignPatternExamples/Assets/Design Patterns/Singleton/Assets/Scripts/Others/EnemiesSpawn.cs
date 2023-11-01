using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField] private SpawnPosition _enemiesSpawnPosition;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _maxSpawnDelay;
    [SerializeField] private float _minSpawnDelay;
    private PoolSystem<Enemy> _poolSystem;
    private float _lastSpawnTime;
    private float _spawnDelayReduction = 0.2f;
    private void Start()
    {
        _poolSystem = new PoolSystem<Enemy>(_enemy, 10, transform);
        StartSpawnHordeRoutine();
    }

    private void StartSpawnHordeRoutine()
    {
        SpawnEnemy();
        InvokeRepeating(nameof(SpawnEnemy), 0, GetSpawnDelay());
    }

    private void SpawnEnemy()
    {
        for (int i = 0; i < GetRandomAmountOfEnemies(); i++)
        {
            SpawnSingleEnemy();
        }
    }

    private void SpawnSingleEnemy()
    {
        Enemy enemy = _poolSystem.Get();
        enemy.SetPool(_poolSystem);
        enemy.transform.localPosition = _enemiesSpawnPosition.GetSpot().position;
    }

    private float GetSpawnDelay()
    {
        float spawnDelay = Mathf.Clamp(_lastSpawnTime - _spawnDelayReduction, 1, _maxSpawnDelay);
        if (spawnDelay <= 0) _lastSpawnTime = _maxSpawnDelay;

        return spawnDelay;
    }
    private float GetRandomAmountOfEnemies() => Random.Range(0, _enemiesSpawnPosition.positionsList.Count);
}
