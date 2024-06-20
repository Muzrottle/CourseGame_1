using CouseGame_1.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CourseGame_1.Movements
{
    public class Rotator
    {
        PlayerController _playerController;
        Rigidbody _rb;

        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rb = _playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {
            if (direction == 0)
            {
                if (_rb.freezeRotation) _rb.freezeRotation = false;

                return;
            }

            if (!_rb.freezeRotation) _rb.freezeRotation = true;

            _rb.transform.Rotate(Vector3.back * Time.deltaTime * direction * _playerController.TurnSpeed);
        }
    }
}
