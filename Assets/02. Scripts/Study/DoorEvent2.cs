using UnityEngine;

public class DoorEvent2 : MonoBehaviour
{
    public Animator anim;

    public GameObject doorLock;

    public string openkey;
    public string closekey;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            doorLock.SetActive(true);
            //anim.SetTrigger(openkey);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorLock.SetActive(false);
            //anim.SetTrigger(closekey);
        }
    }

}
