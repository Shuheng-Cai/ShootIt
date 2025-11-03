// ==================================================
// Module: PlayerState
// Purpose: Life
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

using UnityEngine;
using UnityEngine.Events;

public class PlayerState : MonoBehaviour
{
    public float life;
    public float currentLife;
    public float shootDamage;
    public float shootSpeed;
    public float fireRate; // spawn interval time;
    public UnityEvent onPlayerDie = new UnityEvent();
    public GameOverTextController gameOverTextController;

    void Start()
    {
        currentLife = life;
        onPlayerDie.AddListener(SceneChangeManager.ChangeToGameOver);
        onPlayerDie.AddListener(Die);
    }
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {
        currentLife -= damage;
        if (currentLife <= 0)
        {
            onPlayerDie.Invoke();
        }
    }

    public void Die()
    {
        
    }
}
