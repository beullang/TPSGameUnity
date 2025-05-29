using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    //플ㄹㅔㅇㅣㅇㅓ 팔ㄹㅗㅇㅜ
    public Transform target; //내가 따라 다니ㄹ 타게ㅅ
    public Vector3 offset; //내가 타게ㅅㅎㅏㄱㅗㅇㅢ 간ㄱㅕㄱ

    private void LateUpdate()  //업ㄷㅔㅇㅣㅌㅡㄱㅏ 끝ㄴㅏㄱㅗ 늦ㄲㅔ 업ㄷㅔ이트가 호추ㄹ 
    {
        transform.position = target.position + offset; //내 위치= 상ㄷㅐㅂㅏㅇ 위치+ 간ㄱㅕㄱ
    }
}
