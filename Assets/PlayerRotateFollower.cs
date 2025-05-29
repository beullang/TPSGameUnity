using UnityEngine;

public class PlayerRotateFollower : MonoBehaviour
{
    public Transform followTarget;
    public float rotateSpeed = 10f;//�� ĳ���Ͱ� ȸ���ϴ� �ӵ�

    private void Update()
    {
        Vector3 targetForward = followTarget.forward; //��ü�� ����
        targetForward.y = 0; //���̴� �������� ���⸸ ��� ���ؼ�.

        if(targetForward.sqrMagnitude >0.01f)
        {
            //lookRotateion ���� ������ �������� �ٶ󺸰� ��
            Quaternion targetRotation = Quaternion.LookRotation(targetForward);
            //����, ������ �ε巴�� ȸ���ϴ��� , ȸ���ӵ�
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed);
        }
    }
}
