// ==================================================
// Module: Pig
// Purpose: first enemy; speed up after life half
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: Enemy
// ==================================================


using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.Animations;
#endif

public class Pig : Enemy
{
    public RuntimeAnimatorController angryPig;
    protected override void Move()
    {
        Vector3 direction = (target - transform.position).normalized;
        if (life <= enemyData.maxLife / 2)
        {
            transform.position += direction * 1.2f * speed * Time.deltaTime;
            transform.GetComponent<Animator>().runtimeAnimatorController = angryPig;
        }
        transform.position += direction * speed * Time.deltaTime;
    }

}
