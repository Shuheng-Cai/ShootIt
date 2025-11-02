using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Animations;

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
