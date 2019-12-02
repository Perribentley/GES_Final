using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float VerticalMouseSens = 0.5f;
    [SerializeField] float HorizontalMouseSens = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get X and Y axis
        float MouseHorizontal = Input.GetAxis("Mouse X") * HorizontalMouseSens;
        float MouseVertical = Input.GetAxis("Mouse Y") * VerticalMouseSens;

        //Rotate Camera
        float CameraRotX = transform.eulerAngles.x + MouseHorizontal;
        float CameraRotY = transform.eulerAngles.y + MouseVertical;

        transform.eulerAngles = new Vector3(CameraRotX, CameraRotY, 0);
    }
}
