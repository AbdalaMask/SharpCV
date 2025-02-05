﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpCV
{
    internal partial class cv2_native_api
    {
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_cvtColor(IntPtr src, IntPtr dst, int code, int dstCnt);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_contourArea_InputArray(IntPtr contour, int oriented, out double output);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_threshold(IntPtr src, IntPtr dst, double thresh, double maxval, int type, out double output);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_resize(IntPtr src, IntPtr dst, Size dsize, double fx, double fy, int interpolation);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_getRotationMatrix2D(Point center, double angle, double scale, out IntPtr output);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_warpAffine(IntPtr src, IntPtr dst, IntPtr m, Size dsize, int flags, int borderMode, Scalar borderValue);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_adaptiveThreshold(IntPtr src, IntPtr dst, double maxValue, int method, int type, int blockSize, double delta);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_pyrUp(IntPtr src, IntPtr dst, Size dstsize, int borderType);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_pyrDown(IntPtr src, IntPtr dst, Size dstsize, int borderType);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_calcBackProject(IntPtr[] images, int nimages, int[] channels, IntPtr hist, IntPtr backProject, IntPtr[] ranges, int uniform);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_rectangle_InputOutputArray_Point(IntPtr img, Point pt1, Point pt2, Scalar color, int thickness, LineTypes lineType, int shift);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void imgproc_putText(IntPtr img, string text, Point org,
            int fontFace, double fontScale, Scalar color,
            int thickness, int lineType, int bottomLeftOrigin);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void imgproc_getTextSize(string text, int fontFace,
            double fontScale, int thickness, out int baseLine, out Size returnValue);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_getStructuringElement(int shape, Size ksize, Point anchor, out IntPtr output);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_morphologyEx(IntPtr src, IntPtr dst, int op, IntPtr kernel, Point anchor,
            int iterations, int borderType, Scalar borderValue);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_findContours1_vector(IntPtr image, out IntPtr contours,
            out IntPtr hierarchy, int mode, int method, Point offset);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_findContours1_OutputArray(IntPtr image, out IntPtr contours,
            IntPtr hierarchy, int mode, int method, Point offset);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_drawContours_vector(IntPtr image,
            IntPtr[] contours, int contoursSize1, int[] contoursSize2,
            int contourIdx, Scalar color, int thickness, int lineType,
            IntPtr hierarchy, int hiearchyLength, int maxLevel, Point offset);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_drawContours_InputArray(IntPtr image,
            IntPtr[] contours, int contoursLength,
            int contourIdx, Scalar color, int thickness, LineTypes lineType,
            IntPtr hierarchy, int maxLevel, Point offset);
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_approxPolyDP_InputArray(IntPtr curve, IntPtr approxCurve,
            double epsilon, bool closed);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_minAreaRect_InputArray(IntPtr points, out RotatedRect output);
        
        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_moments(IntPtr arr, int binaryImage, out Moments.NativeStruct output);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_medianBlur(IntPtr src, IntPtr dst, int kSize);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_GaussianBlur(IntPtr src, IntPtr dst, Size kSize,  double sigmaX, double sigmaY, BorderTypes borderType);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_filter2D(IntPtr src, IntPtr dst, MatType ddepth, IntPtr kernel, Point anchor,
            double delta, BorderTypes borderType);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_blur(IntPtr src, IntPtr dst, Size kSize, Point anchor, BorderTypes borderType);

        [DllImport(OpenCvDllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void imgproc_Sobel(IntPtr src, IntPtr dst, MatType ddepth, int dx, int dy, int kSize, double scale, double delta, BorderTypes borderType);
    }
}
