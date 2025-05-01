using UnityEngine;

public class MousePosition : MonoBehaviour
{
    private Vector3 _mousePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MousePosInit();
    }

    // Update is called once per frame
    void Update()
    {
        MousePosUpdate();
    }

    private void MousePosInit()
    {
        _mousePosition = Input.mousePosition;
    }

    private void MousePosUpdate()
    {
        _mousePosition = Input.mousePosition;
    }
}
