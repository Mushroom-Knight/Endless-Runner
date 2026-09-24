using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //much like the start() and update() methods, ontriggerenter2d is a special unity method that is called
    //by unity automatically at a specific point - in this case, when something enters the trigger attached
    //to this gameobject

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the gameobject that has collided with our trigger is tagged with cleanup...
        if (collision.gameObject.tag == "CleanUp")
        {
            //then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }
}
