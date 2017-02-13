using System;
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
        bool mBeginTypingNewMessage;

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
            mBeginTypingNewMessage = false;

            initListView();

        }

        private void initListView()
        {
            materialListView1.Sorting = SortOrder.None;
            materialListView1.View = View.Details;

            //materialListView1.Columns.Add(new ColumnHeader());
            //materialListView1.Columns[0].Text = "ID";
            //materialListView1.Columns[0].Width = 20;

            SuspendLayout();
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

            if(mBeginTypingNewMessage == false)
            {
                mTextFieldTime.Text = localDateTime.ToShortTimeString();
                mTextFieldDate.Text = localDateTime.ToShortDateString();
                mTextFieldTimer.Text = mLabelEinsatzdauer.Text;
            }
        }

        /*!
         * @brief fill list function
         * 
         * @param MaterialListView list
         * @param string[][] data
         */
        private void fillList(ref MaterialListView list, string[][] data)
        {

            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                list.Items.Add(item);
            }

        }

        private void mButtonSave_Click(object sender, EventArgs e)
        {
            var get1 = new[]
            {
                  new []{ mTextFieldID.Text , mTextFieldDate.Text, mTextFieldTime.Text, mTextFieldTimer.Text, mTextFieldFunkFrom.Text, mTextFieldFunkTo.Text, mTextFieldMessage.Text, mTextFieldPrio.Text}
            };

            fillList(ref materialListView1, get1);
            mBeginTypingNewMessage = false;

            int id = Convert.ToInt32(mTextFieldID.Text);
            id++;
            mTextFieldID.Text = id.ToString();
        }

        private void mTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            mBeginTypingNewMessage = true;
        }
    }
}
