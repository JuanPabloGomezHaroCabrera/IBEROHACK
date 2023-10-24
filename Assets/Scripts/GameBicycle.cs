using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameBicycle : MonoBehaviour
{
    //Sprites for every animation
    public SpriteRenderer[] hairs;
    public SpriteRenderer[] skins;
    public SpriteRenderer[] tshirts;
    public SpriteRenderer[] pants;
    //Canva
    public GameObject panel;
    public GameObject info;
    public TextMeshProUGUI energy;
    private float energyGenerated;
    //Objects
    public GameObject clouds;
    public GameObject buildings;
    public GameObject lines;

    private GameObject objPermanent;
    private Information informationCode;

    private Animator _animator;

    private bool isStop;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        objPermanent = GameObject.Find("ObjectPermanent");
        informationCode = objPermanent.GetComponent<Information>();
    }

    // Start is called before the first frame update
    void Start()
    {
        int i;
        for(i = 0; i < hairs.Length; i++)
        {
            hairs[i].color = informationCode.currentUser.hairColor;
        }
        for(i = 0; i < skins.Length; i++)
        {
            skins[i].color = informationCode.currentUser.skinColor;
        }
        for(i = 0; i < tshirts.Length; i++)
        {
            tshirts[i].color = informationCode.currentUser.tshirtColor;
        }
        for(i = 0; i < pants.Length; i++)
        {
            pants[i].color = informationCode.currentUser.pantsColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!isStop)
        {
            energyGenerated += 0.05f;
            energy.text = energyGenerated.ToString();
        }
    }

    public void StartRunning()
    {
        isStop = false;
        clouds.SetActive(true);
        buildings.SetActive(true);
        lines.SetActive(true);
        panel.SetActive(false);
        info.SetActive(true);
        _animator.Play("run");
    }

    public void Exit()
    {
        informationCode.SetCurrentUserEnergy(energyGenerated);
        informationCode.ChangeScene("Home");
    }

    public void Stop()
    {
        isStop = true;
        clouds.SetActive(false);
        buildings.SetActive(false);
        lines.SetActive(false);
        info.SetActive(false);
        panel.SetActive(true);
    }
}
