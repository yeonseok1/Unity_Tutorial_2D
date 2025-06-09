using UnityEngine;

public class NumberKeypad : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject doorLock;

    public string password;
    public string keyPadNumber;

    public void OnInputNumber(string numstring)
    {
        keyPadNumber += numstring;

        Debug.Log($"{numstring} 입력 -> 현재 입력 : {keyPadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keyPadNumber == password)
        {
            keyPadNumber = "";
            Debug.Log("문 열림");
            doorAnim.SetTrigger("Door Open");
            doorLock.SetActive(false);
        }
        else
        {
            keyPadNumber = "";
            Debug.Log("비밀 번호 오류");
        }
    }
}
