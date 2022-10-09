/**
Autor: Oscar David Castañeda Rivera
Grupo: GDGS2091
Materia: Creación de videojuegos
**/

/**
Script encargado de poder mover el objeto del jugador
hacía la izquierda o hacía la derecha
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 15f;

    //Variable tipo GameObject que sera el proyectil
    public GameObject projectilPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fragmento de codigo que sirve para movilidad sobre el eje x
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Fragmento de codigo que sirve para movilidad sobre el eje x
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Fragmento de codigo para hacer Movimiento del jugador de manera horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Fragmento de codigo para hacer instancias de objetos de tipo beer (proyectiles)
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }
    }
}
