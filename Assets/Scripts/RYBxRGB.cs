using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RYBxRGB
{
    private float[][] MAGIC_COLORS = { {1f, 1f, 1f}, 
                                       {1f, 1f, 0f}, 
                                       {1f, 0f, 0f}, 
                                       {1f, 0.5f, 0f}, 
                                       {0.163f, 0.373f, 0.6f}, 
                                       {0f, 0.66f, 0.2f}, 
                                       {0.5f, 0f, 0.5f}, 
                                       {0.2f, 0.094f, 0f}}
    public static Vector3 RYB2RGB(float red, float yellow, float blue){
      var R = red/255f;
      var Y = yellow/255f;
      var B = blue/255f;
      var R1 = getR(R, Y, B);
      var G1 = getG(R, Y, B);
      var B1 = getB(R, Y, B);
      return new Vector3(R1, G1, B1);
    }

    public static Vector3 RGB2RYB(float red, float green, float blue){
        
    }
    private static float cubicInt(float t, float A, float B){
      float weight = t * t * (3 - 2 * t);
      return A + weight * (B - A);
    }

    private static float getR(float iR, float iY, float iB) {
      float x0 = cubicInt(iB, MAGIC_COLORS[0][0], MAGIC_COLORS[4][0]);
      float x1 = cubicInt(iB, MAGIC_COLORS[1][0], MAGIC_COLORS[5][0]);
      float x2 = cubicInt(iB, MAGIC_COLORS[2][0], MAGIC_COLORS[6][0]);
      float x3 = cubicInt(iB, MAGIC_COLORS[3][0], MAGIC_COLORS[7][0]);
      float y0 = cubicInt(iY, x0, x1);
      float y1 = cubicInt(iY, x2, x3);
      return cubicInt(iR, y0, y1);
    }

    private static float getG(float iR, float iY, float iB) {
      float x0 = cubicInt(iB, MAGIC_COLORS[0][1], MAGIC_COLORS[4][1]);
      float x1 = cubicInt(iB, MAGIC_COLORS[1][1], MAGIC_COLORS[5][1]);
      float x2 = cubicInt(iB, MAGIC_COLORS[2][1], MAGIC_COLORS[6][1]);
      float x3 = cubicInt(iB, MAGIC_COLORS[3][1], MAGIC_COLORS[7][1]);
      float y0 = cubicInt(iY, x0, x1);
      float y1 = cubicInt(iY, x2, x3);
      return cubicInt(iR, y0, y1);
    }

    private static float getB(float iR, float iY, float iB) {
      float x0 = cubicInt(iB, MAGIC_COLORS[0][2], MAGIC_COLORS[4][2]);
      float x1 = cubicInt(iB, MAGIC_COLORS[1][2], MAGIC_COLORS[5][2]);
      float x2 = cubicInt(iB, MAGIC_COLORS[2][2], MAGIC_COLORS[6][2]);
      float x3 = cubicInt(iB, MAGIC_COLORS[3][2], MAGIC_COLORS[7][2]);
      float y0 = cubicInt(iY, x0, x1);
      float y1 = cubicInt(iY, x2, x3);
      return cubicInt(iR, y0, y1);
    }
}
