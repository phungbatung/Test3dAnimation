using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    float yInput;
    public Idle(BullTankController _controller, string _anim) : base(_controller, _anim)
    {
    }

    public override void Enter()
    {
        controller.anim.Play(anim);
    }

    public override void Exit()
    {
    }

    public override void Update()
    {
        yInput = Input.GetAxis("Vertical");
        if(yInput!=0) 
        {
            controller.SwitchState(controller.move);
            return;
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            controller.SwitchState(controller.attack);
            return;
        }    
        controller.DoRotateByMouse();
    }
}
