using System;
using UnityEngine;
using UnityEngine.Internal;

namespace Quirks
{
    public static class Gizmosu
    {
        public static Color color
        {
            get { return Gizmos.color; }
            set { Gizmos.color = value; }
        }

        public static Matrix4x4 matrix
        {
            get { return Gizmos.matrix; }
            set { Gizmos.matrix = value; }
        }

        public static Texture exposure
        {
            get { return Gizmos.exposure; }
            set { Gizmos.exposure = value; }
        }

        public static float probeSize
        {
            get { return Gizmos.probeSize; }
        }

        #region Line

        /// <summary>Draws a line starting at from towards to.</summary>
        public static void DrawLine(Vector3 from, Vector3 to) => Gizmos.DrawLine(from, to);
        public static void DrawLineStrip(ReadOnlySpan<Vector3> points, bool looped) => Gizmos.DrawLineStrip(points, looped);
        public static void DrawLineList(ReadOnlySpan<Vector3> points) => Gizmos.DrawLineList(points);

        #endregion

        #region Sphere

        /// <summary>Draws a wireframe sphere with center and radius.</summary>
        public static void DrawWireSphere(Vector3 center, float radius) => Gizmos.DrawWireSphere(center, radius);
        /// <summary>Draws a solid sphere with center and radius.</summary>
        public static void DrawSphere(Vector3 center, float radius) => Gizmos.DrawSphere(center, radius);

        #endregion

        #region Cube

        /// <summary>Draw a wireframe box with center and size.</summary>
        public static void DrawWireCube(Vector3 center, Vector3 size) => DrawWireCube(center, size);
        /// <summary>Draw a solid box at center with size.</summary>
        public static void DrawCube(Vector3 position, Vector3 size) => Gizmos.DrawCube(position, size);

        #endregion

        #region Mesh

        /// <summary>Draws a mesh.</summary>
        public static void DrawMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
            => Gizmos.DrawMesh(mesh, submeshIndex, position, rotation, scale);

        /// <summary>Draws a wireframe mesh.</summary>
        public static void DrawWireMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
            => Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation, scale);

