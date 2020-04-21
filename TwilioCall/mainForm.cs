using System;
using System.Windows.Forms;
using TwilioCall.Api;

namespace TwilioCall
{
    public partial class mainForm : Form
    {
        private IClient _currentApi;
        private IResponse _lastResponse;

        public mainForm()
        {
            InitializeComponent();
            LoadApis();
        }

       

        private void cbApi_SelectedValueChanged(object sender, EventArgs e)
        {
            _currentApi = cbApi.SelectedItem as IClient;

            if(_currentApi == null)
                return;

            if(!_currentApi.IsInitialized)
                _currentApi.Init();

            cbSms.Checked = _currentApi.CanSendSms;
            cbCall.Checked = _currentApi.CanCall;

            btnText.Enabled = _currentApi.CanSendSms;
            btnCall.Enabled = _currentApi.CanCall;

            txtFrom.Enabled = _currentApi.FromNumberRequired;
        }

        private async void btnText_Click(object sender, EventArgs e)
        {
            btnText.Enabled = false;

            string from = txtFrom.Text;
            string to = txtTo.Text;
            string msg = txtBody.Text;

            SetStatus("sending...");
            _lastResponse = await _currentApi.SendSmsAsync(from, to, msg);

            btnText.Enabled = true;
            SetStatus();
        }

        private async void btnCall_Click(object sender, EventArgs e)
        {
            btnText.Enabled = false;

            string from = txtFrom.Text;
            string to = txtTo.Text;
            string msg = txtBody.Text;

            SetStatus("sending...");
            
            //Can be a Prank to Call a Number Many Times
            //for (int i = 0; i < 10; i++)
            
            _lastResponse = await _currentApi.CallAsync(from, to, msg);

            btnText.Enabled = true;
            SetStatus();
        }

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if(_lastResponse == null || !_lastResponse.CanUpdate)
                return;

            await _lastResponse.UpdateAsync();
            SetStatus();
        }

        private void LoadApis()
        {
            cbApi.Items.Add(new TwilioWrapperClient(Credentials.TWILIO_ACC_SID, Credentials.TWILIO_AUTH_TOKEN));
        }

        private void SetStatus(string value)
        {
            lblStatus.Text = $"Status: {value}";
        }
        private void SetStatus()
        {
            if(_lastResponse == null)
                return;
            SetStatus(_lastResponse.Status);
        }
    }
}
