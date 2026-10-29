using UnityEngine;
using UnityEngine.InputSystem;

public class Flechas : MonoBehaviour
{

    public float velocidad = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);        
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.Translate(Vector3.right * velocidad * Time.deltaTime, Space.World);        
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
            transform.Translate(Vector3.up * velocidad * Time.deltaTime, Space.World);
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.Translate(Vector3.down * velocidad * Time.deltaTime, Space.World);
        }
    }
}