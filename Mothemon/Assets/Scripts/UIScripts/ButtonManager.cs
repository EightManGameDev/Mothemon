using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public SpriteRenderer ActiveTimSpriteRenderer;
    public Sprite Tim0;
    public Sprite Tim1;
    public Sprite Tim2;
    public Sprite Tim3;
    public Sprite Tim4; //sprite noch nicht da
    public Sprite Tim5;
    public Sprite Tim6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTim0()
    {
        ActiveTimSpriteRenderer.sprite = Tim0; 
        PlayerPrefs.SetInt("ActiveMothemon", 0);
    }
     public void ChangeTim1()
    {
        ActiveTimSpriteRenderer.sprite = Tim1; 
        PlayerPrefs.SetInt("ActiveMothemon", 1);
    }
    public void ChangeTim2()
    {
        ActiveTimSpriteRenderer.sprite = Tim2; 
        PlayerPrefs.SetInt("ActiveMothemon", 2);
    }
     public void ChangeTim3()
    {
        ActiveTimSpriteRenderer.sprite = Tim3; 
        PlayerPrefs.SetInt("ActiveMothemon", 3);
    }
     public void ChangeTim4()
    {
        ActiveTimSpriteRenderer.sprite = Tim4; 
        PlayerPrefs.SetInt("ActiveMothemon", 4);
    }
     public void ChangeTim5()
    {
        ActiveTimSpriteRenderer.sprite = Tim5; 
        PlayerPrefs.SetInt("ActiveMothemon", 5);
    }
      public void ChangeTim6()
    {
        ActiveTimSpriteRenderer.sprite = Tim6; 
        PlayerPrefs.SetInt("ActiveMothemon", 6);
    }
}
