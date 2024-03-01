using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public string theText;
    public GameObject ourNote;
    public GameObject placeholder;
    void Start()
    {
        theText=PlayerPrefs.GetString("NoteContents");
        placeholder.GetComponent<InputField>().text = theText;
    }

    // Update is called once per frame
    public void SaveToLoad()
    {
        theText=ourNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("NoteContents", theText);
    }
}
