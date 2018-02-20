using Flarine.Network.Web;
using System;
using System.Windows.Forms;

namespace Flarine.Tools.Views
{
    public partial class FrmWPDTransforming : Form
    {
        public FrmWPDTransforming()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = WPDUtil.Transform(txtInput.Text, TransformMethod == Method.Decode ? "D" : "E");
            }
            catch (Exception)
            { txtResult.Text = "Invalid Input!"; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miMethod_CheckedChanged(object sender, EventArgs e)
        {
            if(TransformMethod == Method.Decode)
            {
                TransformMethod = Method.Encode;
                miMethod.Text = "Encode";
            }
            else if(TransformMethod == Method.Encode)
            {
                TransformMethod = Method.Decode;
                miMethod.Text = "Decode";
            }
            txtInput_TextChanged(sender, e);
        }
        
        private Method TransformMethod = Method.Decode;

        public enum Method
        {
            Encode,
            Decode
        }
    }
}