using TMPro;
using UnityEngine;

public class Bat : MonoBehaviour
{
    public float speed = 6;
    public int points = 100;
    void Update()
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
            if (transform.position.x > 7)
            {
            Destroy(gameObject);
        }
 
    }
}
