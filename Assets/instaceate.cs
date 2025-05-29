using UnityEngine;

public class instaceate : MonoBehaviour
{
    //클래스(기능)
    public Rigidbody body; 
    public Animator playeranimator;
    public bool state;

    private void Start()
    {
        body = GetComponentInChildren<Rigidbody>(); //자기 자신이 가지고 있는
    }
    private void Update()
    {
        
        playeranimator.SetBool("Change", state);
    }
}