        public static void DrawMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
            => Gizmos.DrawMesh(mesh, -1, position, rotation, scale);
        public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation) => DrawMesh(mesh, position, rotation);
        public static void DrawMesh(Mesh mesh, Vector3 position) => DrawMesh(mesh, position);
        public static void DrawMesh(Mesh mesh) => DrawMesh(mesh);
        public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation) => Gizmos.DrawMesh(mesh, submeshIndex, position, rotation);
        public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position) => Gizmos.DrawMesh(mesh, submeshIndex, position);
        public static void DrawMesh(Mesh mesh, int submeshIndex) => Gizmos.DrawMesh(mesh, submeshIndex);

        public static void DrawWireMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
            => Gizmos.DrawWireMesh(mesh, position, rotation, scale);
        public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation) => Gizmos.DrawWireMesh(mesh, position, rotation);
        public static void DrawWireMesh(Mesh mesh, Vector3 position) => Gizmos.DrawWireMesh(mesh, position);
        public static void DrawWireMesh(Mesh mesh) => Gizmos.DrawWireMesh(mesh);
        public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation) => Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation);
        public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position) => Gizmos.DrawWireMesh(mesh, submeshIndex, position);
        public static void DrawWireMesh(Mesh mesh, int submeshIndex) => Gizmos.DrawWireMesh(mesh, submeshIndex);

        #endregion


        #region Icon


        /// <summary>Draw an icon at a position in the Scene view.</summary>
        public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling) => Gizmos.DrawIcon(center, name, allowScaling);

        /// <summary>Draw an icon at a position in the Scene view.</summary>
        public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] Color tint)
            => Gizmos.DrawIcon(center, name, allowScaling, tint);

        public static void DrawIcon(Vector3 center, string name) => Gizmos.DrawIcon(center, name);


        #endregion

        #region GUI Texture

        /// <summary>Draw a texture in the Scene. </summary>
        public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat)
            => Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);

        public static void DrawGUITexture(Rect screenRect, Texture texture) => Gizmos.DrawGUITexture(screenRect, texture);
        public static void DrawGUITexture(Rect screenRect, Texture texture, [DefaultValue("null")] Material mat) => Gizmos.DrawGUITexture(screenRect, texture, mat);
        public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
            => Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder);

        #endregion

        #region Frustum

        /// <summary>Draw a camera frustum using the currently set Gizmos.matrix for its location and rotation.</summary>
        public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) => Gizmos.DrawFrustum(center, fov, maxRange, minRange, aspect);

        #endregion

        #region Ray

        /// <summary>Draws a ray starting at from to from + direction.</summary>
        public static void DrawRay(Ray r) => Gizmos.DrawRay(r);
        /// <summary>Draws a ray starting at from to from + direction.</summary>
        public static void DrawRay(Vector3 from, Vector3 direction) => Gizmos.DrawRay(from, direction);

        #endregion


        #region New Features

        public static void DrawWireCube(Vector3 center, Vector3 size, Quaternion rotation = default(Quaternion))
        {
            Matrix4x4 old = Gizmos.matrix;
            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            Gizmos.matrix = Matrix4x4.TRS(center, rotation, size);
            Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
            Gizmos.matrix = old;
        }

        public static void DrawWireSphere(Vector3 center, float radius, Quaternion rotation = default(Quaternion))
        {
            Matrix4x4 old = Gizmos.matrix;
            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            Gizmos.matrix = Matrix4x4.TRS(center, rotation, Vector3.one);
            Gizmos.DrawWireSphere(center, radius);
            Gizmos.matrix = old;
        }

        #endregion

        #region New Shapes

        public static void DrawWireArc(Vector3 center, float radius, float angle, int segments = 20, Quaternion rotation = default(Quaternion))
        {
            Matrix4x4 old = Gizmos.matrix;

            Gizmos.matrix = Matrix4x4.TRS(center, rotation, Vector3.one);
            Vector3 from = Vector3.forward * radius;
            int step = Mathf.RoundToInt(angle / segments);

            for (int i = 0; i <= angle; i += step)
            {
                Vector3 to = new Vector3(radius * Mathf.Sin(i * Mathf.Deg2Rad), 0, radius * Mathf.Cos(i * Mathf.Deg2Rad));
                Gizmos.DrawLine(from, to);
                from = to;
            }

            Gizmos.matrix = old;
        }

        public static void DrawWireArc(Vector3 center, float radius, float angle, int segments, Quaternion rotation, Vector3 centerOfRotation)
        {

            Matrix4x4 old = Gizmos.matrix;

            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            Gizmos.matrix = Matrix4x4.TRS(centerOfRotation, rotation, Vector3.one);
            Vector3 deltaTranslation = centerOfRotation - center;
            Vector3 from = deltaTranslation + Vector3.forward * radius;
            int step = Mathf.RoundToInt(angle / segments);

            for (int i = 0; i <= angle; i += step)
            {
                Vector3 to = new Vector3(radius * Mathf.Sin(i * Mathf.Deg2Rad), 0, radius * Mathf.Cos(i * Mathf.Deg2Rad)) + deltaTranslation;
                Gizmos.DrawLine(from, to);
                from = to;
            }

            Gizmos.matrix = old;
        }

        public static void DrawWireArc(Matrix4x4 matrix, float radius, float angle, int segments)
        {
            Matrix4x4 old = Gizmos.matrix;

            Gizmos.matrix = matrix;
            Vector3 from = Vector3.forward * radius;
            int step = Mathf.RoundToInt(angle / segments);

            for (int i = 0; i <= angle; i += step)
            {
                Vector3 to = new Vector3(radius * Mathf.Sin(i * Mathf.Deg2Rad), 0, radius * Mathf.Cos(i * Mathf.Deg2Rad));
                Gizmos.DrawLine(from, to);
                from = to;
            }

            Gizmos.matrix = old;
        }

        public static void DrawWireCircle(Vector3 center, float radius, int segments = 20, Quaternion rotation = default(Quaternion))
        {
            DrawWireArc(center, radius, 360, segments, rotation);
        }

        public static void DrawWireCylinder(Vector3 center, float radius, float height, Quaternion rotation = default(Quaternion))
        {
            Matrix4x4 old = Gizmos.matrix;

            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            Gizmos.matrix = Matrix4x4.TRS(center, rotation, Vector3.one);
            float half = height / 2;

            Gizmos.DrawLine(Vector3.right * radius - Vector3.up * half, Vector3.right * radius + Vector3.up * half);
            Gizmos.DrawLine(-Vector3.right * radius - Vector3.up * half, -Vector3.right * radius + Vector3.up * half);
            Gizmos.DrawLine(Vector3.forward * radius - Vector3.up * half, Vector3.forward * radius + Vector3.up * half);
            Gizmos.DrawLine(-Vector3.forward * radius - Vector3.up * half, -Vector3.forward * radius + Vector3.up * half);

            DrawWireArc(center + Vector3.up * half, radius, 360, 20, rotation, center);
            DrawWireArc(center + Vector3.down * half, radius, 360, 20, rotation, center);

            Gizmos.matrix = old;
        }

        public static void DrawWireCapsule(Vector3 center, float radius, float height, Quaternion rotation = default(Quaternion))
        {
            var old = Gizmos.matrix;

            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            Gizmos.matrix = Matrix4x4.TRS(center, rotation, Vector3.one);
            float half = height / 2 - radius;

            DrawWireCylinder(center, radius, height - radius * 2, rotation);

            Matrix4x4 mat = Matrix4x4.Translate(center + rotation * Vector3.up * half) * Matrix4x4.Rotate(rotation * Quaternion.AngleAxis(90, Vector3.forward));
            DrawWireArc(mat, radius, 180, 20);
            mat = Matrix4x4.Translate(center + rotation * Vector3.up * half) * Matrix4x4.Rotate(rotation * Quaternion.AngleAxis(90, Vector3.up) * Quaternion.AngleAxis(90, Vector3.forward));
            DrawWireArc(mat, radius, 180, 20);

            mat = Matrix4x4.Translate(center + rotation * Vector3.down * half) * Matrix4x4.Rotate(rotation * Quaternion.AngleAxis(90, Vector3.up) * Quaternion.AngleAxis(-90, Vector3.forward));
            DrawWireArc(mat, radius, 180, 20);
            mat = Matrix4x4.Translate(center + rotation * Vector3.down * half) * Matrix4x4.Rotate(rotation * Quaternion.AngleAxis(-90, Vector3.forward));
            DrawWireArc(mat, radius, 180, 20);

            Gizmos.matrix = old;
        }

        public static void DrawArrow(Vector3 from, Vector3 to, float arrowHeadLength = 0.2f, float arrowHeadAngle = 20f)
        {
            Gizmos.DrawLine(from, to);
            Vector3 direction = to - from;

            Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
            Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);

            Gizmos.DrawLine(to, to + right * arrowHeadLength);
            Gizmos.DrawLine(to, to + left * arrowHeadLength);
        }

        #endregion
    }

}
