using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Model
{
    public class NloArmy : Nlo
    {
        public NloArmy(Vector2 position, float speed) : base(null, position, speed) { }

        public void SetTarget(Transformable newTarget)
        {
            _target = newTarget;
        }

        public override void Update(float deltaTime)
        {
            if (_target == null) return;
            base.Update(deltaTime);
        }

    }
}
