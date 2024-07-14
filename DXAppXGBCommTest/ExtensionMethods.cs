using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXAppXGBCommTest {
  public static class ExtetionMethods {
    //확장 메서드는 제네릭이 아닌 정적 클래스에 정의해야
    public static T[] SubArray<T>(this T[] data, int index, int length) {
      T[] result = new T[length];
      Array.Copy(data, index, result, 0, length);
      return result;
    }
  }
}
