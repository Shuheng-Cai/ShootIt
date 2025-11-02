using UnityEngine;
using UnityEngine.InputSystem;

public class BlueBullet : BaseBullet
{
    protected override void Start()
    {
        
    }
    protected override void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
