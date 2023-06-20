using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target; // Referência ao objeto que a câmera deve seguir
    public Vector3 offset; // Distância da câmera em relação ao objeto

    void LateUpdate()
    {
        if (target != null)
        {
            // Define a posição da câmera como a posição do objeto mais o deslocamento
            transform.position = target.position + offset;
        }
    }
}