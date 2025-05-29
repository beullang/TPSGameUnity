using UnityEngine;

public class instaceate : MonoBehaviour
{
    //
    public Animator playeranimator;
    public bool state;

    private void Update()
    {
        
        playeranimator.SetBool("Change", state);
    }
}
