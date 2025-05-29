using UnityEngine;

public class instaceate : MonoBehaviour
{
    public GameObject bullet; // 복제할 총알
    public Transform firePos; //총알이 발사될 위치

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            var obj = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation);
            var objrb = obj.GetComponent<Rigidbody>();
            objrb.AddForce(new Vector3(0,0,5), ForceMode.Impulse);
        }
    }
}
