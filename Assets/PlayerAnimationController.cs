using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    //움직ㅇㅣㄴㅡㄴ 동ㅈㅏㄱ
    public Animator playerAnim;
    
    // 유니티 C# / C C++
    // ㅁ
    private void Awake()
    {
        playerAnim = GetComponentInChildren<Animator>();
    }
    //애니메이션을 동작시킬 함수
    public void UpdateMoveAnim(float _speed)
    {
        //SetFloat 파라미터 타입이 float인경우 SetFloat으로 함수를 실행해야함
        playerAnim.SetFloat("Move", _speed); //파라미터
    }
}
