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
                //Invoke("Death",2);

               deathManager.ShowDeathScreen();
            }

            else Debug.Log("DeathManager not assigned!");
        }
    }
    public void Death()
    {
        deathManager.ShowDeathScreen();
    }
}
