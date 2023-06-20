using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 3f; // Velocidade de rotação da câmera

    void Update()
    {
        // Obtém a entrada do mouse para o movimento horizontal
        float mouseX = Input.GetAxis("Mouse X");

        // Rotaciona a câmera em torno do eixo Y com base na entrada do mouse
        transform.Rotate(Vector3.up, mouseX * cameraSpeed * Time.deltaTime);
    }
}
