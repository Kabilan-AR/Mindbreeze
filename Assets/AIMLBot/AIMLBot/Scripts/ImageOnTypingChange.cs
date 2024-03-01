using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageOnTypingChange : MonoBehaviour {

    public Sprite OnTyping;
    public Sprite OnClear;
    public InputField input;
    public Image TargetImage;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (input.text != "")
        {
            TargetImage.sprite = OnTyping;
        }
        else
        {
            TargetImage.sprite = OnClear;
        }
	}
}
