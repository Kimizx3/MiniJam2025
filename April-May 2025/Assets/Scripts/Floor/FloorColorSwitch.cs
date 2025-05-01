using UnityEngine;

public class FloorColorSwitch : MonoBehaviour
{
    private Material _material;

    private bool _colorChanged;

    private Color _originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetMaterial();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void GetMaterial()
    {
        _colorChanged = false;
        _material = GetComponent<Renderer>().material;
        _originalColor = _material.GetColor("_BaseColor");
    }

    public void SwitchColor()
    {
        // _material.SetColor("_BaseColor", _colorChanged ? _originalColor : Color.blue);
        // _colorChanged = !_colorChanged;
        _material.SetColor("_BaseColor", Color.yellow);
    }

    public void ResetColor()
    {
        _material.SetColor("_BaseColor", _originalColor);
    }
}
