using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Projectilemovementscript : MonoBehaviour
{
    public GameObject Bat;

    public float speed = 4;
    private int scoreVal = 0;
    public TextMeshProUGUI scoreBox;
    private float BatWait = 1;
    private float BatTimer = 0;
    void Update()
    {
        //spawning Bat
        BatTimer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && BatTimer > BatWait)
        {
            Instantiate(Bat, transform.position, Quaternion.identity);
            BatTimer = 0f;
            {
            }
        }



        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            if (collision.GetComponent<Projectile_Move>() != null)
            {
                scoreVal += collision.GetComponent<Projectile_Move>().points;
                scoreBox.text = "Score" + scoreVal;
            }       
            Destroy(collision.gameObject);
        }
    }
}

