using CourseGame_1.Inputs;
using CourseGame_1.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CouseGame_1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnSpeed = 75f;
        [SerializeField] float _moveForce = 75f;

        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;

        bool _isForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float MoveForce => _moveForce;

        private void Awake()    
        {   
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
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

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            _mover.FixedTick(_isForceUp);
            _rotator.FixedTick(_leftRight);
        }
    }
}