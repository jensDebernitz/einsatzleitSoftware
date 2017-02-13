﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin.Properties;


namespace einsatzLeitSoftware
{
    public partial class MainForm : MaterialForm
    {

        Timer mClockTimer = new Timer();
        CultureInfo mCulture = new CultureInfo("de-DE");
        DateTime mStartTime;
        public MainForm()
        {
            InitializeComponent();

            beginDialog startDialog = new beginDialog();

            if(startDialog.ShowDialog() == DialogResult.OK)
            {
                mLabelValueEinsatzOrt.Text = startDialog.getEinsatzLocation();
                mLabelValueEinsatzStart.Text = startDialog.getStartDateTime();
                mLabelValueProtocolLeader.Text = startDialog.getProtocolLeader();
                mLabelValueEinsatzLeader.Text = startDialog.getEinsatzLeader();
                mStartTime = DateTime.Now;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mClockTimer.Interval = 1000;
            mClockTimer.Tick += new EventHandler(this.clockTimerTick);
            clockTimerTick(new object(), new EventArgs());
            mClockTimer.Start();
        }

        private void clockTimerTick(object sender, EventArgs e)
        {
            DateTime localDateTime = DateTime.Now;
            mLabelClock.Text = localDateTime.ToString(mCulture);

            //Calculate the different from start time to now time and show it in a label
            TimeSpan diff = localDateTime - mStartTime;
            int diffHours = diff.Hours;
            int diffMinutes = diff.Minutes;
            int diffSeconds = diff.Seconds;
            mLabelEinsatzdauer.Text = diffHours.ToString() + ":" + diffMinutes.ToString() + ":" + diffSeconds.ToString();
        }
    }
}
