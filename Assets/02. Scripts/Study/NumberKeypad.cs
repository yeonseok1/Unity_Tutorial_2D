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

        Debug.Log($"{numstring} �Է� -> ���� �Է� : {keyPadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keyPadNumber == password)
        {
            keyPadNumber = "";
            Debug.Log("�� ����");
            doorAnim.SetTrigger("Door Open");
            doorLock.SetActive(false);
        }
        else
        {
            keyPadNumber = "";
            Debug.Log("��� ��ȣ ����");
        }
    }
}
