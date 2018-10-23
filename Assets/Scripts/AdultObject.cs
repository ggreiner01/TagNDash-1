using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class AdultObject : MonoBehaviour {
    private bool canWalk;
    private bool isBreathing;
    private int breathingRate;
    private int cappilaryRefill;//maximum number of seconds it takes
    private bool canRespond;
    private bool doesRepsoitionAirwayWork;
    private bool canUnderstand;
    private String tagGiven;
    private String tagGuessed;
    private bool isTaggingCorrect;

    public void CreateAdult(string colorTag)//Only pass this method the color of the tags
    {
        colorTag = colorTag.ToLower();
        switch (colorTag)
        {
            //these go to a method to create the object to the standard of the color
            case "red":
                this.tagGiven = "red";
                CreateRed();
                break;
            case "yellow":
                this.tagGiven = "yellow";
                CreateYellow();
                break;
            case "green":
                this.tagGiven = "green";
                CreateGreen();
                break;
            case "black":
                this.tagGiven = "black";
                CreateBlack();
                break;
            default:
                break;
        }
    }

    public void CreateAdult()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(4);
        switch (randomNumber)
        {
            //these go to a method to create the object to the standard of the color
            case 0://red
                this.tagGiven = "red";
                CreateRed();
                break;
            case 1://yellow
                this.tagGiven = "yellow";
                CreateYellow();
                break;
            case 2://green
                this.tagGiven = "green";
                CreateGreen();
                break;
            case 3://black
                this.tagGiven = "black";
                CreateBlack();
                break;
            default:
                break;
        }
    }

    private void CreateRed()
    {
        System.Random rnd = new System.Random();
        int randomNumber;

        this.canWalk = false;
        this.isBreathing = IsBreathingRandomized();
        if (this.isBreathing)
        {
            randomNumber = rnd.Next(2);
            switch (randomNumber)
            {
                case 0://normal breathing
                    this.breathingRate = RandomBreathingBelowThirty();
                    break;
                case 1://abnormal breathing
                    this.breathingRate = RandomBreathingAboveThirty();
                    break;
            }
        }
        else
        {
            this.breathingRate = 0;//no breathing, should reposition airway
        }
        randomNumber = rnd.Next(2);
        switch (randomNumber)
        {
            case 0://normal cappilary refill
                this.cappilaryRefill = CappRefilRandom(1, 3);
                break;
            case 1://abnormal cappilary refill
                this.cappilaryRefill = CappRefilRandom(3, 6);
                break;
        }
        this.canRespond = true;
        this.doesRepsoitionAirwayWork = true;
        randomNumber = rnd.Next(2);
        switch (randomNumber)
        {
            case 0://they can understand
                this.canUnderstand = true;
                break;
            case 1://they cannot understand
                this.canUnderstand = false;
                break;
        }
    }
    private void CreateYellow()
    {
        this.canWalk = false;
        this.isBreathing = true;
        this.breathingRate = RandomBreathingBelowThirty();
        this.cappilaryRefill = CappRefilRandom(1, 3);// can be one or two seconds, charts dissagree with eachother
        this.canRespond = true;
        this.doesRepsoitionAirwayWork = false;//this should be what forces a refactor of the breathing rate
        this.canUnderstand = true;
    }
    private void CreateGreen()
    {
        this.canWalk = true;
        this.isBreathing = true;
        this.breathingRate = RandomBreathingBelowThirty();
        this.cappilaryRefill = CappRefilRandom(1, 3);// can be one or two seconds
        this.canRespond = true;
        this.doesRepsoitionAirwayWork = false;//this should be what forces a refactor of the breathing rate
        this.canUnderstand = true;

    }
    private void CreateBlack()
    {
        this.canWalk = false;
        this.isBreathing = false;
        this.breathingRate = 0;//no breathing
        this.cappilaryRefill = 0;// does not refill
        this.canRespond = false;
        this.doesRepsoitionAirwayWork = false;//this should be what forces a refactor of the breathing rate
        this.canUnderstand = false;
    }
    private bool IsBreathingRandomized()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(2);
        switch (randomNumber)
        {
            case 0:
                return true;
            case 1:
                return false;
            default:
                return true;
        }
    }
    private int CappRefilRandom(int lowBound, int highBound)
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(lowBound, highBound);
        return randomNumber;
    }
    private int RandomBreathingBelowThirty()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(3);
        int value;
        switch (randomNumber)
        {
            case 0:// 8 RPM
                value = 8;
                break;
            case 1:// 12 RPM
                value = 12;
                break;
            case 2:// 25 RPM
                value = 25;
                break;
            default:
                value = -1;
                break;
        }
        return value;
    }
    private int RandomBreathingAboveThirty()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(2);
        int value;
        switch (randomNumber)
        {
            case 0:// 36 RPM
                value = 36;
                break;
            case 1:// 52 RPM
                value = 52;
                break;
            default:
                value = -1;
                break;
        }
        return value;
    }
    public void RepositionedTheAirway()
    {
        if (this.doesRepsoitionAirwayWork)
        {
            this.breathingRate = RandomBreathingBelowThirty();
        }
        else
        {
            //nothing happends
        }
    }
    public int CheckAirway()
    {
        return this.breathingRate;
    }
    public int CheckCappilaryRefill()
    {
        return this.cappilaryRefill;
    }
    public bool CanUnderstand()
    {
        return this.canUnderstand;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
