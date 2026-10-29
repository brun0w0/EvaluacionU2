using UnityEngine;

public class Pinchado : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D choque)
    {
        if (choque.collider.CompareTag("Player"))
        {
            if (choque.collider.gameObject != transform.parent.gameObject)
            {
                Debug.Log(choque.collider.gameObject.name + " Ha sido pinchado ");
                Destroy(choque.collider.gameObject);
            }
        }
    }
}