using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace einsatzLeitSoftware
{
    public partial class containerClassAtemschutz : UserControl
    {

        const int LOW_PRESSURE = 100;
        const int MEDIUM_PRESSURE_UPPER_LIMIT = 200;
        const int MEDIUM_PRESSURE_LOWER_LIMIT = 100;
        const string START_PRESSURE = "0bar";
        const int TIMER_INTERVAL = 500;

        private enum AtemSchutz
        {
            start = 0,
            change,
            end
        }

        trup mTruppFuehrer;
        trup mTruppMann;
        trup mSicherungsTruppFuehrer;
        trup mSicherungsTruppMann;
        DateTime mStartTime;
        int mID;
        string mContainerName = "Atemschutz Überwachung 1";


        public containerClassAtemschutz()
        {
            InitializeComponent();
            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox2.Click += new System.EventHandler(this.groupBox2_Enter);

            mTruppFuehrer.name = "";
            mTruppFuehrer.fillPressure = START_PRESSURE;

            mTruppMann.name = "";
            mTruppMann.fillPressure = START_PRESSURE;

            mSicherungsTruppFuehrer.name = "";
            mSicherungsTruppFuehrer.fillPressure = START_PRESSURE;

            mSicherungsTruppMann.name = "";
            mSicherungsTruppMann.fillPressure = START_PRESSURE;

            timer1.Interval = TIMER_INTERVAL;

            mID = 1;
        }

        public void setContainerNumber(int number)
        {
            mContainerName = "Atemschutz Überwachung " + number.ToString();
        }

        private void mLabelValueBottleFielPressure_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            atemSchutzGeneralDialog dialog = new atemSchutzGeneralDialog(false, mTruppFuehrer, mTruppMann);

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                mLabelValueTruppFuehrer.Text = dialog.getNameTruppFuehrer();
                mLabelValueTruppMann.Text = dialog.getNameTruppMann();
                mLabelValueBottleFielPressureTruppFuehrer.Text = dialog.getFillPressureTruppFuehrer() + "bar";
                mLabelValueBottleFielPressureTruppMann.Text = dialog.getFillPressureTruppMann() + "bar";

                mTruppFuehrer.name = mLabelValueTruppFuehrer.Text;
                mTruppFuehrer.fillPressure = mLabelValueBottleFielPressureTruppFuehrer.Text;

                mTruppMann.name = mLabelValueTruppMann.Text;
                mTruppMann.fillPressure = mLabelValueBottleFielPressureTruppMann.Text;

                //change Color from the label 
                mLabelValueBottleFielPressureTruppFuehrer.ForeColor = getFillPressureColor(dialog.getFillPressureTruppFuehrer());
                mLabelValueBottleFielPressureTruppMann.ForeColor = getFillPressureColor(dialog.getFillPressureTruppMann());

                if (timer1.Enabled == true)
                {
                    addProtocolEntry(AtemSchutz.change);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            atemSchutzGeneralDialog dialog = new atemSchutzGeneralDialog(true, mSicherungsTruppFuehrer, mSicherungsTruppMann);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mLabelValueSicherungsTruppFuehrer.Text = dialog.getNameTruppFuehrer();
                mLabelValueSicherungsTruppMann.Text = dialog.getNameTruppMann();
                mLabelValueBottleFielPressureSicherungsTruppFuehrer.Text = dialog.getFillPressureTruppFuehrer() + "bar";
                mLabelValueBottleFielPressureSicherungsTruppMann.Text = dialog.getFillPressureTruppMann() + "bar";

                mSicherungsTruppFuehrer.name = mLabelValueSicherungsTruppFuehrer.Text;
                mSicherungsTruppFuehrer.fillPressure = mLabelValueBottleFielPressureSicherungsTruppFuehrer.Text;

                mSicherungsTruppMann.name = mLabelValueSicherungsTruppMann.Text;
                mSicherungsTruppMann.fillPressure = mLabelValueBottleFielPressureSicherungsTruppMann.Text;

                //change Color from the label 
                mLabelValueBottleFielPressureSicherungsTruppFuehrer.ForeColor = getFillPressureColor(dialog.getFillPressureTruppFuehrer());
                mLabelValueBottleFielPressureSicherungsTruppMann.ForeColor = getFillPressureColor(dialog.getFillPressureTruppMann());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mStartTime = DateTime.Now;

            if (mLabelStartTime.Text == String.Empty)
            {
                mLabelStartTime.Text = mStartTime.ToShortTimeString();
            }

            if(timer1.Enabled == false)
            {
                button1.Text = "S T O P";
                timer1.Enabled = true;
                addProtocolEntry(AtemSchutz.start);
            }
            else
            {
                button1.Text = "S T A R T";
                timer1.Enabled = false;
                addProtocolEntry(AtemSchutz.end);
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime localDateTime = DateTime.Now;
            Misc.timeHelper helper = new Misc.timeHelper();
            materialLabel2.Text = helper.getDiffTime(mStartTime);

            if(helper.is15MinutesAlarm(mStartTime))
            {
                MessageBox.Show("Flaschenfülldruck Nachfragen " + mContainerName);
            }
        }

        private Color getFillPressureColor(string pressure)
        {
            int tempPressure = Convert.ToInt32(pressure);
            Color returnColor = Color.Green;

            if (tempPressure < LOW_PRESSURE)
            {
                returnColor = Color.Red;
            }
            else if (tempPressure < MEDIUM_PRESSURE_UPPER_LIMIT && tempPressure >= MEDIUM_PRESSURE_LOWER_LIMIT)
            {
                returnColor = Color.Orange;
            }

            return returnColor;
        }

        private void addProtocolEntry(AtemSchutz state)
        {
            Misc.timeHelper helper = new Misc.timeHelper();
           
            string changes = String.Empty;


            switch (state)
            {
                case AtemSchutz.start:
                    changes = "Atemschutz Überwachung gestartet mit" + System.Environment.NewLine;
                    changes += "Truppführer " + mTruppFuehrer.name + "Falschendruck " + mTruppFuehrer.fillPressure + System.Environment.NewLine;
                    changes += "Truppmann   " + mTruppMann.name + "Falschendruck " + mTruppMann.fillPressure + System.Environment.NewLine;
                    changes += "Sicherungs Truppführer " + mSicherungsTruppFuehrer.name + "Falschendruck " + mSicherungsTruppFuehrer.fillPressure + System.Environment.NewLine;
                    changes += "Sicherungs Truppmann " +  mSicherungsTruppMann.name + "Falschendruck " + mSicherungsTruppMann.fillPressure;
                    break;
                case AtemSchutz.change:
                    changes = "Atemschutz Überwachung Flaschenfüllstand kontrolle" + System.Environment.NewLine;
                    changes += "Truppführer " + mTruppFuehrer.name + "Falschendruck " + mTruppFuehrer.fillPressure + System.Environment.NewLine;
                    changes += "Truppmann " +  mTruppMann.name + "Falschendruck " + mTruppMann.fillPressure;
                    break;
                case AtemSchutz.end:
                    changes = "Atemschutz Überwachung beendet mit " + System.Environment.NewLine;
                    changes += "Truppführer " + mTruppFuehrer.name + "Falschendruck " + mTruppFuehrer.fillPressure + System.Environment.NewLine;
                    changes += "Truppmann " +  mTruppMann.name + "Falschendruck " + mTruppMann.fillPressure;
                    break;
            }

            var entry = new[]
            {
                  new []{ mID.ToString() , mStartTime.ToShortDateString(), mStartTime.ToShortTimeString(), helper.getDiffTime(mStartTime), changes}
            };

            materialListView1.View = View.Details;
            materialListView1.LabelWrap = true;
            fillList(ref materialListView1, entry);
            mID++;
        }

         private void fillList(ref MaterialListView list, string[][] data)
         {

            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                list.Items.Add(item);
            }

        }
    }
}
