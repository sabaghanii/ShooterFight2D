using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementManager : MonoBehaviour
{
    public VariableJoystick joystick;
    public Canvas inputCanvas;
    public bool isJoyStick;
    public float movementSpeed;
    public Rigidbody2D rb_gun;
    public Rigidbody2D rb_rifle;
    public gameManager gm;
    //public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        EnableJoyStick();
    }

    // Update is called once per frame
    void Update()
    {
        if (isJoyStick)
        {

            var movementDirection = new Vector3(joystick.Direction.x, joystick.Direction.y);
            if (gm.weaponIndex == 1) { rb_gun.velocity = movementDirection * movementSpeed; }
            if (gm.weaponIndex == 2) { rb_rifle.velocity = movementDirection * movementSpeed; }


            //controller.SimpleMove(movementDirection * movementSpeed);
        }
    }

    public void EnableJoyStick()
    {
        isJoyStick = true;
        inputCanvas.gameObject.SetActive(true);
    }
}
