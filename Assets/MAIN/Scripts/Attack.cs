using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : State
{
    public Attack(BullTankController _controller, string _anim) : base(_controller, _anim)
    {
    }

    public override void Enter()
    {
        PlayAnimation();
    }

    public override void Exit()
    {

    }

    public override void Update()
    {

    }

    public override void EndAnimation()
    {
        controller.SwitchState(controller.idle);
    }
}
