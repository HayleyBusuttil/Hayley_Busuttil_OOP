using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
{
    //Adding to the class
    private int barkingLevel;

    //parameterless constructor 
    public Dog()
    {
        //This will be used to create an empty object
    }

    //Constructor
    public Dog(string name, int age, int happinessLevel, int energyLevel,int barkingLevel):base(name, age, happinessLevel, energyLevel)
    {
        this.barkingLevel = barkingLevel;
    }

    //Getter and setters for barking level
    public int GetBarkingLevel()
    {
        return barkingLevel;
    }
    public void SetBarkingLevel(int NewBarkingLevel)
    {
        barkingLevel = NewBarkingLevel;
    }

    public override void Play()
    {
        SetEnergyLevel(GetEnergyLevel() - 1);
        SetHappinessLevel(GetHappinessLevel() + 2);
    }

    public int AgeConversion()
    {
        return GetAge() * 7;
    }

    //the new keyword means we are rewriting a method 
    //that already exists in the parent class
    public new string GetInfo()
    {
        return base.GetInfo() +
               "\nBarking Level: " + barkingLevel;
    }
}
