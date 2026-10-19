using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public PlayerState state;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum PlayerState{
        None=0,
        Idle=1,
        Walking=2,
        Jumping=3,
        Stunned=4
    }
}
