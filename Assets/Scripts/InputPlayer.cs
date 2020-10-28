using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{

    [HideInInspector]public float ejeHorizontal   {get; private set ;}
    [HideInInspector]public float ejeVertical     {get; private set ;}
                                                              
    [HideInInspector] public bool atacar          {get; private set ;}
    [HideInInspector] public bool habilidad1      {get; private set ;}
    [HideInInspector]public bool habilidad2       {get; private set ;}
    [HideInInspector]public bool inventario       {get; private set ;}
    [HideInInspector] public bool interactuar     { get; private set;}

    // Update is called once per frame
    void Update()
    {
        atacar=Input.GetButtonDown("Atacar");
        habilidad1 = Input.GetButtonDown("Habilidad1");
        habilidad2 = Input.GetButtonDown("Habilidad2");
        inventario = Input.GetButtonDown("Inventario");
        interactuar = Input.GetButtonDown("Interactuar");
       
       
        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");
        
    }
}
