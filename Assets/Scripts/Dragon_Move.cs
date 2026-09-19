using Unity.Collections;
using UnityEngine;

public class Dragon_Move : MonoBehaviour
{
    public float Speed = 5;
    public bool goingUp = true;

    //rat/fireball timers
    private float RatWait = 1, FireballWait = 2, BatWait = 4, IceWait = 3;
    private float RatTimer = 0, FireballTimer = 0, BatTimer = 0, IceTimer = 0;
    public GameObject Rat;
    public GameObject Fireball;
    public GameObject Bat;
    public GameObject Ice;
    void Update()
    {
        //spawning
        RatTimer += Time.deltaTime;
        FireballTimer += Time.deltaTime;
        BatTimer += Time.deltaTime;
        IceTimer += Time.deltaTime;

        if(RatTimer > RatWait)
        {
            Instantiate(Rat, transform.position, Quaternion.identity);
            RatTimer = 0;
            RatWait = Random.Range(1f, 2f);
        }

        if (FireballTimer > FireballWait)
        {
            Instantiate(Fireball, transform.position, Quaternion.identity);
            FireballTimer = 0;
            FireballWait = Random.Range(2f, 3f);
        }
        if (BatTimer > BatWait)
        {
            Instantiate(Bat, transform.position, Quaternion.identity);
            BatTimer = 0;
            BatWait = Random.Range(1f, 3f);
        }
        if (IceTimer > IceWait)
        {
            Instantiate(Ice, transform.position, Quaternion.identity);
            IceTimer = 0;
            IceWait = Random.Range(1f, 3f);
        }
        transform.Translate(transform.up * Speed * Time.deltaTime);

        if (transform.position.y > 4 && goingUp == true)
        {
            goingUp = false;
            Speed *= -1;
        
        }
        transform.Translate(transform.up * Speed * Time.deltaTime);

        if (transform.position.y < -4 && goingUp == false)
        {
            goingUp = true;
            Speed *= -1;

        }
    }
}
