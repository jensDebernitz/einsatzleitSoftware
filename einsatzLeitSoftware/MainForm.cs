using System;
using System.IO;
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
using Misc;


namespace einsatzLeitSoftware
{
    public partial class MainForm : MaterialForm
    {

        Timer mClockTimer = new Timer();
        CultureInfo mCulture = new CultureInfo("de-DE");
        DateTime mStartTime;
        bool mBeginTypingNewMessage;
        debug mDebug;
        int mID;

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

            mDebug = new debug();
            mDebug.debugMaskSet(debug.DebugIds.DEBUG_MAINFORM);

            mDebug.dprintf("MainForm.cs", 62, debug.DebugIds.DEBUG_MAINFORM, "Init Finished");
            addedAutoCompleteValuesToTextBoxes();

        }

        private void addedAutoCompleteValuesToTextBoxes()
        {
            AutoCompleteStringCollection sources = new AutoCompleteStringCollection();

            if(File.Exists(@"c:\EinsatzLeitSoftwareSteuerung\funkRufNamen.txt"))
            {
                string[] temp = File.ReadAllLines(@"c:\EinsatzLeitSoftwareSteuerung\funkRufNamen.txt");
                sources.AddRange(temp);
            }

            mTextFieldFunkFrom.AutoCompleteCustomSource = sources;
            mTextFieldFunkFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            mTextFieldFunkFrom.AutoCompleteSource = AutoCompleteSource.CustomSource;

            mTextFieldFunkTo.AutoCompleteCustomSource = sources;
            mTextFieldFunkTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            mTextFieldFunkTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void initListView()
        {
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
            materialListView1.Columns.Add("Von", 140, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Nach", 140, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Text", 550, HorizontalAlignment.Left);
            materialListView1.Columns.Add("Prio", 75, HorizontalAlignment.Left);
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
            timeHelper helper = new timeHelper();
            mLabelEinsatzdauer.Text = helper.getDiffTime(mStartTime);

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

            if(    e.KeyChar == (char)Keys.Enter
                || e.KeyChar == (char)Keys.Return)
            {
                mButtonSave.PerformClick();
            }
        }

        private void mButtonSearchButton_Click(object sender, EventArgs e)
        {
            string street = mTextFieldStreet.Text;
            string city = mTextFieldCity.Text;
            string state = mTextFieldState.Text;
            string zip = mTextFieldZip.Text;

            try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");

                if(street != string.Empty)
                {
                    queryAddress.Append(street + ", +");
                }

                if (city != string.Empty)
                {
                    queryAddress.Append(city + ", +");
                }

                if (state != string.Empty)
                {
                    queryAddress.Append(state + ", +");
                }

                if (zip != string.Empty)
                {
                    queryAddress.Append(zip + ", +");
                }

                webBrowser1.Navigate(queryAddress.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mButtonNewTabPage_Click(object sender, EventArgs e)
        {
            string title = "Überwachung " + (mTabControlAtemSchutz.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            containerClassAtemschutz newContainer = new containerClassAtemschutz();
            newContainer.setContainerNumber(mTabControlAtemSchutz.TabCount + 1);
            myTabPage.Controls.Add(newContainer);
            mTabControlAtemSchutz.TabPages.Add(myTabPage);
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mTextFieldFunkFrom_Enter(object sender, EventArgs e)
        {
            mTextFieldFunkFrom.Clear();
        }

        private void mTextFieldFunkTo_Enter(object sender, EventArgs e)
        {
            mTextFieldFunkTo.Clear();
        }
    }
}
