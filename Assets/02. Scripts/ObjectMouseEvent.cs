using UnityEngine;

public class ObjectMouseEvent : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Mouse Down");
    }
    void OnMouseUp()
    {
        Debug.Log("Mouse Up");
    }
    void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
    }
    void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
    }
    void OnMouseDrag()
    {
        Debug.Log(Input.mousePosition);

        Debug.Log("Mouse Drag");
    }
    void OnMouseUpAsButton()
    {
        Debug.Log("Mouse Up As Button");
    }
    void OnMouseOver()
    {
        Debug.Log("Mouse Over");
    }
}
