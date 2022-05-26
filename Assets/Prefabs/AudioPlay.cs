using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource SoundEff;

    private void OnCollisionEnter(Collision collison)
    {
    	SoundEff.Play();
    }
}
