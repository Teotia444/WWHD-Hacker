﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWHDHacker
{
    public partial class DataViewer: UserControl
    {
        Form1 origin;
        public DataViewer(Form1 _origin)
        {
            InitializeComponent();
            origin = _origin;
            updateValuesTimer.Start();
            mainStick.Paint += MainStick_Paint;
            cStick.Paint += CStick_Paint;

        }



        public void RefreshSticks()
        {
            cStick.Refresh();
            mainStick.Refresh();
        }

        public void RefreshInputs(int inputs)
        {
            aButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.aButton);
            bButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.bButton);
            xButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.xButton);
            yButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.yButton);
            plusButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.plusButton);
            minusButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.minusButton);

            dpadUpButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.dpadUpButton);
            dpadDownButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.dpadDownButton);
            dpadLeftButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.dpadLeftButton);
            dpadRightButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.dpadRightButton);

            lButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.lButton);
            rButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.rButton);
            zlButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.zlButton);
            zrButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.zrButton);
            l3ButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.l3Button);
            r3ButtonCheckbox.Checked = Inputs.isPressed(inputs, Inputs.r3Button);
        }

        private void MainStick_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.Clear(Color.LightGray);
            Pen pen = new Pen(Color.Black);
            Rectangle r = new Rectangle(0, 0, 134, 134);
            pen.Width = 4;
            r.Width -= 4;
            r.Height -= 4;
            r.X += 1;
            r.Y += 1;
            e.Graphics.DrawEllipse(pen, r);
            e.Graphics.FillEllipse(Brushes.White, r);
            pen = new Pen(Color.Blue);
            Rectangle dot = new Rectangle((122 / 2) + origin.mainStickValues.Item1 / 2, (122 / 2) - origin.mainStickValues.Item2 / 2, 10, 10);
            e.Graphics.DrawEllipse(pen, dot);
            e.Graphics.FillEllipse(Brushes.Blue, dot);
            pen = new Pen(Color.Black);
            pen.Width = 2;
            e.Graphics.DrawLine(pen, new Point((122 / 2) + origin.mainStickValues.Item1 / 2 + 5, (122 / 2) - origin.mainStickValues.Item2 / 2 + 5), new Point(122 / 2 + 5, 122 / 2 + 5));
        }

        private void CStick_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.LightGray);
            Pen pen = new Pen(Color.Black);
            Rectangle r = new Rectangle(0, 0, 134, 134);
            pen.Width = 4;
            r.Width -= 4;
            r.Height -= 4;
            r.X += 1;
            r.Y += 1;
            e.Graphics.DrawEllipse(pen, r);
            e.Graphics.FillEllipse(Brushes.White, r);
            pen = new Pen(Color.Blue);
            Rectangle dot = new Rectangle((122 / 2) + origin.cStickValues.Item1 / 2, (122 / 2) - origin.cStickValues.Item2 / 2, 10, 10);
            e.Graphics.DrawEllipse(pen, dot);
            e.Graphics.FillEllipse(Brushes.Blue, dot);
            pen = new Pen(Color.Black);
            pen.Width = 2;
            e.Graphics.DrawLine(pen, new Point((122 / 2) + origin.cStickValues.Item1 / 2 + 5, (122 / 2) - origin.cStickValues.Item2 / 2 + 5), new Point(122 / 2 + 5, 122 / 2 + 5));
        }

        private void updateValuesTimer_Tick(object sender, EventArgs e)
        {
            linkXTextbox.Text = origin.linkCoordinates.Item1.ToString();
            linkYTextbox.Text = origin.linkCoordinates.Item2.ToString();
            linkZTextbox.Text = origin.linkCoordinates.Item3.ToString();
            angleTextbox.Text = origin.linkAngle.ToString();
            potentialSpeedTextbox.Text = origin.linkSpeed.ToString();
            actualSpeedTextbox.Text = origin.linkSpeed.ToString();

            stageTextbox.Text = origin.stage;
            roomIdTextbox.Text = $"{origin.roomId:X}";
            spawnIdTextbox.Text = $"{origin.spawnId:X}";
            layerTextbox.Text = $"{origin.layer:X}";

            cStickX.Text = origin.cStickValues.Item2.ToString();
            cStickY.Text = origin.cStickValues.Item1.ToString();
            mainStickX.Text = origin.mainStickValues.Item2.ToString();
            mainStickY.Text = origin.mainStickValues.Item1.ToString();


        }
    }
}
