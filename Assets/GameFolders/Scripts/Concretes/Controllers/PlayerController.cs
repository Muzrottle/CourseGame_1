using CourseGame_1.Inputs;
using CourseGame_1.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CouseGame_1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        DefaultInput _input;
        Mover _mover;

        bool _isForceUp;

        private void Awake()
        {   
            _input = new DefaultInput();
            _mover = new Mover(GetComponent<Rigidbody>());
        }

        private void Update()
        {
            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
        }

        private void FixedUpdate()
        {
            _mover.FixedTick(_isForceUp);
        }
    }
}