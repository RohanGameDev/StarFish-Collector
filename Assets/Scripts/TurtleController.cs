using UnityEngine;

public class TurtleController : MonoBehaviour
{

    public float movespeed = 2.0f;
    public float turnspeed = 1.0f;
    public Rigidbody turtle;

    void Update()
    {
        if (Input.GetKey("w"))
        {
            this.transform.position =
                this.transform.position + this.transform.localRotation * Vector3.forward * movespeed;
        }
        if (Input.GetKey("s"))
        {
            this.transform.position =
                this.transform.position - this.transform.localRotation * Vector3.forward * movespeed;
        }

        if (Input.GetKey("a"))
        {
            this.transform.localRotation =
                Quaternion.Euler(0, -turnspeed, 0) * this.transform.localRotation;
        }
        if (Input.GetKey("d"))
        {
            this.transform.localRotation =
                Quaternion.Euler(0, turnspeed, 0) * this.transform.localRotation;
        }
        if (turtle.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    public void OnCollisionEnter(Collision collision)
      {
         if(collision.gameObject.tag == "Star") 
          {
              Destroy(collision.gameObject);
              FindObjectOfType<StarFishCollector>().Counter();

          }
         
         if(collision.gameObject.tag == "Crab")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
      }

    
    
}
