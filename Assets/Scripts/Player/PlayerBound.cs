// Module: PlayerBound
// Purpose: Haven't used
// Invariants: 
// Performance: 
// Dependencies: 
// Known Tricky Cases: 

using UnityEngine;

public class PlayerBound : MonoBehaviour
{
    public Transform leftlow;
    public Transform rightup;
    public Vector2 min = new(-8f, -4f);
    public Vector2 max = new(8f, 4f);

    void Start()
    {
        min = leftlow.position;
        max = rightup.position;
    }
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);
        transform.position = pos;
    }
}
