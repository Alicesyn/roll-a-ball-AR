using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // In this case the we want to check if the "other" is the "Ball"
        if (other.name == "Ball")
        {
            //if this condition is correct and indeed the Ball game object has hit us, access the Point System game object, then the PointSystem script attached to it, and increase the Points variable by 1            
            GameObject.Find("Point System").GetComponent<PointSystem>().Points += 1;

            // access the audio management game object, then the AudioSource component, and play
            GameObject.Find("Sound Management").GetComponent<AudioSource>().Play();

            // we will remove this game object where the script is attached to (i.e. the coin)
            Destroy(this.gameObject);
        }
    }
}
