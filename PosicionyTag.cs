// Enmanuel Vegas (alu0101281698@ull.edu.es)

using UnityEngine;

public class MostrarTagsYPosiciones : MonoBehaviour
{
    public Transform contenedor_objetos;

    void Start()
    {
        foreach (Transform hijo in contenedor_objetos)
        {
            GameObject obj = hijo.gameObject;
            Vector3 posicion = obj.transform.position;
            Debug.Log("Objeto: " + obj.name +
                      " | Tag: " + obj.tag +
                      " | Posición: " + posicion);
        }
    }
}
