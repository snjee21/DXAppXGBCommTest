using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXAppXGBCommTest {
  public class DataSet {
    private TEST_MODE m_TEST_MODE; //field
    private int m_TEST_TYPE;
    private SYS_STD m_SYS_STD;

    public enum TEST_MODE {
      MODE_UNKNOWN = 0,
      PHOTO_SENSOR,
      ENCODER,
      ELECMETER
    }
    public TEST_MODE sys_TEST_MODE { //property
      get => m_TEST_MODE;
      set => m_TEST_MODE = value;
    }
    public int sys_TEST_TYPE {
      get => m_TEST_TYPE;
      set => m_TEST_TYPE = value;
    }

    public enum SYS_STD {
      STD_UNKNOWN = 0,
      STD_1L,
      STD_2L,
      STD_3L,
      STD_4L,
      STD_5L,
      STD_10L,
      STD_15L,
      STD_20L
    }
    public SYS_STD sys_STD {
      get => m_SYS_STD;
      set => m_SYS_STD = value;
    }
  }
}
