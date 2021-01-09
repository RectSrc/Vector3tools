using System;
using System.Numerics;
using System.Reflection;
namespace v3t
{
    public static class v3t
    {

        public class v3t
        {

            public float x;
            public float y;
            public float z;

            public Vector3()
            {
                x = 0.0f;
                y = 0.0f;
                z = 0.0f;
            }
            public Vector3(float _x, float _y, float _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }

        }

        public static float[] Forward(float[] dir)
        {
            return new float[] { dir[0] * 1, dir[1] * 0, dir[2] * 1 };
        }

    }

}


public class Vector3
{

    public float x;
    public float y;
    public float z;

    public Vector3()
    {
        x = 0.0f;
        y = 0.0f;
        z = 0.0f;
    }
    public Vector3(float _x, float _y, float _z)
    {
        x = _x;
        y = _y;
        z = _z;
    }

}
