using UnityEngine;

public class MouseHover : MonoBehaviour
{
    private Camera _camera;
    private FloorColorSwitch _floorColorSwitch;
    private bool _isMainCam;

    private GameObject _lastHitObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TryGetMainCamera();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayObjectPos();
    }

    private void TryGetMainCamera()
    {
        // TODO: Check if v-camera is being used
        _camera = GetComponent<Camera>();
    }
    
    private void DisplayObjectPos()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            GameObject currentHitObject = hit.transform.gameObject;

            if (currentHitObject != _lastHitObject)
            {
                if (_lastHitObject != null)
                {
                    var preSwitch = _lastHitObject.GetComponent<FloorColorSwitch>();
                    if (preSwitch != null)
                    {
                        preSwitch.SwitchColor();
                    }
                }

                var currentSwitch = currentHitObject.GetComponent<FloorColorSwitch>();
                if (currentSwitch != null)
                    currentSwitch.SwitchColor();

                _lastHitObject = currentHitObject;
            }
            else
            {
                if (_lastHitObject != null)
                {
                    var preSwitch = _lastHitObject.GetComponent<FloorColorSwitch>();
                    if (preSwitch != null)
                        preSwitch.ResetColor();

                    _lastHitObject = null;
                }
            }
        }
    }
}
