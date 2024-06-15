using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    float horizzontalMove = 0f;

    public float runSpeed = 40f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
       horizzontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate() // al posto di essere chiamato ogni frame, può fare un controllo ogni x
    {
        controller.Move(horizzontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
