using System;
using System.Numerics;
using System.Reflection;
namespace v3t
{
    public static class vector3tools
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

        public static object Forward(object _dir)
        {
            Vector3 dir = (Vector3)_dir;
            float y = Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.x), 10));
            if (y > 0 && Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10)) > 0)
                y *= Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10));
            else
                y += Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10));
            float x = Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.x), 10));
            if (x > 0 && Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.y), 10)) > 0)
                x *= Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.y), 10));
            else
                x += Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.y), 10));
            float z = Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.y), 10));
            if (z > 0 && Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10)) > 0)
                z *= Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10));
            else
                z += Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10));


            return new Vector3(x, y, z);
        }
    }

}
