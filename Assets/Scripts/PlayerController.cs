using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private InputPlayer inputJugador;
    private Transform transformada;
    private Rigidbody2D miRigidbody2D;
    private Animator animator;
    private SpriteRenderer miSprite;

    int correrHashCode;
   
    [SerializeField]private float velocidad=3;
    
    private float horizontal, vertical;
 


    // Start is called before the first frame update
    void Start()
    {
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();
        miRigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        miSprite = GetComponent<SpriteRenderer>();
        correrHashCode = Animator.StringToHash("Corriendo");
    }


    void Update() //GameLogic
    {
        horizontal = inputJugador.ejeHorizontal;
        vertical = inputJugador.ejeVertical;


        VoltearSprite();

        if (vertical != 0 || horizontal != 0)
        {
            SetXYAnimator();
            animator.SetBool(correrHashCode, true);
        }
        else
        {
            animator.SetBool(correrHashCode, false);
        }

    }

    private void VoltearSprite()
    {
        //Si se buguea la animacion cambiar el signo de menor a mayor del segundo
        if (horizontal < 0 && Mathf.Abs(vertical) < Mathf.Abs(horizontal))
        {
            miSprite.flipX = true;
        }
        else if (horizontal != 0)
        {
            miSprite.flipX = false;
        }
    }

    private void SetXYAnimator()
    {
        animator.SetFloat("X", horizontal);
        animator.SetFloat("Y", vertical);
    }

    void FixedUpdate() //Fisica de Movimiento
    {

        Vector2 vectorVelocidad = new Vector2(horizontal, vertical) * velocidad;
        miRigidbody2D.velocity = vectorVelocidad;

    }
}
