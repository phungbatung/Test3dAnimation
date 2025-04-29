using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BullTankController : MonoBehaviour
{
    public Rigidbody rb;
    public Animator anim;
    private float mouseX;
    public float horizontalRotateSpeed;


    private State curState;
    public State idle;
    public State move;
    public State attack;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        InitState();
    }

    void Update()
    {
        curState.Update();
    }


    public void InitState()
    {
        idle = new Idle(this, "Idle");
        move = new Move(this, "Run");
        attack = new Attack(this, "Attack_01");

        curState = idle;
        curState.Enter();
    }    
    public void SwitchState(State state)
    {
        curState.Exit();
        curState = state;
        curState.Enter();
    }


    public void DoRotateByMouse()
    {
        mouseX = Input.GetAxis("Mouse X");
        Quaternion quaternion = Quaternion.Euler(Vector3.up * mouseX * horizontalRotateSpeed);
        transform.rotation *=quaternion;
    }   
    
    public void EndAnimation()
    {
        curState.EndAnimation();
    }    
    public void CallStateEvent()
    {
        curState.CallStateEvent();
    }    

}
