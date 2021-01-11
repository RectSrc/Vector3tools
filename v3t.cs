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
            rot.y = Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.x), 10));
            if (rot.y > 0 && Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10)) > 0)
                rot.y *= Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10));
            else
                rot.y += Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10));
            rot.x = Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.x), 10));
            if (rot.x > 0 && Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.y), 10)) > 0)
                rot.x *= Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.y), 10));
            else
                rot.x += Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.y), 10));
            rot.z = Convert.ToSingle(Math.Round(Math.Sin(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.y), 10));
            if (rot.z > 0 && Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10)) > 0)
                rot.z *= Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10));
            else
                rot.z += Convert.ToSingle(Math.Round(Math.Cos(((Convert.ToSingle(Math.PI) * 2f) / 360f) * dir.z), 10));


            return rot;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine(Forward(new Vector3(0, 90, 90)).z);

        }

    }

}
