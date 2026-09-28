using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public float deathY = -10f;
    public DeathManager deathManager;

    public float XshakeHigh = 0.4f;
    public float XshakeLow = -0.4f;
    public float Xshakey = 0f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position .y < deathY )
        {
            if (deathManager != null)
            {
                Invoke("Death", 2);


                Xshakey = Random.Range(XshakeLow, XshakeHigh);
                //when you die, move camera 0.4x 0.5x or -0.4 and -0.5
                //every 0.25 second
            }

            else Debug.Log("DeathManager not assigned!");
        }
    }
    public void Death()
    {
        deathManager.ShowDeathScreen();
    }
}
