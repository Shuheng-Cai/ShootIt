// Module: EnemyData
// Purpose: Create enemy scriptalbe object
// Invariants: 
// Performance: 
// Dependencies: 
// Known Tricky Cases: remeber baseWeight is the Weight to spawn, the bigger the more frequent
//                     UpdateWave is when the enemy can spawn

using UnityEngine;

[CreateAssetMenu(menuName = "Game/EnemyData")]
public class EnemyData : ScriptableObject
{
    public int enemyId;
    public float maxLife;
    public float damageToPlayer;
    public GameObject prefeb;
    public int baseWeight; // weight to spawn
    public float growthPerTenSecond;
    public int updateWave; // the wave of update
}
