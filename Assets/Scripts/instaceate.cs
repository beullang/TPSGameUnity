using UnityEngine;

public class instaceate : MonoBehaviour
{
    public GameObject bullet; // ������ �Ѿ�
    public Transform firePos; //�Ѿ��� �߻�� ��ġ

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
