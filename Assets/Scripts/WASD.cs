using UnityEngine;
using UnityEngine.InputSystem;

public class WASD : MonoBehaviour
{

    public float velocidad = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);        
        }

        if (Keyboard.current.dKey.isPressed)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.right * velocidad * Time.deltaTime, Space.World);        
        }

        if (Keyboard.current.wKey.isPressed)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.Translate(Vector3.up * velocidad * Time.deltaTime, Space.World);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
            transform.Translate(Vector3.down * velocidad * Time.deltaTime, Space.World);
        }
    }
}