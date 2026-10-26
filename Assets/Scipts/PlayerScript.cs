using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public PlayerState State = PlayerState.Idle;
    public Rigidbody2D RB;
    public int Speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerState s = PlayerState.Idle;
        PlayerMovement();
    }

    public void SetState(PlayerState s){
        if (State == s)return;
        State = s;
        if (State == PlayerState.Idle){
            //Anim.Play("Idle");
        }
        else if (State == PlayerState.Walking){
            //Anim.Play("Walking");
        }
        else if (State == PlayerState.Jumping){
            //Anim.Play("Jumping");
        }
        else if (State == PlayerState.Stunned){
            //Anim.Play("Stunned");
        }
    }

    public enum PlayerState{
        None=0,
        Idle=1,
        Walking=2,
        Jumping=3,
        Stunned=4
    }

    public void PlayerMovement()
    {
        Vector2 vel = Vector2.zero;
        if (Keyboard.current.wKey.isPressed)
        {
            vel.y = Speed;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            vel.y = -Speed;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            vel.x = Speed;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            vel.x = -Speed;
        }
        RB.linearVelocity = vel;
    }
}
