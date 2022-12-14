using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioPlayer : MonoBehaviour
{
    public List<AudioClip> canciones;
    public AudioSource audioSourceReference;
    public Slider music_SLIDER;
    public TextMeshProUGUI tiempoCancion_TEXTO;


    public float playTime;
    public float seconds;
    public float minutes;

    public float TOTALseconds;
    public float TOTALminutes;


    //controladores
    public bool pausaBool;
    public bool onFocusBool;
    void Start()
    {
        audioSourceReference.clip = canciones[0];
        playTime = canciones[0].length;


        TOTALminutes = (int)(playTime / 60);
        TOTALseconds = (int)(playTime % 60);

        
    }

    void Update()
    {
        onFocus();
        setText();
    }

    public void debuggg(string a) 
    {
        Debug.Log(a);
    }
    public void clickingSlider() 
    {
        onFocusBool = true;
    }

    public void notClickingSlider() 
    {
        onFocusBool = false;
    }
    public void onFocus() 
    {
        if (onFocusBool)
        {
            audioSourceReference.time = music_SLIDER.value*playTime;

            audioSourceReference.volume = 0;
        }
        else 
        {
            music_SLIDER.value = audioSourceReference.time / playTime;

            audioSourceReference.volume = 0.35f;
        }
    }
    public void pause() 
    {
        pausaBool = !pausaBool;
        if (pausaBool) 
        {
            audioSourceReference.Pause();
        }
        else 
        {
            audioSourceReference.UnPause();
        }
    }
    public void play() 
    {
        audioSourceReference.Play();
    }

    public void setText() 
    {
        minutes = (int)(audioSourceReference.time / 60);
        seconds = (int)(audioSourceReference.time % 60);

        tiempoCancion_TEXTO.text = string.Format("{0}:{1}/{2}:{3}", minutes.ToString("00"), seconds.ToString("00"), TOTALminutes.ToString("00"), TOTALseconds.ToString("00"));
    }
}
