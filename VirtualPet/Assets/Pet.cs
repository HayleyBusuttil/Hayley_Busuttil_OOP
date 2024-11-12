using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Pet //remove the monobehavior
{
    //Creating  the class for the pet
    private string name;
    private int age;
    private int happinessLevel;
    private int energyLevel;

    //parameterless constructor 
    public Pet()
    {
        //This will be used to create an empty object
    }

    //constructors - same name as a class and has no return type
    public Pet(string name, int age, int happinessLevel, int energyLevel) 
    { 
        this.name = name;
        this.age = age;
        this.happinessLevel = happinessLevel;
        this.energyLevel = energyLevel;
    }

    //getter and setters; so that you can access the varibales from other classes;
    //Getter and setters for name
    public string GetName()
    {
        return name;
    }
    public void SetName(string NewName)
    {
        name = NewName;
    }

    //Getter and setters for Age
    public int GetAge()
    {
        return age;
    }
    public void SetAge(int NewAge)
    {
        if (NewAge>=0)
            age = NewAge;
    }

    //Getter and setters for happiness level
    public int GetHappinessLevel()
    {
        return happinessLevel;
    }
    public void SetHappinessLevel(int NewHappinessLevel)
    {
        happinessLevel = NewHappinessLevel;
    }

    //Getter and setters for energylevel
    public int GetEnergyLevel()
    {
        return energyLevel;
    }
    public void SetEnergyLevel(int NewEnergyLevel)
    {
        energyLevel = NewEnergyLevel;
    }

    //abstract method - only a mentioned method
    public abstract void Play();

    public void Feed() //the method is public - so that it can be accessed through other scripts(access-level)
                       //void-this method does not reeturn a value it changes some variables(method returns)
    {
        //When the pet is fed both the pet's happiness and energy increase by one
        energyLevel += 1;
        happinessLevel += 1;
    }


    public void Sleep()
    {
        energyLevel += 1;
    }

    public string GetInfo()
    {
        return "Name: " + name +
               "\nAge: " + age +
               "\nHappiness Level: " + happinessLevel +
               "\nEnergy Level: " + energyLevel;
    }

}
