using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Model
{
    public class Health
    {
        public Health() => _hp = 3;

        public Health(uint hp)
        {
            // HP must belong from 0 to 5
            if (hp > 5) return;

            _hp = hp;
        }
        private uint _hp = 3;

        public uint GetHP() => _hp;

        public void RemoveHP(uint value)
        {
            // HP remove vale must belong from 0 to 5

            if (_hp < 1) return;
            if (value > 5) return;
            if (_hp - value < 0) return;

            _hp -= value;
            Debug.Log(_hp);
        }
    }
}
