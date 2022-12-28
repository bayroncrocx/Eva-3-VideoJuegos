using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo2 : MonoBehaviour
{
    // Start is called before the first frame update
   private Player player;
    // timepo inicial 
    public float timer = 0;
    // texto de tiempo 
    public Text textoTimer;
    

    // Update is called once per frame
    void Update()
    {
        //funcion para que el tiempo retroceda 
        timer -= Time.deltaTime;

        //funcion para que muestre en tipo texto
        textoTimer.text= "" + timer.ToString("f0");
        //indica que cuando se acaba el tiempo destruye el player 
        if (timer <0)
        {
            Destroy(player.gameObject);
        }
    }
}

