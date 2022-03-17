using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLIDDES.Quaternions;

namespace SLIDDES.Quaternions.Samples
{
    [ExecuteInEditMode]
    public class QuaternionsExamples : MonoBehaviour
    {
        public float rotateSpeed = 10;

        [Header("Rotate Towords Target On X")]
        public Transform rotateTowordsTargetX;
        public Transform rotateTowordsTargetXTarget;
        [Header("Rotate Towords Target On Y")]
        public Transform rotateTowordsTargetY;
        public Transform rotateTowordsTargetYTarget;
        [Header("Rotate Towords Target On Z")]
        public Transform rotateTowordsTargetZ;
        public Transform rotateTowordsTargetZTarget;
        [Header("Rotate Towords Target")]
        public Transform rotateTowordsTarget;
        public Transform rotateTowordsTargetTarget;
        [Header("Rotate")]
        public Transform rotate;
        public Transform rotateX;
        public Transform rotateY;
        public Transform rotateZ;
        [Header("2D")]
        public Transform rotate2D;
        public Transform rotate2DTarget;

        private float speed;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            speed = rotateSpeed * Time.deltaTime;
            Rotate();
            Rotate2D();
            RotateTowordsTargetOnAxis();
        }

        public void Rotate()
        {
            Quat.Rotate(rotate, new Vector3(1, 1, 1), speed);
            Quat.RotateOnAxisX(rotateX, speed);
            Quat.RotateOnAxisY(rotateY, speed);
            Quat.RotateOnAxisZ(rotateZ, speed);
        }

        public void RotateTowordsTargetOnAxis()
        {
            // X axis
            Quat.RotateTowordsOnAxisX(rotateTowordsTargetX, rotateTowordsTargetXTarget);
            // Y axis
            Quat.RotateTowordsOnAxisY(rotateTowordsTargetY, rotateTowordsTargetYTarget);
            // Z axis
            Quat.RotateTowordsOnAxisZ(rotateTowordsTargetZ, rotateTowordsTargetZTarget);
            // All
            Quat.RotateTowords(rotateTowordsTarget, rotateTowordsTargetTarget, 10 * Time.deltaTime);
        }

        public void Rotate2D()
        {
            Quat.RotateTowords2D(rotate2D, rotate2DTarget, speed);
        }
    }
}
