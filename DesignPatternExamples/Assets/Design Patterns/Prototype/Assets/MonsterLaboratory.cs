using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class MonsterLaboratory : MonoBehaviour
    {
        [SerializeField] private int _initialMonsterAttackDamage;
        [SerializeField] private Monster _originalPrototype;
        [SerializeField] private List<GameObject> _monsterSpawnPoints;
        [SerializeField] private int _monsterInitialPoolSize;
        private WaitForSeconds _spawnDelay = new WaitForSeconds(2f);
        private PoolSystem<Monster> _monsterObjectsPool;

        private void Awake()
        {
            InitializeMonsterPrototype();
            InitializePool();
            StartCoroutine(SpawnMonstersRoutine());
        }

        private void InitializeMonsterPrototype() => _originalPrototype.MonsterPrototype.AttackDamage = _initialMonsterAttackDamage;
        private void InitializePool() => _monsterObjectsPool = new PoolSystem<Monster>(_originalPrototype, _monsterInitialPoolSize, this.transform);

        private IEnumerator SpawnMonstersRoutine()
        {
            while (true)
            {
                CloneMonster();
                yield return _spawnDelay;
            }
        }

        private void CloneMonster()
        {
            Monster monster = _monsterObjectsPool.Get();
            monster.currentPool = _monsterObjectsPool;
            monster.MonsterPrototype = _originalPrototype.MonsterPrototype.Clone();
            monster.transform.position = _monsterSpawnPoints[Random.Range(0, _monsterSpawnPoints.Count)].transform.position;
        }

        public void IncrementOriginalPrototypeAttack(int amount) => _originalPrototype.MonsterPrototype.AttackDamage += amount;
        public void DecrementOriginalPrototypeAttack(int amount) => _originalPrototype.MonsterPrototype.AttackDamage -= amount;
    }

}