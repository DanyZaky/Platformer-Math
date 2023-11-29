using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideHandler : MonoBehaviour
{
    public Image source;
    public Sprite[] images;

    public int currentIndex;

    private void Start()
    {
        currentIndex = 0;
        source.sprite = images[currentIndex];
    }

    public void NextButton()
    {
        if(currentIndex >= images.Length-1)
        {
            currentIndex = 0;
        }
        else
        {
            currentIndex++;
        }
        
        source.sprite = images[currentIndex];
    }

    public void BackButton()
    {
        currentIndex = 0;
        source.sprite = images[currentIndex];
    }
}
