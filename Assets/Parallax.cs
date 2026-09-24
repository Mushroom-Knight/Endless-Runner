using System.IO;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player; //Reference to the player so we can track its position
    Renderer rend; //reference to the renderer so we can modify its texture

    float playerStartPos; // Float used to track the starting position of the player
    public float speed = 0.5f; //how fast shold we scroll? we change this for each layer

    void Start()
    {
        player = GameObject.Find("Player"); //find the player
        rend = GetComponent<Renderer>(); //Find the renderer
        playerStartPos = player.transform.position.x; //save our starting postion

    }


    void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;
        //^^^^^^^^^^^^^^^^^^^^ this line find out how much to offset the texture by.
        //we do this by subtracting our starting x position from our current x position
        //we then multiply the offset by the speed, so that we can have different layers
        //moving at different speeds

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
        //^^^^^^^^^^^^^^^^^^^^ this line sets our textures 'offset'. we use the
        //settextureoffset method to do this, which takes 2 parameters.
        //the first parameter is a string that refers to the texture we want to modify
        //the second parameter is a vector2, with the first (x) variable shifting the texure up and down
    }
}