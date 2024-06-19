using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CourseGame_1.Movements
{
    public class Mover
    {
        Rigidbody _rb;

        public Mover(Rigidbody rigidbody)
        {
            _rb = rigidbody;
        }

        public void FixedTick(bool movePressed)
        {
            if (movePressed)
            {
                _rb.AddRelativeForce(Vector3.up * Time.deltaTime * 75f);
            }
        }  
    }
}
