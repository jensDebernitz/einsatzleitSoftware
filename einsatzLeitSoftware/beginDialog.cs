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
    public partial class beginDialog : MaterialForm
    {
        CultureInfo mCulture = new CultureInfo("de-DE");

        public beginDialog()
        {
            InitializeComponent();
            mButtonEinsatzStart.Enabled = false;
        }

        public string getStartDateTime()
        {
            return mLabelStartTime.Text;
        }

        public string getEinsatzLocation()
        {
            return mTextFieldEinsatzOrt.Text;
        }

        public string getProtocolLeader()
        {
            return mTextFieldProtokollLeader.Text;
        }

        public string getEinsatzLeader()
        {
            return mTextFieldEinsatzLeader.Text;
        }
        private void beginDialog_Load(object sender, EventArgs e)
        {
            DateTime localDateTime = DateTime.Now;
            mLabelStartTime.Text = localDateTime.ToString(mCulture);
        }

        private void mTextField_KeyUp(object sender, KeyEventArgs e)
        {
            if (    mTextFieldEinsatzOrt.Text != String.Empty
                 && mTextFieldProtokollLeader.Text != String.Empty
                 && mTextFieldEinsatzLeader.Text != String.Empty)
            {
                mButtonEinsatzStart.Enabled = true;
            }
        }

    }
}
