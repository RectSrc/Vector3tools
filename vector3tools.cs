using System;
namespace vector3tools
{
    public static class vector3tools
    {

        public class Vector3
        {
            public float x;
            public float y;
            public float z;

            public Vector3(float _x, float _y, float _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }

            public static Vector3 Normalize(Vector3 vector)
            {
                float xy = Convert.ToSingle(Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2)));
                float len = Convert.ToSingle(Math.Sqrt(Math.Pow(xy, 2) + Math.Pow(vector.z, 2)));
                return new Vector3(vector.x / len, vector.y / len, vector.z / len);
            }

        }

        public class Quaternion
        {
            public float x;
            public float y;
            public float z;
            public float w;

            public Quaternion(float _x, float _y, float _z, float _w)
            {
                x = _x;
                y = _y;
                z = _z;
                w = _w;
            }
            public static Quaternion eulerToQuaternion(Vector3 euler)
            {
                double c1 = Math.Cos(euler.x / 2),
                  c2 = Math.Cos(euler.y / 2),
                  c3 = Math.Cos(euler.z / 2),
                  s1 = Math.Sin(euler.x / 2),
                  s2 = Math.Sin(euler.y / 2),
                  s3 = Math.Sin(euler.z / 2);
                float x = Convert.ToSingle(s1 * c2 * c3 + c1 * s2 * s3);
                float y = Convert.ToSingle(c1 * s2 * c3 - s1 * c2 * s3);
                float z = Convert.ToSingle(c1 * c2 * s3 + s1 * s2 * c3);
                float w = Convert.ToSingle(c1 * c2 * c3 - s1 * s2 * s3);

                return new Quaternion(x, y, z, w);
            }

        }

        public static Vector3 Forward(Vector3 dir)
        {
            Vector3 rot = Multiply(Quaternion.eulerToQuaternion(dir), new Vector3(1, 0, 0));
            Vector3 normalized = Vector3.Normalize(rot);
            return normalized;
        }

        public static Vector3 Multiply(Quaternion quat, Vector3 vec)
        {
            float num = quat.x * 2f;
            float num2 = quat.y * 2f;
            float num3 = quat.z * 2f;
            float num4 = quat.x * num;
            float num5 = quat.y * num2;
            float num6 = quat.z * num3;
            float num7 = quat.x * num2;
            float num8 = quat.y * num3;
            float num9 = quat.y * num3;
            float num10 = quat.w * num;
            float num11 = quat.w * num2;
            float num12 = quat.w * num3;
            Vector3 result = new Vector3(0, 0, 0);
            result.x = (1f - (num5 + num6)) * vec.x + (num7 - num12) * vec.y + (num8 + num11) * vec.z;
            result.y = (num7 + num12) * vec.x + (1f - (num4 + num6)) * vec.y + (num9 - num10) * vec.z;
            result.z = (num8 - num11) * vec.x + (num9 + num10) * vec.y + (1f - (num4 + num5)) * vec.z;
            return result;
        }

        public static float GetAxis(object vector, string axis)
        {
            Vector3 vector3 = (Vector3)vector;
            if (axis == "x")
                return vector3.x;
            if (axis == "y")
                return vector3.y;
            if (axis == "z")
                return vector3.z;
            return 0;
        }
    }

}
