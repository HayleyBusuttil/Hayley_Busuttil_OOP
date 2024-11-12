using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird : Pet
{
    //Adding to the class
    private int wingSpan;

    //parameterless constructor 
    public Bird()
    {
        //This will be used to create an empty object
    }

    //Constructor
    public Bird(string name, int age, int happinessLevel, int energyLevel, int wingSpan) : base(name, age, happinessLevel, energyLevel)
    {
        this.wingSpan = wingSpan;
    }

    //Getter and setters for Wing span
    public int GetWingSpan()
    {
        return wingSpan;
    }

    public void SetWingSpan(int NewWingSpan)
    {
        wingSpan = NewWingSpan;
    }

    public override void Play()
    {
        SetEnergyLevel(GetEnergyLevel() - 2);
        SetHappinessLevel(GetHappinessLevel() + 1);
    }

    public int AgeConversion()
    {
        return GetAge() * 10;
    }

    //the new keyword means we are rewriting a method 
    //that already exists in the parent class
    public new string GetInfo()
    {
        return base.GetInfo() +
               "\nWing Span: " + wingSpan;
    }
}
