using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controladorFPS;
    public float velocidad = 20.0f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movimiento = transform.right*x + transform.forward*z;
        controladorFPS.Move(movimiento*velocidad*Time.deltaTime);
    }
}
