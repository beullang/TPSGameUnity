using UnityEngine;

public class PlayerRotateFollower : MonoBehaviour
{
    public Transform followTarget;
    public float rotateSpeed = 10f;//내 캐릭터가 회전하는 속도

    private void Update()
    {
        Vector3 targetForward = followTarget.forward; //객체의 정면
        targetForward.y = 0; //높이는 지워야함 방향만 얻기 위해서.

        if(targetForward.sqrMagnitude >0.01f)
        {
            //lookRotateion 내가 지정한 뱡항으로 바라보게 함
            Quaternion targetRotation = Quaternion.LookRotation(targetForward);
            //내가, 어디까지 부드럽게 회전하는지 , 회전속도
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed);
        }
    }
}
