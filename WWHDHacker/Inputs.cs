using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.BufferedDeserialization;

namespace WWHDHacker
{
    enum InputEnum
    {
        Minus,
        Plus,
        R,
        L,
        ZR,
        ZL,
        DpadDown,
        DpadUp,
        DpadRight,
        DpadLeft,
        Y,
        X,
        B,
        A,
        L3,
        R3,
        TV
    }

    class Input
    {
        public int value;
        public Input(int _value)
        {
            value = _value;
        }
    }

    class Inputs
    {
        public static Input minusButton = new Input(0x4);
        public static Input plusButton = new Input(0x8);
        public static Input rButton = new Input(0x10);
        public static Input lButton = new Input(0x20);
        public static Input zrButton = new Input(0x40);
        public static Input zlButton = new Input(0x80);
        public static Input dpadDownButton = new Input(0x100);
        public static Input dpadUpButton = new Input(0x200);
        public static Input dpadRightButton = new Input(0x400);
        public static Input dpadLeftButton = new Input(0x800);
        public static Input yButton = new Input(0x1000);
        public static Input xButton = new Input(0x2000);
        public static Input bButton = new Input(0x4000);
        public static Input aButton = new Input(0x8000);
        public static Input l3Button = new Input(0x40000);
        public static Input r3Button = new Input(0x20000);
        public static Input tvButton = new Input(0x10000);

        public static bool isPressed(int inputs, Input button)
        {
            return (inputs | button.value) == inputs;
        }

        public static bool isNotPressed(int inputs, Input button)
        {
            return (inputs & ~button.value) == inputs;
        }

        public static Input enumToInput(InputEnum e)
        {
            var fields = typeof(Inputs).GetFields();
            return (Input)fields[(int)e].GetValue(null);

        }

        public static int wpadToVpad(int wpad)
        {
            int vpad = 0;
            if ((wpad & 0x00000010) == 0x00000010) vpad = vpad | 0x8000;
            if ((wpad & 0x00000040) == 0x00000040) vpad = vpad | 0x4000;
            if ((wpad & 0x00000080) == 0x00000080) vpad = vpad | 0x80;
            if ((wpad & 0x00000008) == 0x00000008) vpad = vpad | 0x2000;
            if ((wpad & 0x00000020) == 0x00000020) vpad = vpad | 0x1000;
            if ((wpad & 0x00000004) == 0x00000004) vpad = vpad | 0x40;
            if ((wpad & 0x00010000) == 0x00010000) vpad = vpad | 0x20000;
            if ((wpad & 0x00020000) == 0x00020000) vpad = vpad | 0x40000;
            if ((wpad & 0x00000400) == 0x00000400) vpad = vpad | 0x8;
            if ((wpad & 0x00001000) == 0x00001000) vpad = vpad | 0x4;
            if ((wpad & 0x00002000) == 0x00002000) vpad = vpad | 0x20;
            if ((wpad & 0x00000200) == 0x00000200) vpad = vpad | 0x10;
            if ((wpad & 0x00000001) == 0x00000001) vpad = vpad | 0x200;
            if ((wpad & 0x00004000) == 0x00004000) vpad = vpad | 0x100;
            if ((wpad & 0x00000002) == 0x00000002) vpad = vpad | 0x800;
            if ((wpad & 0x00008000) == 0x00008000) vpad = vpad | 0x400;
            return vpad;
        }

    }

    

}
