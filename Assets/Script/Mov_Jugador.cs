using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 1f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,Time.deltaTime*1*velocidad,0);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,Time.deltaTime*-1*velocidad,0);
        }
    }
}



/*
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Time.deltaTime*-1*velocidad,0,0);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Time.deltaTime*1,0,0);
        }
*/




