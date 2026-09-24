using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //create a public reference to the player - we will assign this using the unity editor
    public GameObject player;

    private void Update()
    {
        //change our position relative to the players position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position .z);
    }
}
