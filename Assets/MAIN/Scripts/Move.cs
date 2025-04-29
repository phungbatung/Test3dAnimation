using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : State
{
    float yInput;
    public Move(BullTankController _controller, string _anim) : base(_controller, _anim)
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
        if (yInput == 0)
        {
            controller.SwitchState(controller.idle);
            return;
        }
        controller.DoRotateByMouse();
    }
}
