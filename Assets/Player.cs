using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //declaramos la volocidad
    public float Speed = 1.0f;  
    //declaramos la rotacion
    public float RotationSpeed = 1.0f;  
    //invocamos el Rigidbody
    private Rigidbody Physics;
    //indicamos el eje x e y para la rotacion
    float xInicial, yInicial;
    //instaciamos el player
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        //dejamos invisible el cursor 
        Cursor.visible = false;
        //inicializamos el player 
        player = GetComponent<Player>();
        Physics = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        //movimiento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * Speed);

        //Rotacion 
        float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * RotationSpeed, 0 ));
    
    }


   


    
}
