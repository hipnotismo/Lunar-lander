using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour
{

    [SerializeField] private AudioSource _music;
    public static AudioControler inst;
    [SerializeField] private GameObject ActiveMusic;
    [SerializeField] private GameObject SilentMusic;
    public bool isActive = true;

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

    public static void Pause( )
    {
        inst.isActive = false;
        if (inst.isActive == false)
        {
            inst.ActiveMusic.SetActive(false);
            inst.SilentMusic.SetActive(true);
        }
        inst._music.Pause();
    }

    public static void Resume()
    {
        inst.isActive = true;
        if (inst.isActive == true)
        {
            inst.ActiveMusic.SetActive(true);
            inst.SilentMusic.SetActive(false);
        }
        inst._music.UnPause();
    }

 
}
