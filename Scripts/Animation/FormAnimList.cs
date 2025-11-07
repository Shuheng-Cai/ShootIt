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
