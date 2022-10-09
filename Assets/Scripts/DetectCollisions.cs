/**
Autor: Oscar David Castañeda Rivera
Grupo: GDGS2091
Materia: Creación de videojuegos
**/

/**
Script encargado de poder detectar colisiones
y eliminar elementos
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Funcion que tiene como objetivo destruir elementos.
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
