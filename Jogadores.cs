using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{
    // Start is called before the first frame update
    public float Vjogador;
    public bool Jogador1;

    public float yMinimo;
    public float yMaximo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Jogador1 == true)
        {
            Mjogador1();
        }

        if (Jogador1 == false)
        {
            Mjogador2();
        }
    }
    //metodos proprios
    public void Mjogador1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Vjogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Vjogador * Time.deltaTime);
        }
    }

    public void Mjogador2()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Vjogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Vjogador * Time.deltaTime);
        }
    }
}
