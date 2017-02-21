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

            button1.Enabled = false;

            mSicherungsTruppFuehrer.name = "";
            mSicherungsTruppFuehrer.fillPressure = START_PRESSURE;

            mSicherungsTruppMann.name = "";
            mSicherungsTruppMann.fillPressure = START_PRESSURE;

            // Set the view to show details.
            materialListView1.View = View.Details;
            // Allow the user to edit item text.
            materialListView1.LabelEdit = false;
            materialListView1.LabelWrap = true;
            // Allow the user to rearrange columns.
            materialListView1.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            materialListView1.FullRowSelect = false;
            // Display grid lines.
            materialListView1.GridLines = true;

            // Create columns for the items and subitems.
            materialListView1.Columns.Add("ID", 50, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Datum", 140, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Uhrzeit", 100, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Einsatzzeit", 100, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Text", 600, HorizontalAlignment.Left);

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

            checkStartButtonToEnabled();
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

            checkStartButtonToEnabled();
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

            string[] changes = new string[5];
            int i = 3;

            switch (state)
            {
                case AtemSchutz.start:
                    changes[0] = "Atemschutz Überwachung gestartet mit";
                    changes[1] = "Truppführer " + mTruppFuehrer.name + "Falschendruck " + mTruppFuehrer.fillPressure;
                    changes[2] = "Truppmann   " + mTruppMann.name + "Falschendruck " + mTruppMann.fillPressure;
                    changes[3] = "Sicherungs Truppführer " + mSicherungsTruppFuehrer.name + "Falschendruck " + mSicherungsTruppFuehrer.fillPressure;
                    changes[4] = "Sicherungs Truppmann " + mSicherungsTruppMann.name + "Falschendruck " + mSicherungsTruppMann.fillPressure;
                    i = 5;
                    break;
                case AtemSchutz.change:
                    changes[0] = "Atemschutz Überwachung Flaschenfüllstand kontrolle";
                    changes[1] = "Truppführer " + mTruppFuehrer.name + "Falschendruck " + mTruppFuehrer.fillPressure;
                    changes[2] = "Truppmann " + mTruppMann.name + "Falschendruck " + mTruppMann.fillPressure;
                    break;
                case AtemSchutz.end:
                    changes[0] = "Atemschutz Überwachung beendet mit ";
                    changes[1] = "Truppführer " + mTruppFuehrer.name + "Falschendruck " + mTruppFuehrer.fillPressure;
                    changes[2] = "Truppmann " + mTruppMann.name + "Falschendruck " + mTruppMann.fillPressure;
                    break;
            }

            for (int u = 0; u < i; u++)
            {
                if (u == 0)
                {
                    var entry = new[]
                    {
                        new []{ mID.ToString() , mStartTime.ToShortDateString(), mStartTime.ToShortTimeString(), helper.getDiffTime(mStartTime), changes[u]}
                    };
                    fillList(ref materialListView1, entry);
                }
                else
                {
                    var entry = new[]
                    {
                        new []{ String.Empty , String.Empty, String.Empty, String.Empty, changes[u]}
                    };
                    fillList(ref materialListView1, entry);
                }

            }

            materialListView1.Items[materialListView1.Items.Count - 1].EnsureVisible();

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

        private void checkStartButtonToEnabled()
         {
             if (mTruppFuehrer.name != String.Empty
                 && mTruppMann.name != String.Empty
                 && mSicherungsTruppFuehrer.name != String.Empty
                 && mSicherungsTruppMann.name != String.Empty)
             {
                 button1.Enabled = true;
             }
             
         }
    }
}
