using System;
using System.Text;

//Support Net framework 4.0
namespace ImGuiNET
{
    public static class ImportConfig
    {
        public const string DLL_PATH = "CImguiEx.dll";
    }

    [Serializable]
    public struct Vector3 : IEquatable<Vector3>, IFormattable
    {
        float x, y, z;
        public bool Equals(Vector3 other)
        {
            return x == other.x &&
                y == other.y &&
                z == other.z;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return x.ToString() + "," + y.ToString() + "," + z.ToString();
        }
    }

    [Serializable]
    public struct Vector4 : IEquatable<Vector4>, IFormattable
    {
        float x, y, z, w;

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public bool Equals(Vector4 other)
        {
            return other.x == x && other.y == y && other.z == z && other.w == w;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return x.ToString() + "," + y.ToString() + "," + z.ToString() + "," + w.ToString();
        }
    }

    [Serializable]
    public struct Vector2 : IEquatable<Vector2>, IFormattable
    {
        public float x, y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(Vector2 vector)
        {
            this.x = vector.x;
            this.y = vector.y;
        }

        public bool Equals(Vector2 other)
        {
            return other.x == x && other.y == y;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return x.ToString() + "," + y.ToString();
        }
    }

    public class ImGuiEncoding
    {
        public class ASCII
        {
            public static unsafe string GetString(byte* bytesPtr, int count)
            {
                byte[] bytes = new byte[count];
                for (int i = 0; i < count; ++i)
                    bytes[i] = bytesPtr[i];

                return Encoding.ASCII.GetString(bytes, 0, count);
            }

        }

        public class UTF8
        {
            public static unsafe string GetString(byte* bytesPtr, int count)
            {
                byte[] bytes = new byte[count];
                for (int i = 0; i < count; ++i)
                    bytes[i] = bytesPtr[i];

                return Encoding.UTF8.GetString(bytes, 0, count);
            }

        }
    }

}
