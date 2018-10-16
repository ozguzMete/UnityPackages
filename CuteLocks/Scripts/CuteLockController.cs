/*
    CUTE LOCKS (UNITY PACKAGE), a simple lock animation with an 'unlock me' animation
    Copyright (C) 2018  METE OZGUZ

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CuteLocks
{

    public class CuteLockController : MonoBehaviour
    {

        public bool playAnimation = false;
        public GameObject Animation;

        private Animator animator;
        // Use this for initialization
        void Start()
        {
            animator = Animation.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (playAnimation)
            {
                    playAnimation = false;
                    animator.SetTrigger("MoveAndClick");                
            }
        }

    }
}
