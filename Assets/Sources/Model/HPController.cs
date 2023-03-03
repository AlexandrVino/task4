using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Model
{
    public class HPController
    {
        private int _hp = 3;

        public int GetHP() => _hp;
        public void RemoveHP(int value) => _hp -= value;
        public void SetHP(int hp) => _hp = hp;

    }
}
