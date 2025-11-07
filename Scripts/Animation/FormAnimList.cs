// Module: FormAnimList
// Purpose: Change the animation when change form
// Invariants: 
// Performance: 
// Dependencies: 
// Known Tricky Cases:

using UnityEngine;

public class FormAnimList : MonoBehaviour
{
    void Start()
    {
        
    }
    
    public void ChangeFormAnim(PlayerFormData playerFormObjects)
    {
        transform.GetComponent<Animator>().runtimeAnimatorController = playerFormObjects.formAnimController;
    }
}
