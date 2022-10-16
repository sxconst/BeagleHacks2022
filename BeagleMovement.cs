using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeagleMovement : MonoBehaviour
{
    public static Rigidbody2D beagleBody;

    // Start is called before the first frame update
    void Start()
    {
        beagleBody = this.GetComponent<Rigidbody2D>();
        beagleBody.velocity = new Vector2(2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("doghouse"))
        {
            Destroy(this.gameObject);
            Score.newScore++;
            Score.desiredScore++;
            SpawnBeagle.currentBeagles--;
        }
    }
}
