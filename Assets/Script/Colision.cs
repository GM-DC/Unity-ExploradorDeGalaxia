using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D objeto) {
        if (objeto.gameObject.name=="pared")
        {
            transform.position = new Vector3(10,Random.Range(-5,5),0);
        }

        if (objeto.gameObject.name=="jugador")
        {
            Destroy(objeto.gameObject);
        }
    }

}
