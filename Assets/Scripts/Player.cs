using System;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour, ICharacter
{
  
    private Controls _controls;
    
    public float Speed { get; set; }

    public float Health { get; set; }
    
    public float AttackDamage { get; set; }
    public float AttackSpeed { get; set; }
    
    private void Awake()
    {
        Speed = 5;
        _controls = new Controls();
    }

    private void FixedUpdate()
    {
       
            var direction = _controls.Player.Movement.ReadValue<float>();
            Debug.Log(direction);
            var x = direction;

            if (x < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (x > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            x *= Time.deltaTime * Speed;

            transform.Translate(Math.Abs(x), 0, 0);

    }

    private void OnEnable()
    {
        _controls.Player.Enable();
        
    }

    private void OnDisable()
    {
        _controls.Player.Disable();
    }
}
 
