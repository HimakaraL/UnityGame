using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public player Player;
    public AudioClip collectSound;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("FirstPersonController").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonController")
        {
            Player.orbs += 1;
            Player.playerSounds.PlayOneShot(collectSound);
            Destroy(gameObject);
        }
    }
}
