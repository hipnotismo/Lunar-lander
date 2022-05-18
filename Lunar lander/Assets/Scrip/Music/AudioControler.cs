using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour
{

    [SerializeField] private AudioSource _music;
    public static AudioControler inst;

    private void Awake()
    {
        if (AudioControler.inst == null)
        {
            AudioControler.inst = this;
            DontDestroyOnLoad(gameObject);
            _music = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
