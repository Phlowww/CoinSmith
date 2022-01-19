using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionManager : MonoBehaviour


{
    public Animator anim;
    private bool isHitting;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Hit", isHitting);
    }

    

    public void OnHit(InputValue value)
    {
        isHitting = value.isPressed;
    }


}
