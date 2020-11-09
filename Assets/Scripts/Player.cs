using System;
using UnityEngine;

[RequireComponent(typeof(PlayerMovementController))]
[RequireComponent(typeof(OffensiveCharacterAttribute))]
public class Player : MonoBehaviour, ICharacter
{
    //TODO: Add state memento for time travel
    public IMovementController MovementController { get; private set; }
    public ICharacterAttributes CharacterAttributes { get; private set; }

    private void Awake()
    {
        MovementController = GetComponent<IMovementController>() ?? gameObject.AddComponent<PlayerMovementController>();
        CharacterAttributes = GetComponent<ICharacterAttributes>() ?? gameObject.AddComponent<OffensiveCharacterAttribute>();
    }

    private void FixedUpdate()
    {
        MovementController.Move();
    }
}