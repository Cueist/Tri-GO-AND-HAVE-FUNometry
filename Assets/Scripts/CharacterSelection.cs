using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    private byte[] fileData;
    private int max = 6, min = 0, counter = 0;
    private Sprite[] profilepictures = new Sprite[7];
    public string UsName = "Öðrenci", Gender = "Male";
    public Button NextButton, Submitbutton;
    public Image imageToDisplay, MaleFrame, FemaleFrame;
    // Start is called before the first frame update
    void Start()
    {
        profilepictures[0] = Resources.Load<Sprite>("ProfilePictures/mrcamel");
        profilepictures[1] = Resources.Load<Sprite>("ProfilePictures/coolcamel");
        profilepictures[2] = Resources.Load<Sprite>("ProfilePictures/girlwithglasses");
        profilepictures[3] = Resources.Load<Sprite>("ProfilePictures/maleshadow");
        profilepictures[4] = Resources.Load<Sprite>("ProfilePictures/erenanime");
        profilepictures[5] = Resources.Load<Sprite>("ProfilePictures/baldestmanaliveanime");
        profilepictures[6] = Resources.Load<Sprite>("ProfilePictures/yokanime");
        imageToDisplay.sprite = profilepictures[counter];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPicture()
    {
        counter++;
        if (counter > max)
        {
            imageToDisplay.sprite = profilepictures[min];
            counter = min;
        }
        else
        {
            imageToDisplay.sprite = profilepictures[counter];
        }
        UnityEngine.Debug.Log("Next Image number = " + counter);
    }

    public void PreviousPicture()
    {
        counter--;
        if(counter < min)
        {
            imageToDisplay.sprite = profilepictures[max];
            counter = max;
        }
        else
        {
            imageToDisplay.sprite = profilepictures[counter];
        }
        UnityEngine.Debug.Log("Previous Image number = " + counter);
    }

    public void Upload()
    {
        string path = UnityEditor.EditorUtility.OpenFilePanel("Open image", "", "jpg,png,bmp");
        if (!System.String.IsNullOrEmpty(path))
        {
            fileData = File.ReadAllBytes(path);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(fileData);
            Rect rec = new Rect(0, 0, tex.width, tex.height);
            Sprite spriteToUse = Sprite.Create(tex, rec, new Vector2(0.5f, 0.5f), 100);
            imageToDisplay.sprite = spriteToUse;
        }
    }
    
    public void ReadStringInput(string name)
    {
        UsName = name;
        UnityEngine.Debug.Log("Username is set to = " + UsName);
        Submitbutton.interactable = true;
    }

    public void MaleSelection()
    {
        FemaleFrame.enabled = false;
        Gender = "Male";
        NextButton.interactable = true;
    }

    public void FemaleSelection()
    {
        MaleFrame.enabled = false;
        Gender = "Female";
        NextButton.interactable = true;
    }
}
