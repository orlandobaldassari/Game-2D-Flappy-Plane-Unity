using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.02f;
    [SerializeField]
    private float variacaoDaPosicaoY;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade);

    }
    private void OnTriggerEnter2D(Collider2D outro)
    {
        this.Destruir();

    }

    private void Destruir()
    {
        Destroy(this.gameObject);

    }

}