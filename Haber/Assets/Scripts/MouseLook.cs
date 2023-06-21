using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensX = 100.0f;
    public float mouseSensY = 100.0f;
    public Transform objetoJugador;

    float rotacionX;
    float rotacionY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*Time.deltaTime*mouseSensX;
        float mouseY = Input.GetAxis("Mouse Y")*Time.deltaTime*mouseSensY;

        rotacionX -= mouseY;
        rotacionX = Mathf.Clamp(rotacionX,-90.0f,90.0f);
        transform.localRotation = Quaternion.Euler(rotacionX,0.0f,0.0f);
        objetoJugador.Rotate(Vector3.up*mouseX);

    }
    public void TrabarMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
