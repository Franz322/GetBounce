using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] AudioSource sfxSource;

    public AudioClip bounceSfx;

    public void PlayBounceSFX()
    {
        sfxSource.PlayOneShot(bounceSfx);
    }
}
