using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rune : MonoBehaviour
{
    public player Player;
    public int reqOrb = 5;

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
        if(other.gameObject.name == "FirstPersonController") {
            
            if(Player.orbs >= reqOrb)
            {
                Player.BeatLevel();
            }
        
        }
    }
}
