using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField] private SpawnPosition _enemiesSpawnPosition;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _minSpawnDelay;
    [SerializeField] private float _maxSpawnDelay;
    private PoolSystem<Enemy> _poolSystem;

    private void Start()
    {
        _poolSystem = new PoolSystem<Enemy>(_enemy, 10, transform);
        StartSpawnHordeRoutine();
    }

    private void StartSpawnHordeRoutine()
    {
        SpawnEnemy();
        InvokeRepeating(nameof(SpawnEnemy), 0, GetRandomSpawnDelay());
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

    private float GetRandomSpawnDelay() => Random.Range(_minSpawnDelay, _maxSpawnDelay);
    private float GetRandomAmountOfEnemies() => Random.Range(0, _enemiesSpawnPosition.positionsList.Count);
}
