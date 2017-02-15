using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

    public struct trup
    {
        public string name;
        public string fillPressure;
    };

    public partial class atemSchutzGeneralDialog : MaterialForm
    {
        public atemSchutzGeneralDialog(bool isSicherheitsTrupp, trup truppFuehrer, trup truppMann)
        {
            InitializeComponent();

            int stringLength = truppFuehrer.fillPressure.Length;
            mTextFieldFillPressureTruppFuehrer.Text = truppFuehrer.fillPressure.Remove(stringLength - 3, 3);

            stringLength = truppMann.fillPressure.Length;
            mTextFieldFillPressureTruppMann.Text = truppMann.fillPressure.Remove(stringLength - 3, 3);

            mTextFieldNameTruppfuehrer.Text = truppFuehrer.name;
            mTextFieldNameTruppMann.Text = truppMann.name;

            if (isSicherheitsTrupp == true)
            {
                this.Text = "Sicherheits Trupp";
            }
        }

        public string getNameTruppFuehrer()
        {
            return mTextFieldNameTruppfuehrer.Text;
        }

        public string getNameTruppMann()
        {
            return mTextFieldNameTruppMann.Text;
        }

        public string getFillPressureTruppFuehrer()
        {
            return mTextFieldFillPressureTruppFuehrer.Text;
        }

        public string getFillPressureTruppMann()
        {
            return mTextFieldFillPressureTruppMann.Text;
        }
    }
}
