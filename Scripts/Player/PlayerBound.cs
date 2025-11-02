// ==================================================
// Module: PlayerBound
// Purpose: Control player not to move exceed the bound by Leftlow and Rightup
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

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
