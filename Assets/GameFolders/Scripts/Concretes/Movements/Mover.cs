using CouseGame_1.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CourseGame_1.Movements
{
    public class Mover
    {
        PlayerController _playerController;
        Rigidbody _rb;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rb = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(bool movePressed)
        {
            if (movePressed)
            {
                _rb.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.MoveForce);
            }
        }  
    }
}
