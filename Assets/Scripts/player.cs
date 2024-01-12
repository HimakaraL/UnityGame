using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    public int orbs = 0;
    public AudioSource playerSounds;
    public Image levelSplash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeatLevel()
    {
        levelSplash.gameObject.SetActive(true);
    }
}
