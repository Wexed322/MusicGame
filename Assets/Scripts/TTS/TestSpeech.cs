using UnityEngine;
using UnityLibrary;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class TestSpeech : MonoBehaviour
{
    public string sayAtStart = "Welcome!";
    public TMP_InputField textFieldText;

    public string dialog;



    //test
    //public AudioClip currentClip;


    void Start()
    {
        // TEST speech
        Speech.instance.Say(sayAtStart, TTSCallback);

    }

    // Update is called once per frame
    void Update()
    {
        // test pressing any keys to say that character
        /*if (Input.anyKeyDown)
        {
            //Speech.instance.Say(Input.inputString, TTSCallback);
            Speech.instance.Say("ME PICA LA MANOOOO HUGO", TTSCallback);
        }*/

    }

    //TEST
    //public IEnumerator effectoAumentarVolumen(AudioSource audioSource, float tiempo) 
    //{
    //    float incremento = tiempo / 100;
    //    while (audioSource.volume != 1)
    //    {
    //        yield return new WaitForSeconds(incremento);
    //        audioSource.volume += incremento;
    //    }
    //}

    public void getDialog() 
    {
        //Debug.Log("get");
        dialog = textFieldText.text;
    }

    public void talk() 
    {
        Speech.instance.Say(dialog, TTSCallback);

    }

    void TTSCallback(string message, AudioClip audio) {
        AudioSource source = GetComponent<AudioSource>();
        if(source == null) {
            source = gameObject.AddComponent<AudioSource>();
        }

        //TEST
        //currentClip = audio;
        //StartCoroutine(effectoAumentarVolumen(source, 10));
        


        source.clip = audio;
        source.Play();
    }


}
