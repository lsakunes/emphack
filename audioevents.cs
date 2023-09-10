using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioevents : MonoBehaviour
{
    public AudioClip[] audioClips;
    public int[] ticks;
    public int iframe;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iframe++;
        for (int i = 0; i < audioClips.Length; i++)
        {
            if (iframe == ticks[i])
                AudioSource.PlayClipAtPoint(audioClips[i], pos.position);
        }
    }
}
