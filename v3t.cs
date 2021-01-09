using System;
using System.Numerics;
using System.Reflection;
namespace v3t
{
    public static class v3t
    {

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

        public static Vector3 Forward(Vector3 dir)
        {
            Vector3 rot = new Vector3();
            rot.y = Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * rot.x), 10));
            rot.x = Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * rot.x), 10));
            return rot;
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
