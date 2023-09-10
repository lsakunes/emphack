using UnityEngine;

public class Fade : MonoBehaviour
{
    public Color color;
    public int frame;
    int iframe = 0;
    public GameObject[] objs;
    public int[] frames;
    public bool[] actives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iframe++;
        for (int i = 0; i < frames.Length; i++)
        {
            if (iframe >= frames[i])
            {
                objs[i].SetActive(actives[i]);
            }
        }
    }
}
