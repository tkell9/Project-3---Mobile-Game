using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteAnim : MonoBehaviour {

    //File location of the frames in the resources folder
    public string location;
    private SpriteRenderer spr;
    private Sprite[] sprites;

    //Bool to loop the animation infinitely.
    private bool loop = true;

    //public to speed-up or slow-down the animation in the editor.
    public float secPerFrame = 0.25f;

    private int frame = 0;
    private float deltaTime = 0;
   

	void Start ()
    {
        spr = GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(location);
	}
	

	void Update ()
    {
        //Time tracker. I dont know the c# equivalent of #define
        deltaTime += Time.deltaTime;

        //Loop for multiple sprite frame jumping in single update cell.

        while (deltaTime >= secPerFrame)
        {
            deltaTime -= secPerFrame;
            frame++;
            if (loop)
            {
                frame %= sprites.Length;
            }

            else if (frame >= sprites.Length)
            {
                frame = sprites.Length - 1;

            }

            spr.sprite = sprites[frame];
                    
        }
	}
}
