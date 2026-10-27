using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public PlayerState State = PlayerState.Idle;
    public Animator Anim;
    public Rigidbody2D RB;
    public int Speed = 3;
    public float Stuntimer;
    static public bool hit = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (State == PlayerState.Stunned)
        {
            StunnedPlayer();
        }
        else
        {
            PlayerMovement();
        }
    }

    public void SetState(PlayerState s){
        if (State == s)return;
        State = s;
        if (State == PlayerState.Idle){
            Anim.Play("Idle");
        }
        else if (State == PlayerState.Walking){
            Anim.Play("Walking");
        }
        else if (State == PlayerState.Jumping){
            Anim.Play("Jump");
        }
        else if (State == PlayerState.Stunned)
        {
            Stuntimer = 1;
            Anim.Play("Stunned");
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
        PlayerState s = PlayerState.Idle;
        Vector2 vel = Vector2.zero;
        if (Keyboard.current.wKey.isPressed)
        {
            s = PlayerState.Jumping;
            vel.y = Speed;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            vel.y = -Speed;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            s = PlayerState.Walking;
            vel.x = Speed;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            s = PlayerState.Walking;
            vel.x = -Speed;
        }
        if (hit)
        {
            s = PlayerState.Stunned;
        }
        SetState(s);
        RB.linearVelocity = vel;
    }

    public void StunnedPlayer()
    {
        Stuntimer -= Time.deltaTime;
        if (Stuntimer <= 0)
        {
            SetState(PlayerState.Idle);
        }
    }
}
