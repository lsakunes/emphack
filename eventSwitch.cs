using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventSwitch : MonoBehaviour
{
    public Transform audioS;
    public Animator animator;
    public AdvanceToNext next;
    public Fade fade;

    private int choice;
    private bool chosen  = false;
    private int i = 0;

    public AudioClip[] clips1;
    public AudioClip[] clips2;
    public AudioClip[] clips3;
    public AudioClip[] clips4;
    public int nexts;

    public int[] frames1;
    public int[] frames2;
    public int[] frames3;
    public int[] frames4;

    public int animFrame1;
    public int animFrame2;
    public int animFrame3;
    public int animFrame4;

    public int end1;
    public int end2;
    public int end3;
    public int end4;

    public bool anim1;
    public bool anim2;
    public bool anim3;
    public bool anim4;

    public GameObject[] buttons;
    public void choose(int choice)
    {
        this.choice = choice;
        chosen = true;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i != choice)
            {
                Destroy(buttons[i]);
                Destroy(fade);
            }

        }
    }

    private void Update()
    {
        if (chosen)
        {
            i++;
            switch (choice)
            {
                case 0:
                    for (int j = 0; j < frames1.Length; j++)
                        if (i == frames1[j])
                            AudioSource.PlayClipAtPoint(clips1[j], audioS.position);
                    if (i == animFrame1)
                        if (anim1)
                            animator.SetInteger("switch", 1);
                    if (i > end1)
                        next.NextScene(nexts); 
                    break;

                case 1:
                    for (int j = 0; j < frames2.Length; j++)
                        if (i == frames2[j])
                            AudioSource.PlayClipAtPoint(clips2[j], audioS.position);
                    if (i == animFrame2)
                        if (anim2)
                            animator.SetInteger("switch", 1);
                    if (i > end2)
                        next.NextScene(nexts);
                    break;

                case 2:
                    for (int j = 0; j < frames3.Length; j++)
                        if (i == frames3[j])
                            AudioSource.PlayClipAtPoint(clips3[j], audioS.position);
                    if (i == animFrame3)
                        if (anim3)
                            animator.SetInteger("switch", 1);
                    if (i > end3)
                        next.NextScene(nexts);
                    break;

                case 3:
                    for (int j = 0;j < frames4.Length; j++)
                        if(i == frames4[j])
                            AudioSource.PlayClipAtPoint(clips4[j], audioS.position);
                    if (i == animFrame4)
                        if (anim4)
                            animator.SetInteger("switch", 1);
                    if (i > end4)
                        next.NextScene(nexts);
                    break;
            }

        }
    }
}
