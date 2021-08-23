using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrKGame
{

    /*summary : SoundManager is singleton class will manage the all sounds in game*/
    public class SoundManager : MonoBehaviour
    {

        public AudioSource soundEffect;
        public AudioSource soundMusic;
        public SoundType[] Sounds;

        private static SoundManager instance;
        public static SoundManager Instance { get { return instance; } }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }


        /*Start : In Start method, playing BG music from start with PlayMusic derived method*/

        private void Start()
        {
            PlayMusic(global::Sounds.BG_Music);
        }
   

        /*PlayMusic : In PlayMusic method, getting sound clip check for null and calls Play() built in unity method*/

        public void PlayMusic(Sounds sound)
        {
            AudioClip clip = getSoundClip(sound);
            if (clip != null)
            {
                soundMusic.clip = clip;
                soundMusic.Play();
            }
            else
            {
                Debug.LogError("Clip not found : " + sound);
            }

        }

        /*Play : In Play method, getting sound clip check for null and play with PlayOneShot() built in unity method*/
        public void Play(Sounds sound)
        {
            AudioClip clip = getSoundClip(sound);
            if (clip != null)
            {
                soundEffect.PlayOneShot(clip);
            }
            else
            {
                Debug.LogError("Clip not found : " + sound);
            }

        }

        /*getSoundClip : In getSoundClip method, getting soundtypes in array and check for required sound and returns, else returns null*/
        private AudioClip getSoundClip(Sounds sound)
        {
            SoundType item = Array.Find(Sounds, i => i.soundType == sound);
            if (item != null)
            {
                return item.SoundClip;
            }
            return null;
        }

    }// class


    /*SoundType : using SoundType Serializable class, for getting soundtype and sound clip from unity UI*/

    [Serializable]
    public class SoundType
    {
        public Sounds soundType;
        public AudioClip SoundClip;

    }// class

}


/*Sounds : using sound enum for different music types*/
public enum Sounds
{
    ButtonClick,
    BG_Music,
    CoinCollect,
    swipePlayer,
    GameOver
}

