// ==================================================
// Module: PlayerState
// Purpose: Life
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public float life;
    public float currentLife;
    public float shootDamage;
    public float shootSpeed;
    public float fireRate; // spawn interval time;

    void Start()
    {
        currentLife = life;
    }

    public void TakeDamage(float damage)
    {
        currentLife -= damage;
    }
}
