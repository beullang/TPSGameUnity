using UnityEngine;

public class instaceate : MonoBehaviour
{
    //Ŭ����(���)
    public Rigidbody body; 
    public Animator playeranimator;
    public bool state;

    private void Start()
    {
        body = GetComponentInChildren<Rigidbody>(); //�ڱ� �ڽ��� ������ �ִ�
    }
    private void Update()
    {
        
        playeranimator.SetBool("Change", state);
    }
}
