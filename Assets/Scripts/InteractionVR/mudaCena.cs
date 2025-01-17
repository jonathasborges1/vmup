﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VMUP.CameraFade;
using VMUP.Scenes;

public class mudaCena : InteractiveObject
{
    public InteractiveObject interactiveObject
    {
        get
        {
            return transform.GetComponent<InteractiveObject>();
        }
    }

    public Rigidbody rb
    {
        get
        {
            return transform.GetComponent<Rigidbody>();
        }
    }

    public BoxCollider bc
    {
        get
        {
            return transform.GetComponent<BoxCollider>();
        }
    }

    void OnEnable()
    {
        interactiveObject.OnClicked += muda;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void muda()
    {
        SceneManager.LoadScene(Instructions.instance.nextScene);

        //CameraFade.instance.CameraFadesOutFollowFadeInExternal(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(Instructions.instance.nextScene);
    }
}