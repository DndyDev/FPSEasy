using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2

    }

    public RotationAxes axes = RotationAxes.MouseXAndY;

    public float sesitivityHorizontal = 9.0f;
    public float sesitivityVertical = 9.0f;

    public float minVertical = -45.0f;
    public float maxVertical = 45.0f;

    private float _rotationX = 0;

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sesitivityHorizontal, 0);
        }
        else if(axes == RotationAxes.MouseY){
            _rotationX -= Input.GetAxis("Mouse Y") * sesitivityVertical;
            _rotationX = Mathf.Clamp(_rotationX, minVertical, maxVertical);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
           
        }
    }
}
