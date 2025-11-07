// Module: EnemySpawn
// Purpose: Control Eneny to spawen considering the wave
// Invariants: 
// Performance: 
// Dependencies: EnemyData
// Known Tricky Cases: unlock the enemy according to the wave of enemy. And spawn enemy according to the weight.
// Especially: there is a enemyPool, inQueue and out Queue


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public EnemyData[] enemyPool;
    [SerializeField] public Queue<EnemyData> enemySpawnQueue = new Queue<EnemyData>();

    #region Spawn Postion
    public Transform leftlow;
    public Transform rightup;
    public Vector2 min = new(-8f, -4f);
    public Vector2 max = new(8f, 4f);

    public Vector3 SpawnPosition()
    {
        Vector3 pos = new Vector3();
        pos.x = Random.Range(leftlow.position.x, rightup.position.x);
        pos.y = Random.Range(leftlow.position.y, rightup.position.y);
        int side = Random.Range(0, 4); // 0上 1下 2左 3右

        switch (side)
        {
            case 0: // 上边
                pos = new Vector3(Random.Range(leftlow.position.x, rightup.position.x), rightup.position.y, 0);
                break;
            case 1: // 下边
                pos = new Vector3(Random.Range(leftlow.position.x, rightup.position.x), leftlow.position.y, 0);
                break;
            case 2: // 左边
                pos = new Vector3(leftlow.position.x, Random.Range(leftlow.position.y, rightup.position.y), 0);
                break;
            case 3: // 右边
                pos = new Vector3(leftlow.position.x, Random.Range(leftlow.position.y, rightup.position.y), 0);
                break;
        }

        return pos;
    }
    #endregion

    public float spawnTime;
    public bool canSpawn; // can Spawn enemy
    public bool canUnlock = true; // can Unlock enemy
    public int enemyUpdate; // How long should the Enemy to Upgrade
    [SerializeField] private int unlockedEnemyCount = 1; // now which can spawn
    public float unlockedEnemyInterval; //. upgrade Interval
    [SerializeField] private float unlockTimer = 0;
    private List<int> spawnWeights = new List<int>();

    #region Wave Contorl
    public int currentWave; // the wave enemy spawn;
    private float waveTimer;
    public int timePerWave;

    private void EnemyWaveUpdate()
    {
        waveTimer += Time.fixedDeltaTime;

        if(waveTimer >= currentWave * timePerWave)
        {
            currentWave++;
        }
    }
    #endregion

    void Start()
    {
        min = leftlow.position;
        max = rightup.position;
        AddWeight(enemyPool[0]);
        InQueue();
    }
    void Update()
    {
        if (canUnlock)
        {
            UnlockEnemy();
        }

        if (canSpawn)
        {
            StartCoroutine(Spawn());
        }

        EnemyWaveUpdate();
    }

#region Spawn Control
    public void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemySpawnQueue.Dequeue().prefeb, SpawnPosition(), Quaternion.identity);
        InQueue();
    }

    IEnumerator Spawn()
    {
        canSpawn = false;
        int enemyCount = Mathf.Min(3 + currentWave / 2, 10); // the higher the wave, the more enemies
        for (int i = 0; i < enemyCount; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.15f);
        }
        yield return new WaitForSeconds(spawnTime);

        canSpawn = true;
    }

    public void UnlockEnemy()
    {
        unlockTimer += Time.deltaTime;

        if (unlockTimer >= unlockedEnemyInterval && unlockedEnemyCount + 1 <= enemyPool.Count())
        {
            unlockTimer = 0;

            int pointerLeft = unlockedEnemyCount;
            int pointerRight = unlockedEnemyCount;
            while (pointerRight < enemyPool.Count())
            {
                if (enemyPool[pointerLeft].updateWave == enemyPool[pointerRight].updateWave)
                {
                    Debug.Log(1);
                    AddWeight(enemyPool[unlockedEnemyCount]);
                    pointerRight++;
                    unlockedEnemyCount++;
                }
            }
        }
    }

    public void InQueue()
    {
        enemySpawnQueue.Enqueue(enemyPool[WeightedRandomChoose(spawnWeights)]);
    }
#endregion

#region Weight Control
    public int WeightedRandomChoose(List<int> weights)
    {
        float total = 0f;
        foreach (float w in weights)
            total += w;

        float randomValue = Random.Range(0f, total);
        float cumulative = 0f;

        for (int i = 0; i < weights.Count; i++)
        {
            cumulative += weights[i];
            if (randomValue <= cumulative)
                return i;
        }

        return weights.Count - 1;
    }

    public void AddWeight(EnemyData enemyData)
    {
        spawnWeights.Add(enemyData.baseWeight);
    }
#endregion

}
