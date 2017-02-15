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

        trup mTruppFuehrer;
        trup mTruppMann;
        trup mSicherungsTruppFuehrer;
        trup mSicherungsTruppMann;
        DateTime mStartTime;
        string mContainerName = "Atemschutz Überwachung 1";

        public containerClassAtemschutz()
        {
            InitializeComponent();
            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox2.Click += new System.EventHandler(this.groupBox2_Enter);

            mTruppFuehrer.name = "";
            mTruppFuehrer.fillPressure = "300bar";

            mTruppMann.name = "";
            mTruppMann.fillPressure = "300bar";

            mSicherungsTruppFuehrer.name = "";
            mSicherungsTruppFuehrer.fillPressure = "300bar";

            mSicherungsTruppMann.name = "";
            mSicherungsTruppMann.fillPressure = "300bar";
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
            }
            else
            {
                button1.Text = "S T A R T";
                timer1.Enabled = false;
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime localDateTime = DateTime.Now;
            //Calculate the different from start time to now time and show it in a label
            Misc.timeHelper helper = new Misc.timeHelper();
            materialLabel2.Text = helper.getDiffTime(mStartTime);

            if(helper.is15MinutesAlarm(mStartTime))
            {
                MessageBox.Show("Flaschenfülldruck Nachfragen " + mContainerName);
            }
        }
    }
}
