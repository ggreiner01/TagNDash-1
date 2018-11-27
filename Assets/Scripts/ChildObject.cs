using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChildObject : MonoBehaviour
{
    private bool canWalk;
    private bool isBreathing;
    private int breathingRate;
    private bool hasPulse;
    private int pulse;//rate for their pulse
    private bool canRespond;
    private bool doesRepositionAirwayWork;
    private bool doesRescueBreathsWork;
    private bool canUnderstand;
    private String tagGiven;
    private String tagGuessed;
    private bool isTaggingCorrect;

    public void CreateChild(string colorTag)//Only pass this method the color of the tags
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

    public void CreateChild()
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
        this.canWalk = false;
        this.isBreathing = RandomTrueOrFalse();
        if (this.isBreathing)
        {
            this.breathingRate = BreathingRateRandomized();
        }
        else
        {
            this.breathingRate = 0;
        }
        this.hasPulse = RandomPulseBool();
        if (this.hasPulse)
        {
            this.pulse = NormalChildPulseGenerator();
        }
        else
        {
            this.pulse = 0;
        }
        this.canRespond = RandomTrueOrFalse();
        if (this.isBreathing)
        {
            this.doesRepositionAirwayWork = false;//this should be what forces a refactor of the breathing rate
        }
        else
        {
            this.doesRepositionAirwayWork = RandomTrueOrFalse();//this should be what forces a refactor of the breathing rate
        }
        if (this.doesRepositionAirwayWork)
        {
            this.doesRescueBreathsWork = false;//this should be what forces a refactor of the breathing rate
        }
        else
        {
            this.doesRescueBreathsWork = true;//this should be what forces a refactor of the breathing rate
        }
    }

    private void CreateYellow()
    {
        this.canWalk = false;
        this.isBreathing = true;
        this.breathingRate = NormalChildBreathing();
        this.hasPulse = true;
        this.pulse = NormalChildPulseGenerator();
        this.canRespond = true;
        this.doesRepositionAirwayWork = false;//this should be what forces a refactor of the breathing rate
        this.doesRescueBreathsWork = false;//this should be what forces a refactor of the breathing rate
        this.canUnderstand = true;
    }

    private void CreateGreen()
    {
        this.canWalk = true;
        this.isBreathing = true;
        this.breathingRate = NormalChildBreathing();
        this.hasPulse = true;
        this.pulse = NormalChildPulseGenerator();//average pulse values for children 75-115 or 70-110
        this.canRespond = true;
        this.doesRepositionAirwayWork = false;//this should be what forces a refactor of the breathing rate
        this.doesRescueBreathsWork = true;//this should be what forces a refactor of the breathing rate
        this.canUnderstand = true;
    }

    private void CreateBlack()
    {
        this.canWalk = false;
        this.isBreathing = false;
        this.breathingRate = 0;//not breathing
        this.hasPulse = RandomPulseBool();
        if (this.hasPulse)
        {
            this.pulse = NormalChildPulseGenerator();
        }
        else
        {
            this.pulse = 0;
        }
        this.canRespond = false;
        this.doesRepositionAirwayWork = false;//this should be what forces a refactor of the breathing rate
        this.doesRescueBreathsWork = false;//this should be what forces a refactor of the breathing rate
        this.canUnderstand = false;
    }

    private int BreathingRateRandomized()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(2);

        switch (randomNumber)
        {
            case 0:
                return NormalChildBreathing();
            case 1:
                return AbnormalChildBreathing();
            default:
                return 0;
        }

    }

    private bool RandomTrueOrFalse()
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
                return false;
        }
    }

    private bool RandomPulseBool()
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
                return false;
        }
    }

    private int NormalChildPulseGenerator()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(5);
        int value;

        switch (randomNumber)
        {
            case 0:
                value = 75;
                break;
            case 1:
                value = 85;
                break;
            case 2:
                value = 95;
                break;
            case 3:
                value = 105;
                break;
            case 4:
                value = 115;
                break;
            default:
                value = -1;
                break;
        }

        return value;
    }

    private int NormalChildBreathing()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(2);
        int value;

        switch (randomNumber)
        {
            case 0://25
                value = 25;
                break;
            case 1://36
                value = 36;
                break;
            default://should not be reachable
                value = -1;
                break;
        }

        return value;
    }

    private int AbnormalChildBreathing()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(3);
        int value;

        switch (randomNumber)
        {
            case 0://8
                value = 8;
                break;
            case 1://12
                value = 12;
                break;
            case 2://52
                value = 52;
                break;
            default://should not be reachable
                value = -1;
                break;
        }

        return value;
    }

    public void RepositionedTheAirway()
    {
        if (this.doesRepositionAirwayWork)
        {
            this.breathingRate = NormalChildBreathing();
        }
        else
        {
            //do nothing
        }

    }

    public void GaveRescueBreaths()
    {
        if (this.doesRescueBreathsWork)
        {
            this.breathingRate = NormalChildBreathing();
        }
        else
        {
            //do nothing
        }
    }

    public int CheckBreathingRate()
    {
        return this.breathingRate;
    }

    public int CheckPulse()
    {
        return this.pulse;
    }

    public bool CanUnderstand()
    {
        return this.canUnderstand;
    }

    public bool CanRespond()
    {
        return this.canRespond;
    }

    public void SetTagGussed(String color)
    {
        this.tagGuessed = color;
    }

    public string GetTagGussed()
    {
        return this.tagGuessed;
    }
    public int GetBreathingRate()
    {
        return this.breathingRate;
    }

    // Use this for initialization
    void Start()
    {
        this.CreateChild();
    }

    // Update is called once per frame
    void Update()
    {

    }
}