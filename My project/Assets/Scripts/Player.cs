using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int v = 10;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
        float h = Input.GetAxis("Horizontal");//-1 esquerda, 0 nada, 1 direita;
        float v = Input.GetAxis("Vertical");//-1 tras, 0 nada, 1 frente

        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * v * Time.deltaTime,ForceMode.Impulse);
    }
}
