using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected BullTankController controller;
    protected string anim;
    public State(BullTankController _controller, string _anim)
    {
        controller = _controller;
        anim = _anim;
    }
    public abstract void Enter();
    public abstract void Exit();
    public abstract void Update();

    public void PlayAnimation()
    {
        controller.anim.Play(anim);
    }
    public virtual void EndAnimation()
    {

    }

    public virtual void CallStateEvent()
    {

    }
}
