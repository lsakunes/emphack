using UnityEngine;

public class Move : MonoBehaviour
{
    public int frames;
    private int frame = 0;
    public Transform start;
    public Transform end;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(start.position, end.position, (float)frame / frames);
        frame++;
        if (frame >= frames)
            frame = frames;
    }
}
