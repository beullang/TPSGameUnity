using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    //�������Ӥ��Ѥ� ��������
    public Animator playerAnim;
    
    // ����Ƽ C# / C C++
    // ��
    private void Awake()
    {
        playerAnim = GetComponentInChildren<Animator>();
    }
    //�ִϸ��̼��� ���۽�ų �Լ�
    public void UpdateMoveAnim(float _speed)
    {
        //SetFloat �Ķ���� Ÿ���� float�ΰ�� SetFloat���� �Լ��� �����ؾ���
        playerAnim.SetFloat("Move", _speed); //�Ķ����
    }
}
