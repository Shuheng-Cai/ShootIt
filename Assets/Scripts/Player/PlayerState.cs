// Module: PlayerState
// Purpose: To control player's state.
// Invariants: 
// Performance: 
// Dependencies: SceneChangeManagement: to control scenechange. TakeDamage: take damage when be hurt.
// Known Tricky Cases: When die, trigger the Die and SceneChange.

using UnityEngine;
using UnityEngine.Events;

public class PlayerState : MonoBehaviour
{
    public float life;
    public float currentLife;
    public float shootDamage;
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
