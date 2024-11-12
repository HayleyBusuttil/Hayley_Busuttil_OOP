using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // import for UI
using TMPro; // import for text
using JetBrains.Annotations;

public class MainScript : MonoBehaviour
{
    //declare a variable with the new classes
    Dog d; //using dog as a datatype
    Bird b; //using bird as a datatype
    public TextMeshProUGUI dogInfo, birdInfo; //The textbox
    public Button PlayBtnBird, FeedBtnBird, SleepBtnBird;
    public Button PlayBtnDog, FeedBtnDog, SleepBtnDog;
    public Button PlayWithAll;
    List<Pet> pets = new List<Pet>(); //Creating a list

    // Start is called before the first frame update
    void Start()
    {
        d = new Dog("Ginger",1,5,5,5); //creating a new object dog
        pets.Add(d); // adding the dog to the list
        //inserting all the properties  with the parameterless constructor
        //d = new Dog()
        //d.SetName("Ginger");
        //d.SetAge(1);
        //d.SetHappinessLevel(5);
        //d.SetEnergyLevel(5);
        //d.SetBarkingLevel(5);


        b = new Bird("Skye", 3, 5, 5, 0); //creating a new object bird
        pets.Add(b); // adding the bird to the list
        //inserting all the properties with the parameterless constructor
        //b = new Bird()
        //b.SetName("Skye"); 
        //b.SetAge(3);
        //b.SetHappinessLevel(5);
        //b.SetEnergyLevel(5);
        //b.SetWingSpan(0);

        PlayBtnBird.GetComponent<Button>().onClick.AddListener(birdPlayEvent);
        FeedBtnBird.GetComponent<Button>().onClick.AddListener(birdFeedEvent);
        SleepBtnBird.GetComponent<Button>().onClick.AddListener(birdSleepEvent);

        PlayBtnDog.GetComponent<Button>().onClick.AddListener(dogPlayEvent);
        FeedBtnDog.GetComponent<Button>().onClick.AddListener(dogFeedEvent);
        SleepBtnDog.GetComponent<Button>().onClick.AddListener(dogSleepEvent);

        PlayWithAll.GetComponent<Button>().onClick.AddListener(playAllEvent);
    }
    //Bird
    void birdPlayEvent()
    {
        b.Play();
    }
    void birdFeedEvent()
    {
        b.Feed();
    }
    void birdSleepEvent()
    {
        b.Sleep();
    }

    //Dog
    void dogPlayEvent()
    {
        d.Play();
    }
    void dogFeedEvent()
    {
        d.Feed();
    }
    void dogSleepEvent()
    {
        d.Sleep();
    }

    void playAllEvent()
    {
        foreach(Pet pet in pets)
        {
            pet.Play(); //polymorphism - You are treating the children the smae yet they are reacting differntly
        }
    }

    // Update is called once per frame
    void Update()
    {
        dogInfo.text = d.GetInfo();
        birdInfo.text = b.GetInfo();
    }
}
