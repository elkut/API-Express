using PostmanCloneLibrary;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess api = new ApiAccess();		// API

        public Dashboard()
        {
            InitializeComponent();
        }


        private async void CallApi_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Calling API..";
            // Empty the result text box
            resultsBox.Text = "";

            // Validate API URL
            if (api.IsValidUrl(urlBox.Text) == false)
            {
                systemStatus.Text = "Invalid URL";
                return;
            }

            try
            {
                if (apiMethodBox.Text == "GET")
                {
                    resultsBox.Text = await api.CallApiAsync(urlBox.Text);
                }
                else if (apiMethodBox.Text == "POST")
                {
                    bodyBox.ReadOnly = false;
                    resultsBox.Text = await api.PostApiAsync(urlBox.Text, bodyBox.Text);
                }


                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsBox.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error";
            }

        }

        private void UrlBox_TextChanged(object sender, EventArgs e)
        {
            if (urlBox.Text != "")
            {
                callAPi.Enabled = true;
            }
            else
            {
                callAPi.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}