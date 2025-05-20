using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

    }

    class JsonInput
    {
        public bool enabled;
        public int input;
        public bool masterkey;
        public float value;
        public bool alternative;

        public JsonInput(int input, bool enabled = true, bool masterkey = false, float value = 0f, bool alternative = false)
        {
            this.enabled = enabled;
            this.input = input;
            this.masterkey = masterkey;
            this.value = value;
            this.alternative = alternative;
        }
    }

}
