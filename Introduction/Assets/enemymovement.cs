using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public float Speed = 5;
    private Transform _playerTransform;
    private Transform _enemyTransform;

    // Called on startup of the GameObject it's assigned to.
    void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        if (!player)
        {
            Debug.LogError("Could not find the main player");
        }
        else
        {
            _playerTransform = player.transform;
        }
        // Grab a reference to our transform for use later.
        _enemyTransform = this.transform;
    }
    // Called every frame. The frame rate varies every second.
    void Update()
    {
        // I am setting how fast I should move toward the "player"
        // per second. In Unity, one unit is a meter.
        // Time.deltaTime gives the amount of time since the last frame.
        // If you're running 60 FPS (frames per second) this is 1/60 = 0.0167,
        // so w/Speed=2 and frame rate of 60 FPS (frame rate always varies
        // per second), I have a movement amount of 2*0.0167 = .033 units
        // per frame. This is 2 units.
        var moveAmount = Speed * Time.deltaTime;
        print(Time.deltaTime);
        // Update the position, move toward the player's position by moveAmount.
        _enemyTransform.position = Vector3.MoveTowards(_enemyTransform.position, _playerTransform.position, moveAmount);
    }
}