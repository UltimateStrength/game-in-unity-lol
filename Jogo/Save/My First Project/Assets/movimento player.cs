using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimento do objeto

    void Update()
    {
        // Obtém a entrada do teclado para o movimento nas direções X e Z
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Calcula o vetor de movimento com base nas entradas do teclado
        Vector3 movement = new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;

        // Move o objeto na direção do vetor de movimento
        transform.Translate(movement);
    }
}