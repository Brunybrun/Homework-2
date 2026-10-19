using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public PlayerState State = PlayerState.Idle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerState s = PlayerState.Idle;
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
            Anim.Play("Jumping");
        }
        else if (State == PlayerState.Stunned){
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
}
