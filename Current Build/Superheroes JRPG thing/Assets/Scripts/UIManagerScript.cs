﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour {

    [SerializeField]
    private Canvas theCanvas;
    [SerializeField]
    private GameObject portraitLocation;

    [SerializeField]
    private Image talkImg;
    private Image characterPortrait;

    private static UIManagerScript UIManagerInstance;

    private void Awake()
    {
        if (UIManagerInstance == null)
            UIManagerInstance = this;
        else
            Destroy(gameObject);
    }

    public void CreateTalkIcon()
    {
       
        Image talkImgTemp = (Image)Instantiate(talkImg, theCanvas.transform);
        talkImgTemp.transform.SetParent(theCanvas.transform);
        talkImgTemp.name = "temp";
        talkImgTemp.transform.SetPositionAndRotation(new Vector3(theCanvas.transform.position.x - 8.2f, theCanvas.transform.position.y - 4.5f, 0), new Quaternion(0, 180, 0, 0));

    }

    public void DestroyTalkIcon()
    {
        Destroy(GameObject.Find("temp"));
    }

    public void CreateCharacterPortrait(Image character)
    {
        Image currentCharacter = (Image)Instantiate(character, portraitLocation.transform);
        currentCharacter.transform.SetParent(portraitLocation.transform);
        currentCharacter.name = "CharacterPortrait";
    }


}
